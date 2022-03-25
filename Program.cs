double n1, n2, n3, n4, resultado;

//const double QuantidadeDeValores = 4;

Console.WriteLine("Média Arimética de 4 números\n" );

Console.Write("Digite o primeiro número..:");
n1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o segundo número..:");
n2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o terceiro número..:");
n3 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o quarto número..:");
n4 = Convert.ToDouble(Console.ReadLine()!);

resultado = n1 + n2 + n3 + n4;

Console.WriteLine($"soma: {resultado}" );
