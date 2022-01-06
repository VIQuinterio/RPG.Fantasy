using RPG.Fantasy.Classes;
using RPG.Fantasy.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.RPG.Fantasy
{
    public class Init
    {
		static PersonaRepositorio repositorio = new PersonaRepositorio();

		public void InserirPersonagem()
		{
			Console.WriteLine("Inserir novo personagem \n");

			foreach (int i in Enum.GetValues(typeof(Classe)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Classe), i));
			}
			Console.Write("\nDigite a classe entre as opções acima: ");
			int entradaClasse = int.Parse(Console.ReadLine());

			Console.Write("\nDigite o nome do personagem: ");
			string entradaNome = Console.ReadLine();

			Personagem novoPersonagem = new Personagem(id: repositorio.ProximoId(),
										classe: (Classe)entradaClasse,
										nome: entradaNome);

			repositorio.Insere(novoPersonagem);
			Console.Write("\n");
		}

		public void ListarPersonagem()
		{
			Console.WriteLine("\nListar personagem");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("\nNenhum personagem cadastrado.");
				return;
			}

			foreach (var persona in lista)
			{
				var excluido = persona.retornaExcluido();
				Console.WriteLine($"#{persona.retornaID()} - Nome: { persona.retornaNome()} - Classe: {persona.retornaClasse()} {(excluido ? "*Excluído*" : "")}");
			}
			Console.Write("\n");
		}

		public void StatusPersonagem()
		{
			Console.Write("\nDigite o id do personagem: ");
			int indicePersonagem = int.Parse(Console.ReadLine());
			var Personagem = repositorio.RetornaPorId(indicePersonagem);
			Console.Write("\n");
			Console.WriteLine(Personagem);
			Console.Write("\n");
		}

		public void AtualizarPersonagem()
		{
			Console.Write("\nDigite o id da personagem: ");
			int indicePersonagem = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Classe)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Classe), i));
			}
			Console.Write("\nDigite a classe entre as opções acima: ");
			int entradaClasse = int.Parse(Console.ReadLine());

			Console.Write("\nDigite o nome do personagem: ");
			string entradaNome = Console.ReadLine();

			Personagem atualizaPersonagem = new Personagem(id: indicePersonagem,
										classe: (Classe)entradaClasse,
										nome: entradaNome);

			repositorio.Atualiza(indicePersonagem, atualizaPersonagem);
			Console.Write("\n");
		}

		public void ExcluirPersonagem()
		{
			Console.Write("\nDigite o id do personagem: ");
			int indicePersonagem = int.Parse(Console.ReadLine());

			repositorio.Exclui(indicePersonagem);
			Console.Write("\n");
		}

		public void EntrarNaDungeon()
		{
			Console.Write("\nInforme qual dos IDs do personagem que você criou? ");
			int indicePersonagem = int.Parse(Console.ReadLine());
			Console.WriteLine("\n");

			var PersonagemRepo = repositorio.RetornaPorId(indicePersonagem);

			Personagem heroi = new Personagem();
			heroi = PersonagemRepo;
			Dungeon dungeon = new Dungeon();
			dungeon.Stage1(heroi);
		}
	}
}
