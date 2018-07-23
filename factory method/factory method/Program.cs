using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.save();
            Console.ReadLine();
        }
    }
    public class LoggerFactory: IlloggerFactory
    {
        public Ilogger CreateLogger()
        {
            //business to decide factory 
            return new Edlogger();
        }
    }
    public class LoggerFactory2 : IlloggerFactory
    {
        public Ilogger CreateLogger()
        {
            //business to decide factory 
            return new log4Netlogger();
        }
    }
    public interface IlloggerFactory
    {
        Ilogger CreateLogger();
    }
    public interface Ilogger
    {
        void log();
    }
    public class Edlogger:Ilogger
    {
        public void log()
        {
            Console.WriteLine("logged with Edlogger");
        }
    }
    public class log4Netlogger : Ilogger
    {
        public void log()
        {
            Console.WriteLine("logged with log4Netlogger");
        }
    }
    public class CustomerManager
    {
        private IlloggerFactory _loggerFactory;
        public void save()
        {
            Console.WriteLine("saved !");
            Ilogger logger = _loggerFactory.CreateLogger();
            logger.log();
        }
    }
}
