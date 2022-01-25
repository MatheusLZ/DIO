using System;

    namespace Revisionar{

        class Program{

            static void Main(string[] args){

                Console.WriteLine("Informe a opção desejada aqui");
                Console.WriteLine("1 - Inserir aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine("x - Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine();

                while (opcaoUsuario.ToUpper() != "x"){
                    switch(opcaoUsuario){
                        case "1":
                            //to do: adicionar aluno
                            break;
                        case "2":
                            //listar alunos
                            break;
                        case "3":
                            //calcular média geral
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    Console.WriteLine("Informe a opção desejada aqui");
                    Console.WriteLine("1 - Inserir aluno");
                    Console.WriteLine("2 - Listar alunos");
                    Console.WriteLine("3 - Calcular média geral");
                    Console.WriteLine("x - Sair");
                    Console.WriteLine();

                    opcaoUsuario = Console.ReadLine();
                }

            }
        }
    }