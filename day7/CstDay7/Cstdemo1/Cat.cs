using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public class Cat:Animal
    {
        public Cat(string name,int age,string id) :base(name,age)
        {
            //this.Name = name;
            //this.Age = age;
            this.ID = id;

        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Speak()
        {
            Console.WriteLine("I am Miao Miao!!, I am {0}",this.ID);
            Sleeping();
            
        }
    }
}
