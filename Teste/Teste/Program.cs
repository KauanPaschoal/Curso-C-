using System;
using System.Collections.Generic;

namespace CRUDExemplo
{
    class Program
    {
        // Classe Usuario
        public class Usuario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
        }

        // Lista em memória para simular um banco de dados
        static List<Usuario> usuarios = new List<Usuario>();
        static int proximoId = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Sistema de Gerenciamento de Usuários ---");
                Console.WriteLine("1. Criar Usuário");
                Console.WriteLine("2. Listar Usuários");
                Console.WriteLine("3. Atualizar Usuário");
                Console.WriteLine("4. Excluir Usuário");
                Console.WriteLine("5. Sair");

                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        CriarUsuario();
                        break;
                    case "2":
                        ListarUsuarios();
                        break;
                    case "3":
                        AtualizarUsuario();
                        break;
                    case "4":
                        ExcluirUsuario();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        // Criar Usuário
        static void CriarUsuario()
        {
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o email do usuário: ");
            string email = Console.ReadLine();

            Usuario novoUsuario = new Usuario { Id = proximoId++, Nome = nome, Email = email };
            usuarios.Add(novoUsuario);

            Console.WriteLine("Usuário criado com sucesso!");
        }

        // Listar Usuários
        static void ListarUsuarios()
        {
            Console.WriteLine("\n--- Lista de Usuários ---");

            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário encontrado.");
                return;
            }

            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"ID: {usuario.Id}, Nome: {usuario.Nome}, Email: {usuario.Email}");
            }
        }

        // Atualizar Usuário
        static void AtualizarUsuario()
        {
            Console.Write("Digite o ID do usuário que deseja atualizar: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            var usuario = usuarios.Find(u => u.Id == id);
            if (usuario == null)
            {
                Console.WriteLine("Usuário não encontrado.");
                return;
            }

            Console.Write("Digite o novo nome (deixe em branco para manter o atual): ");
            string nome = Console.ReadLine();

            Console.Write("Digite o novo email (deixe em branco para manter o atual): ");
            string email = Console.ReadLine();

            if (!string.IsNullOrEmpty(nome))
                usuario.Nome = nome;

            if (!string.IsNullOrEmpty(email))
                usuario.Email = email;

            Console.WriteLine("Usuário atualizado com sucesso!");
        }

        // Excluir Usuário
        static void ExcluirUsuario()
        {
            Console.Write("Digite o ID do usuário que deseja excluir: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            var usuario = usuarios.Find(u => u.Id == id);
            if (usuario == null)
            {
                Console.WriteLine("Usuário não encontrado.");
                return;
            }

            usuarios.Remove(usuario);
            Console.WriteLine("Usuário excluído com sucesso!");
        }
    }
}