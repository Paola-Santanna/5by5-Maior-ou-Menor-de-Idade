// 3.Faça um algorítmo que leia a idade de uma pessoa e informe se ela é maior ou menor de idade;

int idade;

Console.WriteLine("Digite a sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade < 0 )
{
    Console.WriteLine("\nNão existe idade negativa");
} else if (idade < 18 && idade > 0)
{
    Console.WriteLine("\nMENOR de Idade!");
} else
{
    Console.WriteLine("\nMAIOR de Idade!");
}