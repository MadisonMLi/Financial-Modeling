using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_CV
{
    public static class BS
    {
        /// <summary>
        /// This is a method to calculate delta using black-scholes fomula.
        /// </summary>
        /// <param name="Iscall">Judge whether call or put options</param>
        /// <param name="S">Underlying prices</param>
        /// <param name="K">Strike prices</param>
        /// <param name="r">Interest rate</param>
        /// <param name="sigma">Volatility of underlying price</param>
        /// <param name="T">Options tenor</param>
        /// <param name="t">Passed time period</param>
        /// <returns></returns>
        public static double BS_Delta(bool Iscall, double S, double K, double r, double sigma, double T, double t)
        {
            double d1;
            double delta;
            // Calculate d1
            d1 = (Math.Log(S / K) + (r + (sigma * sigma) / 2) * (T-t)) / (sigma * Math.Sqrt(T-t));
            // Judge if it's call option
            if (Iscall == true)
            {
                // Using cdf function in "MathNet"package to calculate delta
                delta = cdf(d1);
            }
            else
            {
                delta = cdf(d1) - 1;
            }

            return delta;
        }

        /// <summary>
        /// Normal CDF function from Internate
        /// </summary>
        /// <param name="d">Parameter in Black-Scholes model</param>
        /// <returns>Responding quantile</returns>
        private static double cdf(double d)
        {
            const double A1 = 0.31938153;
            const double A2 = -0.356563782;
            const double A3 = 1.781477937;
            const double A4 = -1.821255978;
            const double A5 = 1.330274429;
            const double RSQRT2PI = 0.39894228040143267793994605993438;

            double
            K = 1.0 / (1.0 + 0.2316419 * Math.Abs(d));

            double
            cnd = RSQRT2PI * Math.Exp(-0.5 * d * d) *
                  (K * (A1 + K * (A2 + K * (A3 + K * (A4 + K * A5)))));

            if (d > 0)
                cnd = 1.0 - cnd;

            return cnd;
        }

    }
}
