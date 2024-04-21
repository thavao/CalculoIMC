double altura, peso, imc;


Console.Write("Digite o peso em Kg: ");
peso = double.Parse(Console.ReadLine());

Console.Write("Digite a altura em metro: ");
altura = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);

Console.WriteLine("");
if (imc < 18.5)
    Console.WriteLine("Baixo peso");

else if (imc >= 18.5 && imc <= 24.9)
    Console.WriteLine("Peso normal");

else if (imc >= 25 && imc <= 29.9)
    Console.WriteLine("Sobrepeso");

else if (imc >= 30 && imc <= 34.9)
    Console.WriteLine("Obesidade grau I");

else if (imc >= 35 && imc <= 39.9)
    Console.WriteLine("Obesidade grau II");

else
    Console.WriteLine("Obesidade grau III");


Console.WriteLine("Pressione Enter para continuar...");

Console.ReadLine();