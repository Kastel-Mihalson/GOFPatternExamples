﻿namespace CommandPattern
{
    public interface ICommand
    {
        void Execute();
        void Cancel();
    }
}