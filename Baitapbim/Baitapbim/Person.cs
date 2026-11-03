using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbim
{
    public class Person
    {
        public string name;
        public int height;
        public int weight;
        public bool isMale;
        public Person(string _name, int _height, int _weight, bool _isMale)
        {
            this.name = _name;
            this.height = _height;
            this.weight = _weight;
            this.isMale = _isMale;
        }
        
    }
}
