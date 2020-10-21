using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Methods4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare
            //ask users salary
            Console.Write("Ange din bruttolön ");
            double brutto = double.Parse(Console.ReadLine());
            CalcSalaryTax(brutto);

            /*nettoSalary = CalcSalaryTax();*/
            //stop
            Console.ReadKey();
        }
        static void CalcSalaryTax(double brutto)
        {

            double tax = brutto * 0.32;
            double netto = brutto - tax;
            Console.Write("du betalar {0}kr i skatt och din nettolön är {1}kr", tax, netto);
        }
    }
}
