﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstStudent01
{
    public class Student
    {   
        // constructor

        public Student(string name,string gender,int age,int computer,int network,int python)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Computer = computer;
            this.Network = network;
            this.Python = python;
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _gender;

        public string Gender
        {
            get {
                
                if (_gender != "Male" && _gender != "Female")
                {
                    return _gender = "Male";
                }
                
                
                return _gender; 
            }
            set {_gender = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set {
                if (value < 0 || value > 120)
                {
                    value = 0;
                }
                _age = value; 
            }
        }

        private int _computer;

        public int Computer
        {
            get { return _computer; }
            set { _computer = value; }
        }

        private int _network;

        public int Network
        {
            get { return _network; }
            set { _network = value; }
        }

        private int _python;

        public int Python
        {
            get { return _python; }
            set { _python = value; }
        }

        public void SayHello() //Sayhello
        {
            Console.WriteLine("This is {0}\t, I am {1} years old\t,{2}",this.Name,this.Age,this.Gender);
        }

        public void ShowScore()
        {
            int score1 = this.Network + this.Computer + this.Python;
            int avg = (this.Network + this.Computer + this.Python) / 3;
            Console.WriteLine("my sum score is {0}\t,and average score is{1}",score1,avg);
        }
    }
}
