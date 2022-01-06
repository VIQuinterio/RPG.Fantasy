using RPG.Fantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Fantasy.Classes
{
    public class PersonaRepositorio : IRepositorio<Personagem>
    {
		private List<Personagem> listaPersonagem = new List<Personagem>();
		
		public void Insere(Personagem objeto)
		{
			listaPersonagem.Add(objeto);
		}

		public List<Personagem> Lista()
		{
			return listaPersonagem;
		}
		public void Atualiza(int id, Personagem objeto)
		{
			listaPersonagem[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaPersonagem[id].Excluir();
		}

		public int ProximoId()
		{
			return listaPersonagem.Count;
		}

		public Personagem RetornaPorId(int id)
		{
			return listaPersonagem[id];
		}
	}
}
