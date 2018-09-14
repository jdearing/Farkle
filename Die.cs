using System;

namespace Farkle
{
    public class Die
    {
        private readonly Random _random;
        public Die(int seed)
        {
            _random = new Random(seed);
        }

        public int Role()
        {
            return _random.Next(1, 6);
        }
    }
}