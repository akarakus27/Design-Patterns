using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerObserver = new CusromerObserver();
            ProductManager productManager = new ProductManager();
            productManager.Attach( customerObserver );
            productManager.Attach(new Employeeobserver());
            productManager.Detach(customerObserver);
            productManager.UpdatePrice();
            Console.ReadLine();

        }
    }

    class ProductManager
    {
        List<Observer> _observers = new List<Observer> ();   
        public void UpdatePrice()
        {
            Console.WriteLine("Product price changed");
            Notify();
        }
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
    abstract class Observer
    {
        public abstract void Update(); 
    }
    class CusromerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine(" Message to customer : Product price changed !");
        }
    }
    class Employeeobserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine(" Message to Employee  : Product price changed !");
        }
    }

}
