using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory2());
            productManager.getall();
            Console.ReadLine();



                }
    }
    public abstract class logging
    {
        public abstract void log(string message);
    }
    public class log4netlogger : logging
    {
        public override void log(string message)
        {
            Console.WriteLine("logged witht lognet");
        }
    }
    public class nlogger : logging
    {
        public override void log(string message)
        {
            Console.WriteLine("logged witht nlogger");
        }
    }
    public abstract class caching
    {
        public abstract void cache(string data);
    } 
    public class memcache : caching
    {
        public override void cache(string data)
        {
            Console.WriteLine("cached witht memcache");
        }
    }
    public class rediscache : caching
    {
        public override void cache(string data)
        {
            Console.WriteLine("cached witht redis");
        }
    } 
    public abstract class cCcfactory
    {
        public abstract logging createlogger();
        public abstract caching createcaching();
    }
    public class Factory1 : cCcfactory
    {
        public override caching createcaching()
        {
            return new rediscache();
        }

        public override logging createlogger()
        {
            return new log4netlogger();
        }
    }
    public class Factory2 : cCcfactory
    {
        public override caching createcaching()
        {
            return new rediscache();
        }

        public override logging createlogger()
        {
            return new nlogger();
        }
    }
    public class ProductManager
    {
        private cCcfactory _cccfactory;
        private logging _logging;
        private caching _caching;
        public ProductManager(cCcfactory cccfactory)
        {
            _cccfactory = cccfactory;
            _logging = _cccfactory.createlogger();
            _caching = _cccfactory.createcaching();
        }
        public void getall()
        {
            _logging.log("logged");
            _caching.cache("data");
            Console.WriteLine("Products listed! ");
        }
    }
    

}
