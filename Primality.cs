using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace project1 {
  class Primality {

    private static readonly Random random = new Random();

    public bool testPrimality(BigInteger num, int prob) {
      // Probability Loop
      foreach (int i in Enumerable.Range(1, prob)) {
        BigInteger rand = uniformNumber(num);

        if (modularExponentiation(rand, BigInteger.Subtract(num, 1), num) != 1) return false;
      }
      return true;
    }

    public BigInteger modularExponentiation(BigInteger b, BigInteger power, BigInteger num) {
      if (power == 0) return 1;

      BigInteger z = modularExponentiation(b, BigInteger.Divide(power, 2), num);

      if (power.IsEven) return BigInteger.Pow(z, 2) % num;
      else {
        BigInteger z_squared = BigInteger.Pow(z, 2);
        return BigInteger.Multiply(z_squared, b) % num;
      }
    }

    public BigInteger uniformNumber(BigInteger max) {
      double bit_count = BigInteger.Log(max, 2);
      int length = (int)Math.Ceiling(bit_count);

      int random_int = random.Next();

      BigInteger random_number = 0;
      for (int i = 0; i <= length / 32; i++)
        random_number = (random_number << 32) + random.Next();

      return random_number % (max - 1) + 1;
    }

    public double determineProbability(int prob) {
      return (1 - (1 / Math.Pow(2, prob))) * 100;
    }

  }
}
