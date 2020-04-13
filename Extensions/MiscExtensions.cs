﻿using System;
using System.Runtime.CompilerServices;

namespace Chinchillada.Utilities
{
    public static class MiscExtensions
    {
        public static int ToBinary(this bool value)
        {
            return value ? 1 : 0;
        }

        public static T Until<T>(this Func<T> generator, Func<T, bool> predicate)
        {
            T generation;
            do
            {
                generation = generator();
            } while (!predicate(generation));

            return generation;
        }

        public static int AsBinary(this bool value) => value ? 1 : 0;

        public static bool IsUneven(this int value)
        {
            return value.IsEven() == false;
        }

        public static bool IsEven(this int value)
        {
            return value % 2 == 0;

        }
        
        public static (int width, int height) GetShape<T>(this T[,] array)
        {
            var width = array.GetLength(0);
            var height = array.GetLength(1);

            return (width, height);
        }
    }
}
