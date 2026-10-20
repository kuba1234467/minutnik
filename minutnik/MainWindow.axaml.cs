using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace minutnik;

public partial class MainWindow : Window
{
    private readonly DispatcherTimer _timer;
    private int _remainingSeconds;
    private bool _isRunning;
    private bool _isBreak;
    private int _completedCycles;

    public MainWindow()
    {
        InitializeComponent();

        _timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        _timer.Tick += OnTimerTick;

        ResetTimer();
    }

    private void OnStartPauseClick(object? sender, RoutedEventArgs e)
    {
        if (_isRunning)
        {
            PauseTimer();
        }
        else
        {
            StartTimer();
        }
    }

    private void OnResetClick(object? sender, RoutedEventArgs e)
    {
        ResetTimer();
    }

    private void OnWorkMinutesChanged(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        if (!_isBreak)
        {
            _remainingSeconds = GetWorkSeconds();
            UpdateDisplay();
        }
    }

    private void OnBreakMinutesChanged(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        if (_isBreak)
        {
            _remainingSeconds = GetBreakSeconds();
            UpdateDisplay();
        }
    }

    private void StartTimer()
    {
        if (_remainingSeconds <= 0)
        {
            _remainingSeconds = GetCurrentPhaseSeconds();
        }

        _isRunning = true;
        _timer.Start();
        StartPauseButton.Content = "Pauza";
        UpdateDisplay();
    }

    private void PauseTimer()
    {
        _isRunning = false;
        _timer.Stop();
        StartPauseButton.Content = "Start";
        UpdateDisplay();
    }

    private void ResetTimer()
    {
        _timer.Stop();
        _isRunning = false;
        _isBreak = false;
        _completedCycles = 0;
        _remainingSeconds = GetWorkSeconds();
        StartPauseButton.Content = "Start";
        UpdateDisplay();
    }

    private void OnTimerTick(object? sender, EventArgs e)
    {
        if (_remainingSeconds > 0)
        {
            _remainingSeconds--;
        }

        if (_remainingSeconds <= 0)
        {
            if (!_isBreak)
            {
                _isBreak = true;
                _remainingSeconds = GetBreakSeconds();
                StartTimer();
            }
            else
            {
                _completedCycles++;
                _isBreak = false;
                _remainingSeconds = GetWorkSeconds();
                PauseTimer();
            }
        }

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        var minutes = _remainingSeconds / 60;
        var seconds = _remainingSeconds % 60;
        TimeText.Text = $"{minutes:00}:{seconds:00}";
        CyclesText.Text = _completedCycles.ToString();
        PhaseText.Text = _isBreak ? "Przerwa" : "Praca";
    }

    private int GetCurrentPhaseSeconds()
    {
        return _isBreak ? GetBreakSeconds() : GetWorkSeconds();
    }

    private int GetWorkSeconds()
    {
        return MinutesToSeconds(WorkMinutesBox.Value);
    }

    private int GetBreakSeconds()
    {
        return MinutesToSeconds(BreakMinutesBox.Value);
    }

    private static int MinutesToSeconds(decimal? minutes)
    {
        var value = minutes ?? 1;
        if (value < 1)
        {
            value = 1;
        }

        return (int)Math.Round(value) * 60;
    }
}
