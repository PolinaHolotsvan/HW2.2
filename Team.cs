using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    internal class Team
    {
        private string _teamName { get; set; }
        private List<Worker> _workers = new List<Worker>();
        public Team(string teamName)
        {
            _teamName=teamName;
        }
        public void AddNewWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Iнформацiя про команду: {Environment.NewLine}{_teamName}");
            foreach (Worker worker in _workers)
            {
                Console.WriteLine(worker.Name);  
            }
            Console.WriteLine();
        }

        public void GetDetailedInfo()
        {
            Console.WriteLine($"Детальна iнформацiя про команду: {Environment.NewLine}{_teamName}");
            foreach (Worker worker in _workers)
            {
                Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay}");
            }
            Console.WriteLine();
        }
    }
}
