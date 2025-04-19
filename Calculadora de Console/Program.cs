using System;
using static System.Console;

class Program {
    static void Main() {
       while (true) {
         Write("Digite o primeiro número: ");
        int numberOne = int.Parse(ReadLine());
        Write("Digite o segundo número: ");
        int numberTwo = int.Parse(ReadLine());
        Write(@"
[1] Somar
[2] Multiplicar
[3] Subtrair
[4] Dividir
[5] Sair
Sua opção: ");

        int UserOption = int.Parse(ReadLine());

        switch (UserOption) {
            case 1:
                WriteLine($"{numberOne} + {numberTwo} = {numberOne+numberTwo}");
                break;
            case 2:
                WriteLine($"{numberOne} x {numberTwo} = {numberOne*numberTwo}");
                break;
            case 3:
                WriteLine($"{numberOne} - {numberTwo} = {numberOne-numberTwo}");
                break;
            case 4:
                double resultado = (double) numberOne / numberTwo;
                WriteLine($"{numberOne} ÷ {numberTwo} = {resultado.ToString("F2")}");
                break;
            case 5:
                WriteLine("Programa encerrado com sucesso.");
                return;
            default:
                WriteLine("Opção inválida. Tente Novamente!");
                continue;
        }
            if (UserOption >= 1 && UserOption <= 5) {
                Write("Deseja continuar? [S/N]: ");
                string UserContinue = ReadLine();
                if (UserContinue.ToUpper() == "S") {
                    continue;
                }
                else {
                    WriteLine("Programa encerrado com sucesso.");
                    break;
                }
            }
       }
    }
}
