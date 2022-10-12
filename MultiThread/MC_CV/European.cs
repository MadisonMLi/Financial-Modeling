using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_CV
{
    /// <summary>
    /// European class is to calculate European options' prices and responding Greek values. 
    /// </summary>
    class European : Options
    {
        public double Strike { get; set; }
        public bool Iscall { get; set; }

        /// <summary>
        /// This is an override method to calculate European options' prices and standard error.
        /// </summary>
        /// <param name="S"> Underlying price at time 0. </param> 
        /// <param name="r"> Interest rate. </param> 
        /// <param name="sigma"> Volatility. </param> 
        /// <param name="T"> Tenor of option. </param> 
        /// <param name="sig"> Normally distributed random variables. </param> 
        /// <param name="sim"> Simulator class which has properties of steps and trails and some methods. </param> 
        /// <returns></returns>
        public override double[,] GetPrice(double S, double r, double sigma, double T, double[,] sig, Simulator sim)
        {
            int M = sim.M;
            int N = sim.N;
            bool anti = sim.Anti;
            bool CV = sim.CV;
            bool Muti = sim.Multi;

            // Get underlying price paths.
            double[,] St = sim.GetSt(S, T, r, sigma, sig);
            double V0, SE;
            double SumCt = 0;
            double SumCt2 = 0;
            double[,] result = new double[1, 2];

            // Judge what kind of ways users want to choose
            if (Muti == false)
            {
                if (anti == false && CV == false)
                {
                    double[] Ct = new double[M];

                    for (int i = 0; i <= M - 1; i++)
                    {
                        // Judge if it's a call option.
                        if (Iscall == true)
                        {
                            // Pay-off at time T.
                            Ct[i] = Math.Max(St[i, N] - Strike, 0);
                        }
                        else
                        {
                            // Pay-off at time T.
                            Ct[i] = Math.Max(St[i, N] - Strike, 0);
                        }

                        SumCt += Ct[i];
                        SumCt2 += Ct[i] * Ct[i];
                    }

                    // Calculate option value.
                    V0 = SumCt / M * Math.Exp(-r * T);
                    // Calculate standard error.
                    SE = Math.Sqrt((SumCt2 - SumCt * SumCt / M) * Math.Exp(-2 * r * T)) / Math.Sqrt(M - 1) / Math.Sqrt(M);

                    result[0, 0] = V0;
                    result[0, 1] = SE;

                    return result;
                }
                else if (anti == true && CV == false)
                {
                    double[] Ct = new double[2 * M];
                    double var;


                    for (int i = 0; i <= M - 1; i++)
                    {
                        // Judge if it's a call option.
                        if (Iscall == true)
                        {
                            // Pay-off at time T.
                            Ct[i] = Math.Max(St[i, N] - Strike, 0);
                            Ct[i + M] = Math.Max(St[i + M, N] - Strike, 0);
                        }
                        else
                        {
                            // Pay-off at time T.
                            Ct[i] = Math.Max(Strike - St[i, N], 0);
                            Ct[i + M] = Math.Max(Strike - St[i + M, N], 0);
                        }

                        // Sum of pay-off at time T.
                        SumCt += (Ct[i] + Ct[i + M]);
                        // Sum squre of Vt and antithetic Vt.
                        SumCt2 += Math.Pow((Ct[i] + Ct[i + M]) / 2, 2);
                    }

                    // Calculate option value.
                    V0 = SumCt / M * Math.Exp(-r * T) / 2;
                    // Calculate standard error.
                    var = (SumCt2 / M) - Math.Pow(SumCt / (2 * M), 2);
                    SE = Math.Sqrt(var / M) * Math.Exp(-r * T);

                    result[0, 0] = V0;
                    result[0, 1] = SE;

                    return result;
                }
                else if (anti == false && CV == true)
                {
                    double[] Ct = new double[M];

                    for (int i = 0; i <= M - 1; i++)
                    {
                        double CV_Value = 0;

                        for (int j = 1; j <= N; j++)
                        {
                            // Define what time is it when calculate the delta.
                            double t = (j - 1) * (T / N);
                            // Calculate delta
                            double delta = BS.BS_Delta(Iscall, St[i, j - 1], Strike, r, sigma, T, t);
                            // Calculate delta control variate
                            CV_Value += delta * (St[i, j] - St[i, j - 1] * Math.Exp(r * T / N));
                        }

                        // Judge if it's a call option.
                        if (Iscall == true)
                        {
                            // Get option premium inflated at the riskless rate to the maturity date.
                            Ct[i] = Math.Max(St[i, N] - Strike, 0) - CV_Value;
                        }
                        else
                        {
                            // Get option premium inflated at the riskless rate to the maturity date.
                            Ct[i] = Math.Max(Strike - St[i, N], 0) - CV_Value;
                        }

                        // Sum of premium at time T.
                        SumCt += Ct[i];
                        // Sum of premium square at time T.
                        SumCt2 += Ct[i] * Ct[i];
                    }

                    // Calculate option value.
                    V0 = SumCt / M * Math.Exp(-r * T);
                    // Calculate standard error.
                    SE = Math.Sqrt((SumCt2 - SumCt * SumCt / M) * Math.Exp(-2 * r * T)) / Math.Sqrt(M - 1) / Math.Sqrt(M);

                    result[0, 0] = V0;
                    result[0, 1] = SE;

                    return result;
                }
                else
                {
                    double[] Ct = new double[2 * M];

                    // Judge if it's a call option.

                    for (int i = 0; i <= M - 1; i++)
                    {
                        double CV_Value1 = 0;
                        double CV_Value2 = 0;

                        for (int j = 1; j <= N; j++)
                        {
                            // Define what time is it when calculate the delta.
                            double t = (j - 1) * (T / N);
                            // Calculate delta
                            double delta1 = BS.BS_Delta(Iscall, St[i, j - 1], Strike, r, sigma, T, t);
                            double delta2 = BS.BS_Delta(Iscall, St[i + M, j - 1], Strike, r, sigma, T, t);
                            // Calculate delta control variate
                            CV_Value1 += delta1 * (St[i, j] - St[i, j - 1] * Math.Exp(r * T / N));
                            CV_Value2 += delta2 * (St[i + M, j] - St[i + M, j - 1] * Math.Exp(r * T / N));
                        }
                        if (Iscall == true)
                        {
                            // Get option premium inflated at the riskless rate to the maturity date.
                            Ct[i] = 0.5 * (Math.Max(St[i, N] - Strike, 0) - CV_Value1 +
                                Math.Max(St[i + M, N] - Strike, 0) - CV_Value2);
                        }
                        else
                        {
                            // Get option premium inflated at the riskless rate to the maturity date.
                            Ct[i] = 0.5 * (Math.Max(Strike - St[i, N], 0) - CV_Value1 +
                                Math.Max(Strike - St[i + M, N], 0) - CV_Value2);
                        }

                        // Sum of premium at time T.
                        SumCt += Ct[i];
                        // Sum of premium square at time T.
                        SumCt2 += Ct[i] * Ct[i];
                    }

                    // Calculate option value.
                    V0 = SumCt / M * Math.Exp(-r * T);
                    // Calculate standard error.
                    SE = Math.Sqrt((SumCt2 - SumCt * SumCt / M) * Math.Exp(-2 * r * T)) / Math.Sqrt(M - 1) / Math.Sqrt(M);

                    result[0, 0] = V0;
                    result[0, 1] = SE;

                    return result;
                }

            }
            // Use Multithread
            else
            {
                if (anti == false && CV == false)
                {
                    double[] Ct = new double[M];


                    Parallel.For(0, M, i =>
                    {
                        // Judge if it's a call option.
                        if (Iscall == true)
                        {
                            // Pay-off at time T.
                            Ct[i] = Math.Max(St[i, N] - Strike, 0);
                        }
                        else
                        {
                            // Pay-off at time T.
                            Ct[i] = Math.Max(Strike - St[i, N], 0);
                        }
                    });
                    for (int i = 0; i <= M - 1; i++)
                    {
                        SumCt += Ct[i];
                        SumCt2 += Ct[i] * Ct[i];
                    }

                    // Calculate option value.
                    V0 = SumCt / M * Math.Exp(-r * T);
                    // Calculate standard error.
                    SE = Math.Sqrt((SumCt2 - SumCt * SumCt / M) * Math.Exp(-2 * r * T)) / Math.Sqrt(M - 1) / Math.Sqrt(M);

                    result[0, 0] = V0;
                    result[0, 1] = SE;

                    return result;
                }
                else if (anti == true && CV == false)
                {
                    double[] Ct = new double[2 * M];
                    double var;

                    Parallel.For(0, M, i =>
                    {
                        // Judge if it's a call option.
                        if (Iscall == true)
                        {
                            // Pay-off at time T.
                            Ct[i] = Math.Max(St[i, N] - Strike, 0);
                            Ct[i + M] = Math.Max(St[i + M, N] - Strike, 0);
                        }
                        else
                        {
                            // Pay-off at time T.
                            Ct[i] = Math.Max(Strike - St[i, N], 0);
                            Ct[i + M] = Math.Max(Strike - St[i + M, N], 0);
                        }
                    });
                    for (int i = 0; i <= M - 1; i++)
                    {
                        // Sum of pay-off at time T.
                        SumCt += (Ct[i] + Ct[i + M]);
                        // Sum squre of Vt and antithetic Vt.
                        SumCt2 += Math.Pow((Ct[i] + Ct[i + M]) / 2, 2);
                    }

                    // Calculate option value.
                    V0 = SumCt / M * Math.Exp(-r * T) / 2;
                    // Calculate standard error.
                    var = (SumCt2 / M) - Math.Pow(SumCt / (2 * M), 2);
                    SE = Math.Sqrt(var / M) * Math.Exp(-r * T);

                    result[0, 0] = V0;
                    result[0, 1] = SE;

                    return result;
                }
                else if (anti == false && CV == true)
                {
                    double[] Ct = new double[M];

                    Parallel.For(0, M, i =>
                    {
                       double CV_Value = 0;

                       for (int j = 1; j <= N; j++)
                       {
                            // Define what time is it when calculate the delta.
                            double t = (j - 1) * (T / N);
                            // Calculate delta
                            double delta = BS.BS_Delta(Iscall, St[i, j - 1], Strike, r, sigma, T, t);
                            // Calculate delta control variate
                            CV_Value += delta * (St[i, j] - St[i, j - 1] * Math.Exp(r * T / N));
                       }
                        // Judge if it's a call option.
                       if (Iscall == true)
                       {
                            // Get option premium inflated at the riskless rate to the maturity date.
                            Ct[i] = Math.Max(St[i, N] - Strike, 0) - CV_Value;
                       }
                       else
                       {
                            // Get option premium inflated at the riskless rate to the maturity date.
                            Ct[i] = Math.Max(Strike - St[i, N], 0) - CV_Value;
                       }
                       lock (this)
                       {
                            // Sum of premium at time T.
                            SumCt += Ct[i];
                            // Sum of premium square at time T.
                            SumCt2 += Ct[i] * Ct[i];
                       }
                    });

                    // Calculate option value.
                    V0 = SumCt / M * Math.Exp(-r * T);
                    // Calculate standard error.
                    SE = Math.Sqrt((SumCt2 - SumCt * SumCt / M) * Math.Exp(-2 * r * T)) / Math.Sqrt(M - 1) / Math.Sqrt(M);

                    result[0, 0] = V0;
                    result[0, 1] = SE;

                    return result;
                }
                else
                {
                    double[] Ct = new double[2 * M];


                    Parallel.For(0, M, i =>
                    {
                        double CV_Value1 = 0;
                        double CV_Value2 = 0;

                        for (int j = 1; j <= N; j++)
                        {
                            // Define what time is it when calculate the delta.
                            double t = (j - 1) * (T / N);
                            // Calculate delta
                            double delta1 = BS.BS_Delta(Iscall, St[i, j - 1], Strike, r, sigma, T, t);
                            double delta2 = BS.BS_Delta(Iscall, St[i + M, j - 1], Strike, r, sigma, T, t);
                            // Calculate delta control variate
                            CV_Value1 += delta1 * (St[i, j] - St[i, j - 1] * Math.Exp(r * T / N));
                            CV_Value2 += delta2 * (St[i + M, j] - St[i + M, j - 1] * Math.Exp(r * T / N));
                        }

                        // Judge if it's a call option.
                        if (Iscall == true)
                        {
                            // Get option premium inflated at the riskless rate to the maturity date.
                            Ct[i] = 0.5 * (Math.Max(St[i, N] - Strike, 0) - CV_Value1 +
                                Math.Max(St[i + M, N] - Strike, 0) - CV_Value2);
                        }
                        else
                        {
                            // Get option premium inflated at the riskless rate to the maturity date.
                            Ct[i] = 0.5 * (Math.Max(Strike - St[i, N], 0) - CV_Value1 +
                                Math.Max(Strike - St[i + M, N], 0) - CV_Value2);
                        }
                        lock(this)
                        {
                            // Sum of premium at time T.
                            SumCt += Ct[i];
                            // Sum of premium square at time T.
                            SumCt2 += Ct[i] * Ct[i];
                        }

                    });

                    // Calculate option value.
                    V0 = SumCt / M * Math.Exp(-r * T);
                    // Calculate standard error.
                    SE = Math.Sqrt((SumCt2 - SumCt * SumCt / M) * Math.Exp(-2 * r * T)) / Math.Sqrt(M - 1) / Math.Sqrt(M);

                    result[0, 0] = V0;
                    result[0, 1] = SE;

                    return result;
                }
            }
        }
    
        /// <summary>
        /// This is an override method to calculate delta.
        /// </summary>
        /// <param name="sig"> Normally distributed random variables. </param>
        /// <param name="sim"> Simulator class which has properties of steps and trails and some methods. </param>
        /// <returns> Get delta </returns>
        public override double GetDelta(double[,] sig, Simulator sim)
        {
            double r = YieldPoint.Rate;
            double diff = 0.001 * UnderlyingPrice.Price;
            double S_up = UnderlyingPrice.Price + diff;
            double S_down = UnderlyingPrice.Price - diff;
            double delta;

            delta = (GetPrice(S_up, r, Sigma, T, sig, sim)[0, 0] - GetPrice(S_down, r, Sigma, T, sig, sim)[0, 0]) / (2 * diff);


            return delta;
        }

        /// <summary>
        /// This is an override method to calculate gamma.
        /// </summary>
        /// <param name="sig"> Normally distributed random variables. </param>
        /// <param name="sim"> Simulator class which has properties of steps and trails and some methods. </param>
        /// <returns> Get gamma </returns>
        public override double GetGamma(double[,] sig, Simulator sim)
        {
            double S = UnderlyingPrice.Price;
            double r = YieldPoint.Rate;
            double diff = 0.001 * S;
            double S_up = S + diff;
            double S_down = S - diff;
            double gamma;

            gamma = (GetPrice(S_up, r, Sigma, T, sig, sim)[0, 0] - 2 * GetPrice(S, r, Sigma, T, sig, sim)[0, 0] + GetPrice(S_down, r, Sigma, T, sig, sim)[0, 0]) / (diff * diff);

            return gamma;
        }

        /// <summary>
        /// This is an override method to calculate vega.
        /// </summary>
        /// <param name="sig"> Normally distributed random variables. </param>
        /// <param name="sim"> Simulator class which has properties of steps and trails and some methods. </param>
        /// <returns> Get vega </returns>
        public override double GetVega(double[,] sig, Simulator sim)
        {
            double S = UnderlyingPrice.Price;
            double r = YieldPoint.Rate;
            double diff = 0.001 * Sigma;
            double sigma_up = Sigma + diff;
            double sigma_down = Sigma - diff;
            double vega;

            vega = (GetPrice(S, r, sigma_up, T, sig, sim)[0, 0] - GetPrice(S, r, sigma_down, T, sig, sim)[0, 0]) / (2 * diff);

            return vega;
        }
        /// <summary>
        /// This is an override method to calculate theta.
        /// </summary>
        /// <param name="sig"> Normally distributed random variables. </param>
        /// <param name="sim"> Simulator class which has properties of steps and trails and some methods. </param>
        /// <returns> Get theta </returns>
        public override double GetTheta(double[,] sig, Simulator sim)
        {
            double S = UnderlyingPrice.Price;
            double r = YieldPoint.Rate;
            double diff = 0.001 * T;
            double T_down = T - diff;
            double theta;

            theta = (GetPrice(S, r, Sigma, T_down, sig, sim)[0, 0] - GetPrice(S, r, Sigma, T, sig, sim)[0, 0]) / diff;

            return theta;
        }
        /// <summary>
        /// This is an override method to calculate rho.
        /// </summary>
        /// <param name="sig"> Normally distributed random variables. </param>
        /// <param name="sim"> Simulator class which has properties of steps and trails and some methods. </param>
        /// <returns> Get rho </returns>
        public override double GetRho(double[,] sig, Simulator sim)
        {
            double S = UnderlyingPrice.Price;
            double diff = 0.001 * YieldPoint.Rate;
            double r_up = YieldPoint.Rate + diff;
            double r_down = YieldPoint.Rate - diff;
            double rho;

            rho = (GetPrice(S, r_up, Sigma, T, sig, sim)[0, 0] - GetPrice(S, r_down, Sigma, T, sig, sim)[0, 0]) / (2 * diff);

            return rho;
        }

    }
}
