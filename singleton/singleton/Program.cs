using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();
        }
    }
    class CustomerManager
    {
       private  static CustomerManager _customManager;
        static object _lockobject = new object();
        private CustomerManager()
        {
        
        }
        //customer managerin kendisinin döndürür
        //daha verilen birşey varsa tekrar onu veririz yoksa yeni şeyi göndiririz
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockobject)
            {
                if (_customManager == null)
                {
                    _customManager = new CustomerManager();
                }
            }

            return _customManager;
              
        }
        public  void Save()
        {
            Console.WriteLine(" Saved..");
        }
    }

}
