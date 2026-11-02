using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Nam",175,65,true);
            Console.WriteLine("Ten=" + person1.name);
            Console.ReadLine();
            Person[] people = new Person[5];
            people[0] = new Person("Nam", 176, 85, true);
            people[1] = new Person("Tan",154,60,true);
            people[2] = new Person("Hien", 181, 75, true);
            people[3] = new Person("Tuan",164,56,false);
            people[4] = new Person("Hai", 145, 67, true);
            Console.WriteLine("Ho Ten\tChieucao\tCannang\tGioitinh");
            for (int i = 0; i < 4; i++)
                Console.WriteLine(people[i].name+"\t"+ people[i].height + people[i].weight + "\t" + people[i].isMale);
            Console.ReadLine();
            Character Tom = new Character("Tom", 200);
            Tom.Health = 200;
            Console.WriteLine("Mau cua Tom=" + Tom.Health);
            Console.ReadLine();
        }
       
    }
}