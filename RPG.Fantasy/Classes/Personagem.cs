using RPG.Fantasy.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Fantasy.Classes
{
    public class Personagem : Idetificador
	{
		public Classe Classe { get; set; }
		public string Nome { get; set; }
		public int Nivel { get; set; }
		public int PontosDeVida { get; set; }
		public int PontosDeMagia { get; set; }
		private bool Excluido { get; set; }
		public int ValorultimaAtaque { get; set; }

		public Personagem()
		{
			string retorno = "";
			retorno += this.Nome;
			retorno += this.Classe;
		}
		public Personagem(int id, Classe classe, string nome)
		{
			this.ID = id;
			this.Classe = classe;
			this.Nome = nome;
			this.Nivel = 1;
			this.PontosDeVida = 50;
			this.PontosDeMagia = 50;
			this.Excluido = false;
		}

		public override string ToString()
		{
			string retorno = "";
			retorno += "Nome: " + this.Nome + Environment.NewLine;
			retorno += "Classe: " + this.Classe + Environment.NewLine;
			retorno += "Nível: " + this.Nivel + Environment.NewLine;
			retorno += "Vida: " + this.PontosDeVida + Environment.NewLine;
			retorno += "Mana: " + this.PontosDeMagia + Environment.NewLine;
			retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

		public string retornaNome()
		{
			return this.Nome;
		}
		public string retornaClasse()
		{
			string retorno = "";
			retorno += this.Classe;
			return retorno;
		}

		public int retornaID()
		{
			return this.ID;
		}

		public bool retornaExcluido()
		{
			return this.Excluido;
		}
		public void Excluir()
		{
			this.Excluido = true;
		}
		public virtual string Atacar()
		{
			Random dado = new Random();
			int forcaDoAtaque = this.Nivel + dado.Next(1, 20);
			this.ValorultimaAtaque = forcaDoAtaque;
			return this.Nome + " Ataca e da " + forcaDoAtaque + " de dano";
		}

		public void ReceberDano(int danoRecebido)
		{
			this.PontosDeVida -= danoRecebido;
		}

	}
}
