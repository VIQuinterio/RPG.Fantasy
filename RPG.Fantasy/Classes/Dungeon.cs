using RPG.Fantasy.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPG.Fantasy.Classes
{
	public class Dungeon
	{
		public void Stage1(Personagem heroi)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Inimigo esqueleto = new Inimigo(0, Classe.Arqueiro, "Esqueleto");
		atacaNovamente:
			Console.WriteLine(heroi.Atacar());
			Console.WriteLine(esqueleto.Atacar());

			if (heroi.ValorultimaAtaque == esqueleto.ValorultimaAtaque)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Empate, ambos deram dano de " + heroi.ValorultimaAtaque);
				Console.Write("\n");
				Console.ResetColor();
				goto atacaNovamente;
			}
			else if (heroi.ValorultimaAtaque > esqueleto.ValorultimaAtaque)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				esqueleto.ReceberDano(heroi.ValorultimaAtaque - esqueleto.ValorultimaAtaque);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\n" + heroi.Nome + " Venceu o " + heroi.retornaClasse());
				Console.Write("\n");
				Console.ResetColor();
				Stage2(heroi);
			}
			else
			{
				heroi.ReceberDano(esqueleto.ValorultimaAtaque - heroi.ValorultimaAtaque);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\n" + esqueleto.Nome + " Venceu o " + esqueleto.retornaClasse());

				Console.Write("\n");
				Console.ResetColor();
			}
		}

		public void Stage2(Personagem heroi)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Inimigo ogro = new Inimigo(0, Classe.Guerreiro, "Ogro");
		atacaNovamente:
			Console.WriteLine(heroi.Atacar());
			Console.WriteLine(ogro.Atacar());

			if (heroi.ValorultimaAtaque == ogro.ValorultimaAtaque)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Empate, ambos deram dano de " + heroi.ValorultimaAtaque);
				Console.Write("\n");
				Console.ResetColor();
				goto atacaNovamente;
			}
			else if (heroi.ValorultimaAtaque > ogro.ValorultimaAtaque)
			{
				ogro.ReceberDano(heroi.ValorultimaAtaque - ogro.ValorultimaAtaque);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\n" + heroi.Nome + " Venceu o " + heroi.retornaClasse());
				Console.Write("\n");
				Stage3(heroi);
				Console.ResetColor();
			}
			else
			{
				heroi.ReceberDano(ogro.ValorultimaAtaque - heroi.ValorultimaAtaque);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\n" + ogro.Nome + " Venceu o " + ogro.retornaClasse());
				Console.Write("\n");
				Console.ResetColor();
			}
		}
		public void Stage3(Personagem heroi)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"Ao chegar no fim da dungeon {heroi.Nome} se depara com o CHEFÃO!!");
			Console.WriteLine("....");
			Inimigo mago = new Inimigo(0, Classe.Mago, "Mago Impacavel");
		atacaNovamente:
			Console.WriteLine(heroi.Atacar());
			Console.WriteLine(mago.Atacar());

			if (heroi.ValorultimaAtaque == mago.ValorultimaAtaque)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("Empate, ambos deram dano de " + heroi.ValorultimaAtaque);
				Console.Write("\n");
				Console.ResetColor();
				goto atacaNovamente;
			}
			else if (heroi.ValorultimaAtaque > mago.ValorultimaAtaque)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				mago.ReceberDano(heroi.ValorultimaAtaque - mago.ValorultimaAtaque);
				Console.WriteLine("\n" + heroi.Nome + " Venceu o " + heroi.retornaClasse());
				Console.Write("\n");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine($"O {mago.Nome} fica surpreso por ter perdido e diz que na proximo {heroi.Nome} não irá ganhar!!");

				Console.Write("\n");
				Console.ResetColor();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				heroi.ReceberDano(mago.ValorultimaAtaque - heroi.ValorultimaAtaque);
				Console.WriteLine("\n" + mago.Nome + " Venceu ");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine($"HA HA HA achou que iria me vencer {heroi.Nome} !!");
				Console.Write("\n");
				Console.ResetColor();
			}
		}
	}
}
