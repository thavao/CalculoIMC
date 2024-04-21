double altura, peso, imc;
int sexo;


Console.Write("Digite o peso em Kg: ");
peso = double.Parse(Console.ReadLine());

Console.Write("Digite a altura em metro: ");
altura = double.Parse(Console.ReadLine());

Console.WriteLine("Selecione o sexo: ");
Console.WriteLine("[1] - feminino | [2] - masculino");
sexo = int.Parse(Console.ReadLine());

imc = peso / (altura * altura);

Console.WriteLine("Resultado do IMC: ");

if (sexo == 1)
{
    if (imc < 19.1)
        Console.WriteLine("Abaixo do peso");

    else if (imc >= 19.1 && imc <= 25.8)
        Console.WriteLine("Peso ideal");

    else if (imc >= 25.9 && imc <= 27.3)
        Console.WriteLine("Pouco acima do peso");

    else if (imc >= 27.4 && imc <= 32.3)
        Console.WriteLine("Acima do peso");

    else
        Console.WriteLine("Obesidade");
}
else if (sexo == 2)
{
    if (imc < 20.7)
        Console.WriteLine("Abaixo do peso");

    else if (imc >= 20.7 && imc <= 26.4)
        Console.WriteLine("Peso ideal");

    else if (imc >= 26.5 && imc <= 27.8)
        Console.WriteLine("Pouco acima do peso");

    else if (imc >= 27.9 && imc <= 31.1)
        Console.WriteLine("Acima do peso");

    else
        Console.WriteLine("Obesidade");
}
else
{
    Console.WriteLine("Sexo inválido...");
}



Console.WriteLine("Pressione Enter para continuar...");

Console.ReadLine();