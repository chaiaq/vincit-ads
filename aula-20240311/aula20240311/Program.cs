// Tarefa:
// Construir um if que verificar se o aluno é maior de idade:

string nome;
int anoAtual, anoNascimento, idade;

anoAtual = 2024;

Console.WriteLine("Digite o nome do aluno:");
nome = Console.ReadLine();

Console.WriteLine("Qual o ano do seu nascimento? (XXXX)");
anoNascimento = int.Parse(Console.ReadLine());

idade = anoAtual - anoNascimento;

if (idade > 18) {
    Console.WriteLine(nome + " é maior de idade");
} else {
    Console.WriteLine(nome + " tem menos que 18 anos");
}
