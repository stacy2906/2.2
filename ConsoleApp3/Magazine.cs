using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Magazine:Press
    {
        private string quality;

        public string Quality

        {

            get { return quality; }

            set { quality = value; }

        }

        public Magazine(int copies, string name, string quality, int price) : base(copies, name,price)

        {

            this.quality = quality;

        }

        public override double Cost()

        {
            double cost = base.Cost();
            switch (quality)
            {
                case "high":
                    cost *= 1.1;
                    break;
                case "medium":
                    break;
                case "low":
                    cost *= 0.9;
                    break;
                default:
                    break;
            }
            return cost;



        }

        public override void Output()

        {
            base.Output();
            Console.WriteLine($"Paper Quality: {quality}");
        }
    }
}
