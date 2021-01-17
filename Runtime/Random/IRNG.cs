﻿namespace Chinchillada
{
    public interface IRNG
    {
        void SetSeed(int seed);
        float Float();
        float Range(float min, float max);
        int Range(int     min, int   max, bool inclusive = false);
    }

    public static class RNGExtensions
    {
        public static int Range(this IRNG rng, int max, bool inclusive = false)
        {
            return rng.Range(0, max, inclusive);
        }

        public static float Range(this IRNG rng, float max) => rng.Range(0, max);

        public static bool Flip(this IRNG rng, float probability = 0.5f)
        {
            return rng.Float() < probability;
        }

    }
}