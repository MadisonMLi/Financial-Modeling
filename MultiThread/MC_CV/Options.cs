using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_CV
{
    class Underlying
    {
        public string CompanyName { get; set; }
        public string Ticker { get; set; }
        public string Exchange { get; set; }
    }
    /// <summary>
    /// UnderlyingPrice class has properties of underlying price.
    /// </summary>
    class UnderlyingPrice
    {
        public Underlying Underlying { get; set; }
        public DateTime TradingDate { get; set; }
        public double Price { get; set; }
    }
    /// <summary>
    /// YieldPoint class has properties of YieldPoint.
    /// </summary>
    class YieldPoint
    {
        public double Tenor { get; set; }
        public double Rate { get; set; }
    }
    /// <summary>
    /// Options class has properties of Options. It is an abstract class for inheriting.
    /// </summary>
    abstract class Options
    {
        public UnderlyingPrice UnderlyingPrice { get; set; }
        public YieldPoint YieldPoint { get; set; }
        public double Sigma { get; set; }
        public double T { get; set; }


        // Define several virtual method for inheritance classes' override method. 
        public virtual double[,] GetPrice(double S, double r, double sigma, double T, double[,] sig, Simulator sim)
        {
            double[,] result = new double[1, 2];
            return result;
        }

        public virtual double GetDelta(double[,] sig, Simulator sim)
        {
            return 0;
        }

        public virtual double GetGamma(double[,] sig, Simulator sim)
        {
            return 0;
        }

        public virtual double GetVega(double[,] sig, Simulator sim)
        {
            return 0;
        }

        public virtual double GetTheta(double[,] sig, Simulator sim)
        {
            return 0;
        }

        public virtual double GetRho(double[,] sig, Simulator sim)
        {
            return 0;
        }

    }

}
