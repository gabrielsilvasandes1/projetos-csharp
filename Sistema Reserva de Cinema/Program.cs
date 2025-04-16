using System;
using static System.Console;

class Program {
    static void Main() {
        string[] filmes = { "Matrix", "Interestelar", "Vingadores" };
        string[] horarios = { "18:00", "20:00", "22:00" };
        bool[,] assentos = new bool[3, 5]; 

        bool rodando = true;

        while (rodando) {
            WriteLine("\n--- MENU ---");
            WriteLine("1 - Ver filmes");
            WriteLine("2 - Reservar assento");
            WriteLine("3 - Sair");
            Write("Sua opção: ");

            string escolha = ReadLine();

            switch (escolha) {
                case "1":
                    WriteLine("\nFilmes disponíveis:");
                    for (int i = 0; i < filmes.Length; i++) {
                        WriteLine($"{i + 1} - {filmes[i]} ({horarios[i]})");
                    }
                    break;

                case "2":
                    WriteLine("\nEscolha o filme:");
                    for (int i = 0; i < filmes.Length; i++) {
                        WriteLine($"{i + 1} - {filmes[i]}");
                    }
                    Write("Sua opção: ");

                    int filmeEscolhido = int.Parse(ReadLine()) - 1;

                    WriteLine($"\nAssentos para {filmes[filmeEscolhido]}:");
                    for (int i = 0; i < 5; i++) {
                        string status = assentos[filmeEscolhido, i] ? "[X]" : "[ ]";
                        WriteLine($"Assento {i + 1}: {status}");
                    }

                    Write("\nQuantos assentos você deseja reservar? ");
                    int quantidadeAssentos = int.Parse(ReadLine());

                    for (int i = 0; i < quantidadeAssentos; i++) {
                        Write($"Escolha o assento {i + 1} de {quantidadeAssentos} (1 a 5): ");
                        int assentoEscolhido = int.Parse(ReadLine()) - 1;

                        if (assentoEscolhido < 0 || assentoEscolhido >= 5) {
                            WriteLine("Assento inválido!");
                            i--; 
                            continue;
                        }

                        if (assentos[filmeEscolhido, assentoEscolhido]) {
                            WriteLine("Assento já reservado!");
                            i--; 
                        } else {
                            assentos[filmeEscolhido, assentoEscolhido] = true;
                            WriteLine("Reserva realizada com sucesso!");
                        }
                    }

                    break;

                case "3":
                    rodando = false;
                    WriteLine("Encerrando...");
                    break;

                default:
                    WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
