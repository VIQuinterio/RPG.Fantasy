using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Fantasy
{
    public class Menu
    {
        public string ObterOpcaoUsuario()
        {
            Console.WriteLine("RPG FANTASY \n");
            Console.WriteLine("Informe a opção desejada:\n");
            Console.WriteLine("1- Inserir novo personagem");
            Console.WriteLine("2- Listar personagens");
            Console.WriteLine("3- Status do personagem");
            Console.WriteLine("4- Atualizar personagem");
            Console.WriteLine("5- Excluir personagem");
            Console.WriteLine("6- Entrar na dungeon");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }
    }
}
