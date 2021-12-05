﻿namespace Six.Core
{
    public interface ILocation
    {
        Source Source { get; }
        int Offset { get; }
        int Length { get; }

        string GetText();
    }
}
