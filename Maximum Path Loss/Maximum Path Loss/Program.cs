//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Path_Loss
{

    class Program
    {
            private static void Calc()
            {
                ConsoleKeyInfo conkey;
                do
                {
                    try
                    {
                        Calc1();
                        calc2();
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                    }
                    finally
                    {
                        Console.WriteLine("Enter Any Key That You Want, For Run Program Again.");
                    }
                    conkey = Console.ReadKey();
                } while (conkey.Key != ConsoleKey.Escape);
            }
            private static void Calc1()
            {
                Console.WriteLine("Please Enter The Transmit Power : ");
                double TP = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Receiver Sensitivity : ");
                double RS = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Receive Antenna Gain : ");
                double RA = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Transmit Antenna Gain");
                double TAG = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Fade Margin : ");
                double FM = Double.Parse(Console.ReadLine());
                double G = RA + TAG;
                double MPL = TP - RS + G - FM;
                Console.WriteLine("Maximum Path Loss Equal by {0}", MPL);
            }
            private static void calc2()
            {
                Console.WriteLine("Please Enter The Maximum Path Loss : ");
                double MPL = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter the  Frequency(MHz) : ");
                double F = Double.Parse(Console.ReadLine());
                double X = (MPL - 32.44 - Math.Log(F)) / 20;
                double Y = Math.Pow(10, X);
                //double Y = Math.Pow(10, X) / 1000;
                //float a = Convert.ToSingle(Y);
                Console.WriteLine("Distance Equal By {0}", Y);
            }
            static void Main(string[] args)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("########################################################################################");
                Console.WriteLine("########################################################################################");
                Console.WriteLine("########################################################################################");
                Console.WriteLine("Maximum path loss = transmit power – receiver sensitivity + gains – losses – fade margin");
                Console.WriteLine("           Distance (km) = 10^(maximum path loss – 32.44 – 20log(f))/20                 ");
                Console.WriteLine("########################################################################################");
                Console.WriteLine("########################################################################################");
                Console.WriteLine("########################################################################################");
                Program.Calc();
            }
    }
}

