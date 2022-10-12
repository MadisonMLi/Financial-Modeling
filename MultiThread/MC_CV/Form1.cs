using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace MC_CV
{
    public partial class Monte : Form
    {

        Stopwatch watch = new Stopwatch();

        public Monte()
        {
            InitializeComponent();
            cpuCount.Text = Environment.ProcessorCount.ToString();
        }

        // Initial a string array to asign result
        string[] outcome = new string[7];
        // Initial three delegate functions.
        private delegate void ProgressThing(int num);
        private delegate void GetValue(Options option, double S, double r, double sigma, double T, double[,] sig, Simulator sim);
        private delegate void GetTime(Stopwatch stop);

        /// <summary>
        /// Progressbar invoke
        /// </summary>
        /// <param name="speed"></param>
        private void ProgressIncre(int speed)
        {
            bool invokeRequired = progressBar.InvokeRequired;
            if (InvokeRequired == true)
            {
                ProgressThing pro = new ProgressThing(ProgressAdd);
                progressBar.BeginInvoke(pro, new object[]
                {
                    speed
                });
            }
            else
            {
                ProgressAdd(speed);
            }
        }

        /// <summary>
        /// Timer invoke
        /// </summary>
        /// <param name="stop"></param>
        private void Timing(Stopwatch stop)
        {
            bool InvokeRequired = progressBar.InvokeRequired;
            if (InvokeRequired == true)
            {
                GetTime gettime = new GetTime(WatchTime);
                Price_text.BeginInvoke(gettime, new object[]
                {
                    stop
                });
            }
            else
            {
                WatchTime(stop);
            }
        }

               

        private void lbSE_Click(object sender, EventArgs e)
        {

        }

        private void btmGo_Click(object sender, EventArgs e)
        {
            // Initialize progressBar
            progressBar.Value = 0;
            progressBar.Maximum = 100;

            // Create a new thread.
            Thread t1 = new Thread(new ThreadStart(CalOutcome));
            t1.Start();
        }


        /// <summary>
        /// Calculate all the outputs and assign the value to text
        /// </summary>
        /// <param name="option"></param>
        /// <param name="S"></param>
        /// <param name="r"></param>
        /// <param name="sigma"></param>
        /// <param name="T"></param>
        /// <param name="sig"></param>
        /// <param name="sim"></param>
        private void CalValue(Options option, double S, double r, double sigma, double T, double[,] sig, Simulator sim)
        {

            // Calculate option price and standard error.
            // Add value to progressBar to make progressBar progress.           
            double[,] CalResult = option.GetPrice(S, r, sigma, T, sig, sim);
            outcome[0] = CalResult[0, 0].ToString();
            outcome[1] = CalResult[0, 1].ToString();
            ProgressIncre(20);
            // Calculate delta
            outcome[2] = option.GetDelta(sig, sim).ToString();
            ProgressIncre(16);
            // Calculate gamma
            outcome[3] = option.GetGamma(sig, sim).ToString();
            ProgressIncre(16);
            // Calculate vega
            outcome[4] = option.GetVega(sig, sim).ToString();
            ProgressIncre(16);
            // Calculate rho
            outcome[5] = option.GetRho(sig, sim).ToString();
            ProgressIncre(10);
            // Calculate theta
            outcome[6] = option.GetTheta(sig, sim).ToString();
            ProgressIncre(10);
        }
        /// <summary>
        /// Initial parameter value and do calculation
        /// </summary>
        private void CalOutcome()
        {
            // Start watch
            watch.Reset();
            watch.Start();

            //Add progressbar value
            ProgressIncre(12);

            // Instantiate non-static class
            UnderlyingPrice udl = new UnderlyingPrice()
            {
                Price = Convert.ToDouble(S_text.Text)
            };

            YieldPoint yp = new YieldPoint()
            {
                Rate = Convert.ToDouble(r_text.Text)
            };

            European eur = new European()
            {
                UnderlyingPrice = udl,
                YieldPoint = yp,
                Strike = Convert.ToDouble(K_text.Text),
                T = Convert.ToDouble(T_text.Text),
                Sigma = Convert.ToDouble(Sigma_text.Text),
                Iscall = btmCall.Checked
            };

            Simulator sim = new Simulator()
            {
                M = Convert.ToInt32(M_text.Text),
                N = Convert.ToInt32(N_text.Text),
                CV = CV.Checked,
                Anti = Anthetic.Checked,
                Multi = multi.Checked
            };

            // Generate normally distributed random variables.
            double[,] sig = sim.Norm_polar();

            CalValue(eur, eur.UnderlyingPrice.Price, eur.YieldPoint.Rate, eur.Sigma, eur.T, sig, sim);

            // Do the calculation of European Option.
            bool InvokeRequired = Price_text.InvokeRequired;
            if (InvokeRequired == true)
            {
                GetValue getvalue = new GetValue(UpdateGUI);
                Price_text.BeginInvoke(getvalue, new object[]
                {
                    eur,
                    eur.UnderlyingPrice.Price,
                    eur.YieldPoint.Rate,
                    eur.Sigma,
                    eur.T,
                    sig,
                    sim
                });
            }
            else
            {
                UpdateGUI(eur, eur.UnderlyingPrice.Price, eur.YieldPoint.Rate, eur.Sigma, eur.T, sig, sim);
            }

        }
        /// <summary>
        /// Assign the outcome to the text
        /// </summary>
        /// <param name="option"></param>
        /// <param name="S"></param>
        /// <param name="r"></param>
        /// <param name="sigma"></param>
        /// <param name="T"></param>
        /// <param name="sig"></param>
        /// <param name="sim"></param>
        private void UpdateGUI(Options option, double S, double r, double sigma, double T, double[,] sig, Simulator sim)
        {
            // Assign the outcome to the text
            Price_text.Text = outcome[0];
            SE_text.Text = outcome[1];
            Delta_text.Text = outcome[2];
            Gamma_text.Text = outcome[3];
            Vega_text.Text = outcome[4];
            Rho_text.Text = outcome[5];
            Theta_text.Text = outcome[6];

            // stop timing
            watch.Stop();

            // Record running time.
            Timing(watch);
        }

        /// <summary>
        /// Add value to progressbar
        /// </summary>
        /// <param name="AddValue"></param>
        private void ProgressAdd(int AddValue)
        {
            progressBar.Value += AddValue;
            progressBar.Update();
        }

        /// <summary>
        /// Record time value
        /// </summary>
        /// <param name="stop"></param>
        private void WatchTime(Stopwatch stop)
        {
            Timer_text.Text = stop.Elapsed.Hours.ToString() + "h" + " : " +
                stop.Elapsed.Minutes.ToString() + "m" + " : " +
                stop.Elapsed.Seconds.ToString() + "s" + " : " +
                stop.Elapsed.Milliseconds.ToString() + "ms";
        }

        private void Monte_Load(object sender, EventArgs e)
        {

        }

        // All the following code is to tell users they enter wrong values when they fill blanks.
        private void S_text_TextChanged(object sender, EventArgs e)
        {
            double g;
            // Find if entered value is right
            if (!double.TryParse(S_text.Text, out g))
            {
                // If not, make the blank to be pink
                S_text.BackColor = Color.Pink;
                // and have a error point
                Serror.SetError(S_text, "Please enter a number!");
            }
            else
            {
                S_text.BackColor = Color.White;
                Serror.SetError(S_text, string.Empty);
            }
        }

        private void K_text_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(K_text.Text, out double g))
            {
                K_text.BackColor = Color.Pink;
                Kerror.SetError(K_text, "Please enter a number!");
            }
            else
            {
                K_text.BackColor = Color.White;
                Kerror.SetError(K_text, string.Empty);
            }
        }

        private void r_text_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(r_text.Text, out double g))
            {
                r_text.BackColor = Color.Pink;
                Rerror.SetError(r_text, "Please enter a number!");
            }
            else
            {
                r_text.BackColor = Color.White;
                Rerror.SetError(r_text, string.Empty);
            }
        }

        private void Sigma_text_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(Sigma_text.Text, out double g))
            {
                Sigma_text.BackColor = Color.Pink;
                Verror.SetError(Sigma_text, "Please enter a number!");
            }
            else
            {
                Sigma_text.BackColor = Color.White;
                Verror.SetError(Sigma_text, string.Empty);
            }
        }

        private void T_text_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(T_text.Text, out double g))
            {
                T_text.BackColor = Color.Pink;
                Terror.SetError(T_text, "Please enter a number!");
            }
            else
            {
                T_text.BackColor = Color.White;
                Terror.SetError(T_text, string.Empty);
            }
        }

        private void N_text_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(N_text.Text, out int g))
            {
                N_text.BackColor = Color.Pink;
                Nerror.SetError(N_text, "Please enter an int!");
            }
            else
            {
                N_text.BackColor = Color.White;
                Nerror.SetError(N_text, string.Empty);
            }
        }

        private void M_text_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(M_text.Text, out int g))
            {
                M_text.BackColor = Color.Pink;
                Merror.SetError(M_text, "Please enter an int!");
            }
            else
            {
                M_text.BackColor = Color.White;
                Merror.SetError(M_text, string.Empty);
            }
        }

        private void Inputs_Enter(object sender, EventArgs e)
        {

        }
    }
}
