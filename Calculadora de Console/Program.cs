using System;
using static System.Console;

class Program {
    static void Main() {
        Write("Digite o primeiro número: ");
        int numberOne = int.Parse(ReadLine());
        Write("Digite o segundo número: ");
        int numberTwo = int.Parse(ReadLine());
        int i = 0;
        int UserOption = int.Parse(ReadLine());
        do {
            if (UserOption == 5) {
            i = 5;
        }
            Write(@"
[1] Somar
[2] Multiplicar
[3] Subtrair
[4] Dividir
[5] Sair
Sua opção: ");
        } while (i != 5);
        if (UserOption == 1) {
            int result = numberOne + numberTwo; 
            WriteLine($"{numberOne} + {numberTwo} = {result}");
        }

        else if (UserOption == 5) {
            i = 5;
        }

    }
}
