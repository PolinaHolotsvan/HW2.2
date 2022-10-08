using HW2._2;

Developer dev1 = new Developer("Олег");
Developer dev2 = new Developer("Павло");
Developer dev3 = new Developer("Ян");
Manager manager1 = new Manager("Дмитро");
Manager manager2 = new Manager("Михайло");
Team team = new Team("CringeTeam");

dev1.FillWorkDay();
dev2.FillWorkDay();
dev3.FillWorkDay();
manager1.FillWorkDay();

manager2.FillWorkDay();
team.AddNewWorker(dev1);
team.AddNewWorker(dev2);
team.AddNewWorker(dev3);
team.AddNewWorker(manager1);
team.AddNewWorker(manager2);
team.GetInfo();
team.GetDetailedInfo();