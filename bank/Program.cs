using bank.Models;
Console.WriteLine();
Manager manager = new("asd","asdfsd",11,"asfdsa",234);
Manager manager1 = new("asd","asdfsd",22,"asfdsa",555);

Worker worker1 = new("asd", "asdfsd","asd", 11, 234, "asd","asd");
Worker worker2 = new("asd", "asdfsd", "asd", 12, 456, "asd", "asd");

Worker worker3 = new("asd", "asdfsd", "asd", 13, 789, "asd", "asd");

Worker wok= new("asd", "asdfsd", "asd", 14, 101112, "asd", "asd");
Operation op = new("op", "Today");
Operation op2 = new("op2", "Yesterday");

Console.WriteLine(wok[1].ToString());