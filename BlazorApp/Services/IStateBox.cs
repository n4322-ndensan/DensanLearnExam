﻿namespace BlazorApp.Services;

public interface IStateBox<T>
{
    T? State { get; set; }
    bool HasState { get; }
}
