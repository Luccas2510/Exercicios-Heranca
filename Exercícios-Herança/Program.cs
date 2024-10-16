using Exercícios_Herança;

//         Exercício 5 Pessoa          //


Funcionario funci1 = new Funcionario { Nome = "Luccas", Idade = 25 };
Funcionario funci2 = new Funcionario { Nome = "Diego", Idade = 23 };
Funcionario funci3 = new Funcionario { Nome = "Matheus", Idade = 21 };
//Chamando o método Envelhecer
//funci1.Envelhecer(10);//Somar a idade que você passou para variavél func1 mais 10 anos
funci1.Rejuvenecer(7);//Somar a idade que você passou para variavél func1 mais 10 anos
//Exibindoas informações dos funcionários
Console.WriteLine($"O seu funcionário se chama {funci1.Nome} e tem {funci1.Idade} anos de idade");
Console.WriteLine($"O seu funcionário se chama {funci2.Nome} e tem {funci2.Idade} anos de idade");
Console.WriteLine($"O seu funcionário se chama {funci3.Nome} e tem {funci3.Idade} anos de idade");


//         Exercício 6 Animal          //



//Gato gato = new Gato
//{
//    Especie = "Maine Coon"
//};
//Console.WriteLine($"A espécie do gato é: {gato.Especie}");
//gato.EmitirSom();
//Porco porco = new Porco
//{
//    Especie = "Porco Doméstico"
//};
//Console.WriteLine($"A espécie do porco é: {porco.Especie}");
//porco.EmitirSom();
//Capivara capivara = new Capivara
//{
//    Especie = "Capivara"
//};
//Console.WriteLine($"A espécie da capivara é: {capivara.Especie}");
//capivara.EmitirSom();



//         Exercício 7 ContaGenerica          //


//ContaCorrente conta = new ContaCorrente
//{
//Banco = "itaú",
//Agencia = 1234,
//Conta = 654321,
//Saldo = 5000,
//limite = 10000,
//};
//Console.WriteLine($"O banco é: {conta.Banco}, com a agencia: {conta.Agencia}, e aconta: {conta.Conta}, com um saldo de: {conta.Saldo}, o limite é de: {conta.limite}.");
//conta.depositar();
//conta.sacar();


//Encerra o programa!
Console.WriteLine("Pressione qualquer tecla para sair");
Console.ReadKey();