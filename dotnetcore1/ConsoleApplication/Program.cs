using System;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication {
    class Program {
        static void Main (string[] args) {
            WriteLine ("Acessando a Web API. Aguarde um momento.. :) ");
            int opcaoDesejada = 1;
            while (opcaoDesejada != 0) {

                WriteLine ("Digite 1 para todos, 2 para pesquisar um usuário específico, 3 PARA CADASTRAR..");

                opcaoDesejada = Int32.Parse (ReadLine ());

                if (opcaoDesejada == 1) {
                    GetTodos ();
                } else if (opcaoDesejada == 2) {
                    GetUsuarioById ();
                } else if (opcaoDesejada == 3) {
                    try {
                        AddUser ();
                    } catch (Exception ex) {

                        throw ex;
                    }
                }
            }
            ReadLine ();
        }

        static void GetTodos () {
            UsuarioRepository _usuarioRepository = new UsuarioRepository ();
            var usuariosTask = _usuarioRepository.GetUsuariosAsync ();

            //para cada resultado da minha lista usuariosTask eu vou escrever na tela
            usuariosTask.ContinueWith (
                task => {
                    var usuarios = task.Result;
                    foreach (var u in usuarios)
                        WriteLine (u.ToString ());
                    Environment.Exit (0);
                },
                TaskContinuationOptions.OnlyOnRanToCompletion
            );
        }

        static void GetUsuarioById () {
            WriteLine ("Digite o ID que deseja procurar: ");
            int id = Int32.Parse (ReadLine ());
            UsuarioRepository _usuarioRepository = new UsuarioRepository ();
            var usuarioTask = _usuarioRepository.GetUsuarioByIdAsync (id);
            usuarioTask.ContinueWith (
                task => {
                    var usuario = task.Result;
                    WriteLine (usuario.ToString ());
                },
                TaskContinuationOptions.OnlyOnRanToCompletion
            );
        }

        public static void AddUser () {
            Usuario usuario = new Usuario ();
            WriteLine ("Digite o nome do usuário:");
            usuario.Nome = ReadLine ();
            WriteLine ("Digite o e-mail");
            usuario.Email = ReadLine ();
            WriteLine ("Digite a senha");
            usuario.Senha = ReadLine ();
            UsuarioRepository _usuarioRepository = new UsuarioRepository ();
            _usuarioRepository.AddUsuario (usuario);
            WriteLine ("Cadastrado com sucesso!");
            return;
        }
    }
}