double idade, media, qtd, soma;

idade = double.Parse(Console.ReadLine());
qtd = 0;
soma = 0;


while (idade >= 0)
{
    qtd = qtd + 1;
    soma = soma + idade;
    
    idade = double.Parse(Console.ReadLine());
}

media = soma / qtd;
Console.WriteLine($"{media}");