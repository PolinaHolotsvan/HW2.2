using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal abstract class Worker
    {
        public string Name;
        public string Position;
        public string WorkDay = "";

        public Worker(string nameTemp)
        {
            Name = nameTemp;
        }

        public void Call()
        {
            if (WorkDay == "")
            {
                WorkDay += "Телефоную";
            }
            else WorkDay += " Телефоную";
        }

        public void WriteCode()
        {
            if (WorkDay == "")
            {
                WorkDay += "Пишу код";
            }
            else WorkDay += " Пишу код";
        }

        public void Relax()
        {
            WorkDay += " Вiдпочиваю";
        }

        public abstract void FillWorkDay();

    }
    
}
