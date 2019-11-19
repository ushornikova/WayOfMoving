using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayOfMoving
{
    interface IWayOfMoving
    {
        void OnFood();
        void ByCar();
        void ByBycicle();
    }
    

    class Person : IWayOfMoving
    {
        public void OnFood() { Console.WriteLine("Hello, my name is Andrii and I am walking on food"); }
        public void ByCar() { Console.WriteLine("Hello, my name is Andrii and I am driving car"); }
        public void ByBycicle() { Console.WriteLine("Hello, my name is Andrii and I am driving a bike"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IWayOfMoving> personVar = new List<IWayOfMoving>();
            personVar.Add(new Person());
            foreach (IWayOfMoving p in personVar)
            {
                p.OnFood();
                p.ByCar();
                p.ByBycicle();
            }
            Console.ReadLine();
        }
    }
}
