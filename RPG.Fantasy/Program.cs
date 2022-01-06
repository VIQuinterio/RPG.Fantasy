using DIO.RPG.Fantasy;
using System;

namespace RPG.Fantasy
{
    class Program
    {
        static void Main(string[] args)
        {
			Menu menu = new Menu();
			string opcaoUsuario = menu.ObterOpcaoUsuario();
			Init init = new Init();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						init.InserirPersonagem();
						break;
					case "2":
						init.ListarPersonagem();
						break;
					case "3":
						init.StatusPersonagem();		
						break;
					case "4":
						init.AtualizarPersonagem();
						break;
					case "5":
						init.ExcluirPersonagem();
						break;
					case "6":
						init.EntrarNaDungeon();
						break;
					case "C":
						Console.Clear();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
				opcaoUsuario = menu.ObterOpcaoUsuario();
			}
			Console.WriteLine("Obrigado por jogar o RPG Fantasy");
			Console.ReadLine();
		}
    }
}
