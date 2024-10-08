using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal  class PhuongTrinhBac2
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //private double a;
        //private double b;
        //private double c;

        //public double A
        //{
        //    get { return this.a; }
        //    set { this.a = value; }
        //}
        //public double B
        //{
        //    get { return this.b; }
        //    set { this.b = value; }
        //}
        //public double C
        //{
        //    get { return this.c; }
        //    set { this.c = value; }
        //}
        //public PhuongTrinhBac2(double a, double b,double c)
        //{
        //    this.A = a;
        //    this.B = b;
        //    this.C = c;
        //}
        //public void Solve()
        //{
        //    double delta = b * b - 4 * a * c;

        //    if (delta > 0)
        //    {
        //        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        //        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        //        Console.WriteLine("Phương trình có 2 nghiệm phân biệt: x1 = {0}, x2 = {1}", x1, x2);
        //    }
        //    else if (delta == 0)
        //    {
        //        double x = -b / (2 * a);
        //        Console.WriteLine("Phương trình có 1 nghiệm kép: x = {0}", x);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Phương trình vô nghiệm");
        //    }
        //}
        
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
