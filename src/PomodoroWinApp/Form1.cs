using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PomodoroWinApp
{
    public partial class Form1 : Form
    {
        private const int TIMER_INTERVAL = 1000;
        private const int TIMER_INTERVAL_IN_TICKS = 1000 * (int)TimeSpan.TicksPerMillisecond;

        private const string LOG_ERROR_PLAYING_A_SOUND = "Error playing a sound: {0}";
        private const string LOG_POMODORO_COMPLETED = "Pomodoro {0} of {1} finished at {2}";
        private const string LOG_POMODORO_STARTED_AT = "Pomodoro {0} of {1} started at {2}";
        private const string LOG_READY_FOR_POMODORO = "Ready for Pomodoro #{0}";
        private const string LOG_LONG_BREAK_COMPLETED = "Long Break completed at {0}";
        private const string LOG_LONG_BREAK_STARTED_AT = "Long Break started at {0}";
        private const string LOG_READY_FOR_LONG_BREAK = "Ready for a Large Break";
        private const string LOG_SHORT_BREAK_COMPLETED = "Short Break completed at {0}";
        private const string LOG_SHORT_BREAK_STARTED_AT = "Short Break started at {0}";
        private const string LOG_READY_FOR_SHORT_BREAK = "Ready for a Short Break";
        private const string LOG_ROUNDS_COMPLETED = "Rounds completed {0} at {1}";

        private const string ACTION_LONG_BREAK = "Long Break";
        private const string ACTION_POMODORO = "Start Pomodoro";
        private const string ACTION_SHORT_BREAK = "Short Break";
        private const string DEFAULT_TIMING = "00:00";
        private const string FINISHED_LONG_BREAK = "Finished Long Break";
        private const string FINISHED_SHORT_BREAK = "Finished Short Break";
        private const string FINISHED_POMODORO = "Finished Pomodoro";
        private const string FORMAT_TIMING = "{0:mm:ss}";
        private const string NOT_STARTED = "- Not Started -";
        private const string POMODOROS_COMPLETED = "Pomodoro {0} of {1} completed";
        private const string READY_FOR_LONG_BREAK = "Ready for a Long Break";
        private const string ROUNDS_COMPLETED = "Rounds completed: {0}";
        private const string RUNNING_POMODORO = "Running Pomodoro";
        private const string TAKING_LONG_BREAK = "Taking a Long Break";
        private const string TAKING_SHORT_BREAK = "Taking a Short Break";

        private readonly string _longBreakSound = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Sounds\LongBreak.wav";
        private readonly string _pomodoroSound = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Sounds\Pomodoro.wav";
        private readonly string _shortBreakSound = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Sounds\ShortBreak.wav";

        private readonly int _windowWidth = 0;
        private readonly int _windowHeight = 0;

        private Timer _timer = new Timer();
        private int _roundsCompleted = 0;
        private long _startTime;
        private long _currentInterval;
        private bool _isLongBreak = false;
        private bool _isPomodoroSession = true;
        private long _progress = 0;
        private TaskbarProgressBarState _state = TaskbarProgressBarState.NoProgress;
        private int _pomodorosCompleted = 0;

        private StringBuilder _log;

        public Form1()
        {
            InitializeComponent();

            _windowWidth = Width;
            _windowHeight = Height;
        }

        private void SetHeightWindow()
        { 
            Height = textBoxLog.Location.Y + 40;
        }

        private void SetNormalWindow()
        {
            Width = panel1.Location.X + 20;
            SetHeightWindow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetNormalWindow();
            lblPomodoro.Text = String.Format(ROUNDS_COMPLETED, _roundsCompleted);

            InitializeTimer();

            ResetApplication(false);
        }

        private void InitializeTimer()
        {
            _timer.Interval = TIMER_INTERVAL;
            _timer.Tick += timer_Tick;
        }

        private void PlaySound(string sound)
        {
            if (checkBoxEnableSounds.Checked)
            {
                try
                {
                    new SoundPlayer(sound).Play();
                }
                catch (Exception ex) 
                {
                    _log.AppendLine(String.Format(LOG_ERROR_PLAYING_A_SOUND, ex.Message));
                }
            }
        }

        private void SetStatusLabel(Color color, string text)
        {
            lblStatusText.ForeColor = color;
            lblStatusText.Text = text;
        }

        private void SetStartButton(Color color, string text)
        {
            Start.BackColor = color;
            Start.Text = text;
        }

        private void EnableControls(bool asNormalSize = true)
        {
            Settings.Enabled = asNormalSize;
            Settings.Visible = asNormalSize;
            Contract.Enabled = !asNormalSize;
            panel1.Enabled = !asNormalSize;
        }

        private void LockControls(bool lockAll = true)
        {
            Start.Enabled = lockAll;
            Reset.Enabled = lockAll;
            Settings.Enabled = lockAll;
            panel1.Enabled = lockAll;
        }

        private void SetNormalState()
        {
            _state = TaskbarProgressBarState.Normal;
            _progress = 0;
        }

        private void CompletePomodoro()
        {
            _timer.Stop();

            _log.AppendLine(String.Format(LOG_POMODORO_COMPLETED, _pomodorosCompleted + 1, numericUpDownPomodorosByRound.Value, DateTime.Now));

            PlaySound(_pomodoroSound);

            _state = TaskbarProgressBarState.Error;
            _pomodorosCompleted++;

            lblCompletedCount.Text = String.Format(POMODOROS_COMPLETED, _pomodorosCompleted, numericUpDownPomodorosByRound.Value);

            if (_pomodorosCompleted == Convert.ToInt32(numericUpDownPomodorosByRound.Value))
                _roundsCompleted++;

            SetStatusLabel(Color.DarkBlue, FINISHED_POMODORO);
            SetStartButton(Color.MediumSeaGreen, ACTION_SHORT_BREAK);

            lblTimer.Text = DEFAULT_TIMING;
            
            _log.AppendLine(LOG_READY_FOR_SHORT_BREAK);

            LockControls();

            _isPomodoroSession = false;

            lblPomodoro.Text = String.Format(ROUNDS_COMPLETED, _roundsCompleted);
        }

        private void CompleteBreak()
        {
            _timer.Stop();

            if (_isLongBreak)
            {
                _log.AppendLine(String.Format(LOG_LONG_BREAK_COMPLETED, DateTime.Now));
                _log.AppendLine(String.Format(LOG_ROUNDS_COMPLETED, _roundsCompleted, DateTime.Now) + Environment.NewLine);
                PlaySound(_longBreakSound);
            }
            else
            {
                _log.AppendLine(String.Format(LOG_SHORT_BREAK_COMPLETED, DateTime.Now));
                PlaySound(_shortBreakSound);
            }

            _state = TaskbarProgressBarState.Error;

            if (_pomodorosCompleted == Convert.ToInt32(numericUpDownPomodorosByRound.Value))
            {
                _pomodorosCompleted = 0;
                lblCompletedCount.Text = String.Empty;

                SetStatusLabel(Color.DarkCyan, READY_FOR_LONG_BREAK);
                SetStartButton(Color.YellowGreen, ACTION_LONG_BREAK);

                _log.AppendLine(LOG_READY_FOR_LONG_BREAK);

                _isLongBreak = true;
            }
            else
            {
                if (_isLongBreak)
                    SetStatusLabel(Color.DarkBlue, FINISHED_LONG_BREAK);
                else
                    SetStatusLabel(Color.DarkBlue, FINISHED_SHORT_BREAK);

                SetStartButton(Color.LightCoral, ACTION_POMODORO);

                _log.AppendLine(String.Format(LOG_READY_FOR_POMODORO, _pomodorosCompleted + 1));
            }

            lblTimer.Text = DEFAULT_TIMING;

            LockControls();

            _isPomodoroSession = true;

            if (_roundsCompleted > 1440)
                _roundsCompleted = 0;
        }

        private void UpdateTaskbar()
        {
            TaskbarManager.Instance.SetProgressState(_state);
            TaskbarManager.Instance.SetProgressValue((int)(_progress / TIMER_INTERVAL_IN_TICKS), (int)(_currentInterval / TIMER_INTERVAL_IN_TICKS));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now.Ticks;
            var elapsedTime = currentTime - _startTime;

            var dateTime = new DateTime(elapsedTime);
            lblTimer.Text = String.Format(FORMAT_TIMING, dateTime);

            if (elapsedTime >= _currentInterval)
            {
                if (_isLongBreak)
                {
                    CompleteBreak();
                    _isLongBreak = false;
                }
                else
                {
                    if (_isPomodoroSession)
                        CompletePomodoro();
                    else
                        CompleteBreak();
                }
            }
            else
                _state = TaskbarProgressBarState.Normal;

            _progress = elapsedTime;
            UpdateTaskbar();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            EnableControls(false);

            Width = _windowWidth;
        }

        private void Contract_Click(object sender, EventArgs e)
        {
            EnableControls();

            SetNormalWindow();
        }

        private void ResetPomodoro()
        {
            _timer.Stop();

            SetNormalState();

            _roundsCompleted = 0;

            lblPomodoro.Text = String.Format(ROUNDS_COMPLETED, _roundsCompleted);

            SetStartButton(Color.LightCoral, ACTION_POMODORO);

            _isLongBreak = false;
            _isPomodoroSession = true;

            _pomodorosCompleted = 0;

            lblCompletedCount.Text = String.Empty;

            SetStatusLabel(Color.Black, NOT_STARTED);

            lblTimer.Text = DEFAULT_TIMING;
        }

        private void ResetApplication(bool updateTaskBar = true)
        {
            _log = new StringBuilder();
            SetHeightWindow();

            ResetPomodoro();

            _log.AppendLine(String.Format(LOG_READY_FOR_POMODORO, _pomodorosCompleted + 1));

            if (updateTaskBar)
                UpdateTaskbar();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetApplication();
        }

        private void StartPomodoro()
        {
            _log.AppendLine(String.Format(LOG_POMODORO_STARTED_AT, _pomodorosCompleted + 1, numericUpDownPomodorosByRound.Value, DateTime.Now));

            LockControls(false);

            _currentInterval = Convert.ToInt64(numericUpDownWorkInterval.Value) * TimeSpan.TicksPerMinute;
            _timer.Start();

            SetNormalState();

            _startTime = DateTime.Now.Ticks;

            SetStatusLabel(Color.Red, RUNNING_POMODORO);
        }

        private void StartBreak()
        {
            LockControls(false);

            if (_isLongBreak)
            {
                _currentInterval = Convert.ToInt64(numericUpDownBreakByRound.Value) * TimeSpan.TicksPerMinute;

                SetStatusLabel(Color.DarkGreen, TAKING_LONG_BREAK);

                _log.AppendLine(String.Format(LOG_LONG_BREAK_STARTED_AT, DateTime.Now));
            }
            else
            {
                _currentInterval = Convert.ToInt64(numericUpDownBreakInterval.Value) * TimeSpan.TicksPerMinute;

                SetStatusLabel(Color.DarkGreen, TAKING_SHORT_BREAK);
            
                _log.AppendLine(String.Format(LOG_SHORT_BREAK_STARTED_AT, DateTime.Now));
            }

            _timer.Start();

            SetNormalState();
            
            _startTime = DateTime.Now.Ticks;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            SetHeightWindow();

            if (_isPomodoroSession && !_isLongBreak)
                StartPomodoro();
            else
                StartBreak();

            UpdateTaskbar();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = _log.ToString();
            
            if (Height == _windowHeight)
                SetHeightWindow();
            else
                Height = _windowHeight;
        }
    }
}