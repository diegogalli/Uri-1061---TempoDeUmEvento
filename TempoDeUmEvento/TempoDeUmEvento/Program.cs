using System;
using System.Globalization;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int W1, X1, Y1, Z1, W2, X2, Y2, Z2, W, X, Y, Z, INICIO, FIM, DURACAO, RESTO;

            // Ler a primeira linha, armazenando o valor de W (dia)
            string[] valores = Console.ReadLine().Split(' ');
            W1 = int.Parse(valores[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X1 = int.Parse(valores[0]);
            Y1 = int.Parse(valores[2]);
            Z1 = int.Parse(valores[4]);

            // Ler a terceira linha, armazenando o valor de W (dia)
            valores = Console.ReadLine().Split(' ');
            W2 = int.Parse(valores[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X2 = int.Parse(valores[0]);
            Y2 = int.Parse(valores[2]);
            Z2 = int.Parse(valores[4]);

            // Calculando o valor do inicio e fim, convertendo tudo para segundos
            INICIO = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            FIM = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;

            // Calculando a duracao em segundos

            DURACAO = FIM - INICIO;

            // Agora vamos desmembrar a duracao em segundos para dia (W), hora (X), minutos (Y) e segundos (Z) restantes

            W = DURACAO / (24 * 60 * 60);
            RESTO = DURACAO % (24 * 60 * 60);
            X = RESTO / (60 * 60);
            RESTO = RESTO % (60 * 60);
            Y = RESTO / 60;
            Z = RESTO % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");
        }
    }
}
