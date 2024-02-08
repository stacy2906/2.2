using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Press
    {
        private int copies;

        private string name;

        private int price;

        public int Copies

        {

            get { return copies; }

            set { copies = value; }

        }

        public string Name

        {

            get { return name; }

            set { name = value; }

        }

        public int Price

        {

            get { return price; }

            set { price = value; }

        }



        public Press() { }

        public Press(int copies)

        {

            this.copies = copies;

        }



        public Press(int copies, string name) : this(copies)

        {

            this.name = name;

        }

        public Press(int copies, string name, int price) : this(copies)

        {

            this.name = name;

            this.price = price;

        }



        public virtual double Cost()

        {

            return copies * price;

        }

        public virtual void Output()

        {
            Console.WriteLine($"Copies: {copies}, Name: {name}, Price: {price}");


        }
    }
}
