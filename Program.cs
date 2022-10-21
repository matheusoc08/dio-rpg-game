using dio_rpg_game.src.Entities;

Knight arus = new Knight("Arus");
WhiteWizard jenica = new WhiteWizard("Jenica");
BlackWizard topapa = new BlackWizard("Topapa");
Ninja wedge = new Ninja("Wedge");

Knight cavaleiroArmado = new Knight("Cavaleiro Real", "Espada Sagrada", 100, 10);
BlackWizard magoArcano = new BlackWizard("Mago Arcano", "Cajado Mistico", 40, 100);

Console.WriteLine(magoArcano);
Console.WriteLine();
Console.WriteLine(cavaleiroArmado);
Console.WriteLine();

Console.WriteLine(magoArcano.Attack());
Console.WriteLine(magoArcano.Magic(8));

Console.WriteLine(cavaleiroArmado.Attack());
Console.WriteLine(cavaleiroArmado.Magic());

