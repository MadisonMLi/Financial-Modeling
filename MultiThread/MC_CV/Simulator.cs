using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_CV
{
    /// <summary>
    /// This is a sealed class which has methods generating normally distributed variables and get underlying price path.
    /// </summary>
    sealed class Simulator
    {
        // M is number of simulation
        public int M { get; set; }
        // N is steps(number of time intervals)
        public int N { get; set; }
        // Judge if use antithetic variance
        public bool Anti { get; set; }
        // Judge if use delta control variate
        public bool CV { get; set; }
        // Judge if use multithreads
        public bool Multi { get; set; }

        /// <summary>
        /// This is a method to generate normally distributed variables
        /// </summary>
        /// <returns> Normally distributed variables matrix </returns>
        public double[,] Norm_polar()
        {
            double[,] norm = new double[M, N + 1];

            if (Multi == false)
            {
                Random rnd = new Random();

                for (int i = 0; i <= M - 1; i++)
                {
                    for (int j = 0; j <= N; j++)
                    {
                        norm[i, j] = Generate_PolarRnd(rnd);
                    }
                }
            }
            else
            {
                Parallel.For(0, M, i =>
                {
                    byte[] ByteValue = Guid.NewGuid().ToByteArray();
                    int seed = BitConverter.ToInt32(ByteValue, 0);
                    Random rnd2 = new Random(seed);

                    Parallel.For(0, N + 1, j =>
                    {
                        norm[i, j] = Generate_PolarRnd(rnd2);
                    });
                });
            }

            return norm;
        }

        /// <summary>
        /// This is a method to get Price Path.
        /// </summary>
        /// <param name="S"> Underlying price at time 0. </param> 
        /// <param name="T"> Tenor of options </param>
        /// <param name="r"> Interest rate </param>
        /// <param name="sigma"> Volatility </param>
        /// <param name="sig"> Normally distributed random variables. </param>
        /// <returns> Underlying price path </returns>
        public double[,] GetSt(double S, double T, double r, double sigma, double[,] sig)
        {

            double dt = T / N;
            double nudt = (r - sigma * sigma / 2) * dt;

            if (Anti == true)
            {
                double[,] St = new double[2 * M, N + 1];

                if (Multi == false)
                {
                    for (int i = 0; i <= M - 1; i++)
                    {
                        // Initial St
                        St[i, 0] = S;
                        St[i + M, 0] = S;

                        for (int j = 1; j <= N; j++)
                        {
                            // Calculate simulated price path.
                            St[i, j] = St[i, j - 1] * Math.Exp(nudt + sigma * Math.Sqrt(dt) * sig[i, j]);
                            // Calculate simulated price path with antithentic variance.
                            St[i + M, j] = St[i + M, j - 1] * Math.Exp(nudt - sigma * Math.Sqrt(dt) * sig[i, j]);
                        }
                    }
                }
                else
                {
                    Parallel.For(0, M, i =>
                      {
                          // Initial St
                          St[i, 0] = S;
                          St[i + M, 0] = S;
                      });

                      Parallel.For(0, M, i =>
                      {

                          for (int j = 1; j <= N; j++)
                          {
                              // Calculate simulated price path.
                              St[i, j] = St[i, j - 1] * Math.Exp(nudt + sigma * Math.Sqrt(dt) * sig[i, j]);
                              // Calculate simulated price path with antithentic variance.
                              St[i + M, j] = St[i + M, j - 1] * Math.Exp(nudt - sigma * Math.Sqrt(dt) * sig[i, j]);
                          }
                      });
                }
                
                return St;
            }
            else
            {
                double[,] St = new double[M, N + 1];

                if (Multi == false)
                {
                    for (int i = 0; i <= M - 1; i++)
                    {
                        // Initial St
                        St[i, 0] = S;

                        for (int j = 1; j <= N; j++)
                        {
                            // Calculate simulated price path.
                            St[i, j] = St[i, j - 1] * Math.Exp(nudt + sigma * Math.Sqrt(dt) * sig[i, j]);
                        }
                    }
                }
                else
                {
                    Parallel.For(0, M, i =>
                    {
                        // Initial St
                        St[i, 0] = S;
                    });

                    Parallel.For(0, M, i =>
                    {
                        for (int j = 1; j <= N; j++)
                        {
                            // Calculate simulated price path.
                            St[i, j] = St[i, j - 1] * Math.Exp(nudt + sigma * Math.Sqrt(dt) * sig[i, j]);
                        }
                    });
                }
                return St;
            }

        }

        /// <summary>
        /// This is a method to generate uniformly distributed random numbers
        /// </summary>
        /// <returns>Return an array of random numbers</returns>
        static private double Generate_PolarRnd(Random rnd)
        {
            double randn1, randn2;
            double c, w;

            // if w > 1, repeat generating 2 uniform variables, if not, continue
            do
            {
                // Generate uniform random variable in [-1,1]
                randn1 = 2 * rnd.NextDouble() - 1;
                randn2 = 2 * rnd.NextDouble() - 1;

                w = randn1 * randn1 + randn2 * randn2;

            } while (w > 1);

            c = Math.Sqrt(-2 * Math.Log(w) / w);
            // Get normally distributed random variables.
            double polar = c * randn1;

            return polar;
        }

    }
}
