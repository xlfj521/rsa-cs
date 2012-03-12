using System;
using System.Collections.Generic;
using System.Text;

namespace RSA
{
    /// <summary>
    /// Lớp tự xây dựng để kiểm thử độ chính xác của các thuật toán
    /// </summary>
    class MyBigInt : BigInteger
    {
        public MyBigInt()
            : base(0)
        {
        }
        public MyBigInt(BigInteger b)
            : base(b)
        {
        }
        /// <summary>
        /// Tìm phần tử nghịch đảo trên vành Zn
        /// </summary>
        /// <param name="n">A big integer</param>
        /// <returns>A big integer</returns>
        public BigInteger ModInverse(BigInteger n)
        {
            BigInteger m = new BigInteger(n);
            BigInteger a = new BigInteger(this);
            BigInteger y0 = new BigInteger(0);
            BigInteger y1 = new BigInteger(1);
            BigInteger r, q, y = new BigInteger(1);

            while (a > 0)
            {
                r = m % a;
                if (r == 0) break;
                q = m / a;
                y = y0 - y1 * q;
                m = a;
                a = r;
                y0 = y1;
                y1 = y;
            }
            if (a > 1) throw (new ArithmeticException("No inverse!"));
            if (y > 0)
                return y;
            else
                return y + n;
        }
        /// <summary>
        /// Tính a^x mod n
        /// </summary>
        /// <param name="exp">The exponent</param>
        /// <param name="n">A big Integer</param>
        /// <returns>A big Integer</returns>
        public BigInteger ModExp(BigInteger x, BigInteger n)
        {
            if (x<1)
                throw (new ArithmeticException("Positive exponents only."));
            BigInteger r = new BigInteger(1);
            BigInteger a = new BigInteger(this);
            while (x > 0)
            {
                if((x & 1) == 1)
                {
                    r = (r * a) % n;
                }
                a = (a * a) % n;
                x >>= 1;
            }
            return r;
        }
    }
}
