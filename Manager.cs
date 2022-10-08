using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal class Manager : Worker
    {
        private Random _randomNumber = new Random();

        public Manager(string nameTemp) : base(nameTemp)
        {
            Position = "Менеджер";
        }

        public override void FillWorkDay()
        {
            int randomNumber1 = _randomNumber.Next(1, 10);

            for (int i = 0; i < randomNumber1; i++)
            {
                Call();
            }
            Relax();
            int randomNumber2 = _randomNumber.Next(1, 6);
            for (int i = 0; i < randomNumber1; i++)
            {
                Call();
            }
        }
    }
}
