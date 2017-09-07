using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ObjectOrientedProgramming
{
    class Cat
    {
        // defining the fields that belongs to the class. this Class will have all these.
        private string name;
        private string furColor;
        private int furLength;
        private bool isMale;
        private int age;
        private bool isHungry;
        private bool toSleep;
        private bool toPer;

        // this is the progerty anyone to access.
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string  FurColor { get; set; }
        public int FurLength { get; set; }
        // every class as one (default constructor)
        public Cat()
        {

        }


        public Cat(string name)
        {
            this.name = name;
        }
        
        public Cat (int age)
        {

        }
        public int Age
        {
            get { return this.age; }
        }
        // method overloading 
        public Cat(string name, string furColor, int furLength, bool isMale, int age, bool isHungry, bool toSleep, bool toPer)
        {
            //we are passing it in asigning the instance. setting it to the feild variables.
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.isMale = isMale;
            this.age = age;
            this.isHungry = isHungry;
            this.toSleep = toSleep;
            this.toPer = toPer;
            
        }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
                Console.WriteLine("Imstuffed");
            }
            else if(!isHungry)
            {
                Console.WriteLine("Im good no food for me");
            }   

        }

        public void Run()
        {
            Console.WriteLine("I am running really fast!!");
            this.isHungry = true;
        }

        public void Sleep()
        {
            Console.WriteLine("Im sleeping....Zzzz");
        }

        public void Per()
        {
            Console.WriteLine("My name is {0} and yes i can talk", this.name);
            
        }
        
    }
}
