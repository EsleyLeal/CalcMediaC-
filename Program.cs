using System.Globalization;

string mensagemDeBoasVindas = "Bem-vindo à área do aluno!\n";
// Criei uma vareavel, um exibe a quantidade de TESTE para a divisão na quantidade de notas(soma).
// Criei outra vareavel com o valor 7, media de aprovação.

int quantidadeDeTestes = 3;
double mediaDeAprovacao = 7;


void exibirLogo()
{
    Console.WriteLine(@"
░█▀▀█ █▀▀█ █── █▀▀ █▀▀▀ ─▀─ █▀▀█ 　 ░█▀▄▀█ █──█ ▀▀█▀▀ █▀▀█ █▀▀▄ ▀▀█▀▀ █▀▀ 
░█─── █──█ █── █▀▀ █─▀█ ▀█▀ █──█ 　 ░█░█░█ █──█ ──█── █▄▄█ █──█ ──█── █▀▀ 
░█▄▄█ ▀▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀▀ 　 ░█──░█ ─▀▀▀ ──▀── ▀──▀ ▀──▀ ──▀── ▀▀▀");
    Console.WriteLine(" ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void calculaNota()
  {
    Console.WriteLine("Digite a nota do Primeiro teste");
    double nota1;
    if (!double.TryParse(Console.ReadLine()!.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out nota1))
    {
        Console.WriteLine("Valor inválido! Digite a nota em forma de número.");
        return;
    }

    Console.WriteLine("Digite a nota do Segundo teste");
    double nota2;
    if (!double.TryParse(Console.ReadLine()!.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out nota2))
    {
        Console.WriteLine("Valor inválido! Digite a nota em forma de número.");
        return;
    }

    Console.WriteLine("Digite a nota do Terceiro teste");
    double nota3;
    if (!double.TryParse(Console.ReadLine()!.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out nota3))
    {
        Console.WriteLine("Valor inválido! Digite a nota em forma de número.");
        return;
    }
    Console.WriteLine();

    var somaDasNotas = nota1 + nota2 + nota3;
    var mediaFinal = somaDasNotas / quantidadeDeTestes;

    Thread.Sleep(2000);
    Console.WriteLine("Calculando a MEDIA");

 
    Thread.Sleep(3000);

    Console.WriteLine($"Nota 1: {nota1}");
    Console.WriteLine($"Nota 2: {nota2}");
    Console.WriteLine($"Nota 3: {nota3}");

    Console.WriteLine();
    
    Console.WriteLine($"Média: {mediaFinal.ToString("N2")}");

    Console.WriteLine();
    

    if (mediaFinal >= mediaDeAprovacao)
    {
        Console.WriteLine("Você foi APROVADO\n");
    }
    else
    {
        Console.WriteLine("Você foi REPROVADO\n");
    }
}

exibirLogo();
calculaNota();


