using System;
using System.Security.Cryptography;

namespace Engine
{
    
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        /// <summary>
        /// This is the complex number generator that uses byte manipulation and is much more random
        /// (nondeterministic).
        /// </summary>
        /// <param name="minimumValue">Lower Bound of the desired random number</param>
        /// <param name="maximumValue">Upper Bound of the desired random number</param>
        /// <returns></returns>
        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // We are using Mat.Max and subracting 0.0000000001,
            // to ensure "multiplier" will always be between 0.0 and .9999999999
            // otherwise, it's possible for it to be "1", which cuases problems in our rounding.
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            // We need to add one ot the range, to allow for the rounding done with Math.Floor.
            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minimumValue + randomValueInRange);
        }

        private static readonly Random _simpleRandomNumberGenerator = new Random();
        
        /// <summary>
        /// This is the simple number generator that is less random and more deterministic.
        /// </summary>
        public static int SimpleNumberBetween(int minimumValue, int maximumValue)
        {
            return _simpleRandomNumberGenerator.Next(minimumValue, maximumValue + 1);
        }
    }
}
