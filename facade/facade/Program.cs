using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
            Console.ReadLine();
        }
    }

   
    class Logging:ILogging
    {
        public void log()
        {
            Console.WriteLine("Logged");
        }

        
    }

    interface ILogging
    {
        void log();
    }

    class Caching:ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

      interface ICaching
    {
        void Cache();
    }

    class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("USer Checked");
        }
    }

    interface IAuthorize
    {
        void CheckUser();
    }

    class CustomerManager
    {
        CrossCuttongConcersFacade _concerns;
        public CustomerManager( )
        {
            _concerns = new CrossCuttongConcersFacade();
        }
        public void Save()
        {

            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Logging.log();
            Console.WriteLine("Saved");
        }
    }
    class CrossCuttongConcersFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public Authorize Authorize;
        public CrossCuttongConcersFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }

    }


}
