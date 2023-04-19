//variaveis
string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

//Senha para acesso ao app
Console.WriteLine($"------Bem Vindo a Senai AirLines ------");
Console.WriteLine($"Digite a senha: ");
string senha = Console.ReadLine();

while (senha != "123456")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Tente novamente: ");
    Console.ResetColor();
    senha = Console.ReadLine();
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Acesso Liberado! Aperte ENTER para continuar. ");
Console.ResetColor();
string escolha = Console.ReadLine();

do
{
    Console.WriteLine($"Menu inicial");
    Console.WriteLine($"Selecione uma opcao:");
    Console.WriteLine($"1 - cadastro");
    Console.WriteLine($"2 - Lista de Cadastro");
    Console.WriteLine($"0 - Sair");

    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            string resposta;
            do
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Informe os dados do {i + 1}º passageiro:");
                    Console.ResetColor();
                    Console.WriteLine($"Informe o nome: ");
                    nome[i] = Console.ReadLine();
                    Console.WriteLine($"Informe a origem: ");
                    origem[i] = Console.ReadLine();
                    Console.WriteLine($"Informe o destino: ");
                    destino[i] = Console.ReadLine();
                    Console.WriteLine($"Informe a data: ");
                    data[i] = Console.ReadLine();
                }

                Console.WriteLine($"Gostaria de cadastrar novas passagens S/N?: ");
                resposta = Console.ReadLine().ToLower();

            } while (resposta == "s");

            break;

        case "2":
            for (var i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@$"
        Passageiros e passagens

        Nome: {nome[i]}
        Origem:{origem[i]}
        Destino:{destino[i]}
        Data:{data[i]}

        ");
                Console.ResetColor();
            }
            break;

        case "0":
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"
            Finalizando o programa... 
            Obrigado!");
            Console.ResetColor();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Esta opcao nao existe!");
            Console.ResetColor();

            break;
    }
} while (escolha != "0");