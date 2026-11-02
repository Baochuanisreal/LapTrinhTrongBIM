using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbim
{
    internal class Character
    {
        private int _health;
        public string Name { get; set; }
        public int Maxhealth { get; set; } = 100;
        public int Health
        {
            get => _health;
            set
            {
                if(value<0) _health = 0;
                else if (value > Maxhealth)
                {
                    _health = Maxhealth;
                    Console.WriteLine("Gia tri cua value:"+value);
                }
                else _health = value;  
            }
        }
        public Character(string name, int health)
        {
            Name = name;
            _health = health;
        }
    }
}
