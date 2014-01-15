using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace project1 {
  class Primality {

    // Class instance of random
    private static readonly Random random = new Random();

    public bool testPrimality(BigInteger num, int prob) {
      // Probability Loop
      foreach (int i in Enumerable.Range(1, prob)) {
        // Get a uniform number
        BigInteger uniform = uniformNumber(num);
        // If Femat's theorem does not produce a 1, then it's not a prime
        if (modularExponentiation(uniform, BigInteger.Subtract(num, 1), num) != 1) return false;
      }
      return true;
    }

    public BigInteger modularExponentiation(BigInteger b, BigInteger power, BigInteger num) {
      // Recursive base case, we don't want a multiply by 0
      if (power == 0) return 1;

      // Recursive call and Shift the power to the right
      BigInteger z = modularExponentiation(b, BigInteger.Divide(power, 2), num);
      // Check to see if the bit is odd or even
      // Then, perform multiplication followed by modular reduction
      if (power.IsEven) return BigInteger.Pow(z, 2) % num;
      else {
        // Odd bit, so we multiply it by "b"
        BigInteger z_squared = BigInteger.Pow(z, 2);
        return BigInteger.Multiply(z_squared, b) % num;
      }
    }

    public BigInteger uniformNumber(BigInteger max) {
      // Get the bit count of a number (rounding up)
      double bit_count = BigInteger.Log(max, 2);
      int length = (int)Math.Ceiling(bit_count);

      // Grab some random int from the persisted random instance
      int random_int = random.Next();

      // Generate some BigInt with at least bit_count above
      BigInteger random_number = 0;
      for (int i = 0; i <= length / 32; i++)
        random_number = (random_number << 32) + random.Next();

      // Ensure that number is between 1 and max-1
      return random_number % (max - 1) + 1;
    }

    public double determineProbability(int prob) {
      // Simple Determine Probabiliy for the above alogrithm
      return (1 - (1 / Math.Pow(2, prob))) * 100;
    }

  }
}
