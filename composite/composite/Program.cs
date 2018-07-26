using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Empolyee engin = new Empolyee { Name = "engin demiroğ" };

            Empolyee salih = new Empolyee { Name = "salih demiroğ" };

            engin.AddSubordinate(salih);

            Empolyee derin = new Empolyee { Name = "derin demiroğ" };

            engin.AddSubordinate(derin);

            Contractor ali = new Contractor { Name = "Ali" };
            derin.AddSubordinate(ali);

            Empolyee ahmet = new Empolyee { Name = "  ahmet" };

            salih.AddSubordinate(ahmet);

            Console.WriteLine(engin.Name);

            foreach (Empolyee manager in engin)
            {
                Console.WriteLine("  {0}",manager.Name);

                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("    {0}", employee.Name);
                }
            }


            Console.ReadLine();
            
        }
    }

    interface IPerson
    {
        string Name { get; set; }
    }
    class Contractor:IPerson
    {
        public string Name { get; set; }
    }

    class Empolyee : IPerson,IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();
        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinates in _subordinates)
            {
                yield return subordinates;

            }         
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }


}
