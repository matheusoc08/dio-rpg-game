using dio_rpg_game.src.Entities;

Knight arus = new Knight("Arus", 1, "Knight");
Wizard jenica = new Wizard("Jenica", 1, "Wizard");


Console.WriteLine(arus);
Console.WriteLine(jenica);

Console.WriteLine(arus.Attack());
Console.WriteLine(jenica.Attack(61));

