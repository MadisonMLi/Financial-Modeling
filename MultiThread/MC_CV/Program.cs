using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MC_CV
{
    static class Program
    {
        static Monte monte = new Monte();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(RunGUI));
                thread.Start();
                thread.Join();
            }
            catch (FormatException)
            {
                MessageBox.Show("You entered wrong data. Or you haven't filled in all blanks!" + "\n" +
                    "Please fix it and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.ReadLine();
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Sorry, the calculation has run out of your computer's memory.", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.ReadLine();
            }
        }

        static void RunGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(monte);
        }

    }
}
