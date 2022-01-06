using RPG.Fantasy.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Fantasy.Classes
{
    public class Inimigo : Personagem
    {
        public Inimigo(int id, Classe classe, string nome) : base(id, classe, nome)
        {
            this.ID = id;
            this.Classe = classe;
            this.Nome = nome;
            this.Nivel = 1;
            this.PontosDeVida = 80;
            this.PontosDeMagia = 50;

        }
        public override string Atacar()
        {
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1, 15);
            this.ValorultimaAtaque = forcaDoAtaque;
            return this.Nome + " Ataca e da " + forcaDoAtaque + " de dano";
        }
    }
}
