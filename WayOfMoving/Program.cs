using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayOfMoving
{
    interface IPerson
    {
        void OnFood();
    }
    
    interface IDriver
    {
        void ByCar();
    }

    interface IBiker
    {
        void ByBycicle();
    }

    class Person : IPerson
    {
        public void OnFood() { Console.WriteLine("Hello, my name is Andrii and I am walking on food"); }
    }

    class Driver: IDriver
    {
        public void ByCar() { Console.WriteLine("Hello, my name is Andrii and I am driving car"); }
    }

    class Biker: IBiker
    {
        public void ByBycicle() { Console.WriteLine("Hello, my name is Andrii and I am driving a bike"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            ((Person)p).OnFood();

            Driver d = new Driver();
            ((Driver)d).ByCar();

            Biker b = new Biker();
            ((Biker)b).ByBycicle();

            //List<IWayOfMoving> personVar = new List<IWayOfMoving>();
            //personVar.Add(new Person());
            //foreach (IWayOfMoving p in personVar)
            //{
            //    p.OnFood();
            //    p.ByCar();
            //    p.ByBycicle();
            //}
            Console.ReadLine();
        }
    }
}
