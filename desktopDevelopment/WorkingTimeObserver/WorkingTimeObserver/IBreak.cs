using System;
namespace WorkingTimeObserver
{
    public interface IBreak
    {
        bool CanSetStartSignal { get; }
        bool CanSetStopSignal { get; }
        TimeSpan Duration { get; }
        TimeSpan EndTime { get; }
        bool IsBreakDone { get; }
        string Name { get; }
        void Reset();
        TimeSpan StartTime { get; }
    }
}
