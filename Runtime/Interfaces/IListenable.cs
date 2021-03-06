﻿using System;

namespace Chinchillada.Foundation
{
    public interface IListenable<T> where T : IEquatable<T>
    {
        event Action<T> ValueChanged;
        T Value { get; set; }
    }
}