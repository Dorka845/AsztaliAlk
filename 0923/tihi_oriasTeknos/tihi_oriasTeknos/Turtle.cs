using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tihi_oriasTeknos
{
    public class Turtle
    {
        public int Happiness { get; set; }
        public int FedLevel { get; set; }

        public Turtle()
        {
            Happiness = 0;
            FedLevel = 0;
        }

        public void Eat(Food food)
        {
            int tapErtek = food.Value();
            FedLevel += tapErtek;

            if (FedLevel > 1000)
                FedLevel = 1000;

            if (FedLevel < 500)
                Happiness += tapErtek * 2;
            else
                Happiness -= tapErtek * 2;

            if (Happiness < 0)
                Happiness = 0;
            if (Happiness > 1000)
                Happiness = 1000;
        }
    }
}
