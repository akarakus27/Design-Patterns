using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
         
        static void Main(string[] args)
        {
            var personalCar = new PersonalCar { Make="bmw",Model="3.20",HİrePrice=2500};
            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            specialOffer.DiscountPercentage = 10;

            Console.WriteLine("cocrete : {0}", personalCar.HİrePrice);
            Console.WriteLine("Special Offer : {0}", specialOffer.HİrePrice);
            Console.ReadLine();
        }
    }
    abstract class CarBase
    {
        public  abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HİrePrice { get; set; }
    }

    class PersonalCar : CarBase
    {
        public override decimal HİrePrice { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }

        internal class personalCar
        {
            public personalCar()
            {
            }
        }
    }

    class CommercialCar : CarBase
    {
        public override decimal HİrePrice { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
    }
    abstract class CarDecoratorBase : CarBase
    {
        private CarBase _carBase;
        protected CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }
    class SpecialOffer : CarDecoratorBase
    {
        public int DiscountPercentage { get; set; }
        private readonly CarBase _carBase;
        public SpecialOffer(CarBase carBAse) : base(carBAse)
        {
            _carBase = carBAse ;
        }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HİrePrice
        {
            get
            {
                return _carBase.HİrePrice- _carBase.HİrePrice * DiscountPercentage/100;
            }
            set
            {
            }

        }
    }

}
