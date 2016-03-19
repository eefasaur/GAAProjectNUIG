using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAAFullStackProject
{
    //just a simple player class
    class Player
    {
        private string name;
        private int height;
        private int age;


        public Player()
        {
            this.name = "Unassigned";
            this.height = 0;
            this.age = 0;
        }

        public Player(string name, int height, int age)
        {
            this.name = name;
            this.height = height;
            this.age = age;
        }

        public string Name { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
    }

}
