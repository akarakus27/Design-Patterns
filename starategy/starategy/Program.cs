using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            customermanager.CrediCalculatorBase = new After2010CreditCalculator();
            customermanager.SaveCredit();
            

            customermanager.CrediCalculatorBase = new Before2010CreditCalculator ();
            customermanager.SaveCredit();
            Console.ReadLine();
        }
    }
    abstract class CrediCalculatorBase
    {
        public abstract void Calculate();
    }
    class Before2010CreditCalculator : CrediCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using before2010");
        }
    }
    class After2010CreditCalculator : CrediCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using after2010");
        }
    }
    class CustomerManager
    {
        public CrediCalculatorBase CrediCalculatorBase { get; set; }

        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business");
            CrediCalculatorBase.Calculate();
        }
    }
}
