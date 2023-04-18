//variaveis
string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

//Senha para acesso ao app
Console.WriteLine($"------Bem Vindo a AirLines Senai------");
Console.WriteLine($"Digite a senha: ");
string senha = Console.ReadLine();

while (senha != "123456")
{
    Console.WriteLine($"Tente novamente: ");
    senha = Console.ReadLine();
}
Console.WriteLine($"Acesso Liberado! Aperte ENTER para continuar. ");
string escolha = Console.ReadLine();

do
{

    Console.WriteLine($"Menu inicial");
    Console.WriteLine($"Selecione uma opcao:");
    Console.WriteLine($"[1] - cadastro");
    Console.WriteLine($"[2] - Lista de Cadastro");
    Console.WriteLine($"[0] - Sair");

    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            string resposta;
            do
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Informe os dados do {i + 1}º passageiro:");
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
                Console.WriteLine(@$"
        Passageiros e passagens

        Nome: {nome[i]}
        Origem:{origem[i]}
        Destino:{destino[i]}
        Data:{data[i]}

        ");
            }
            break;

        case "0":
            Console.WriteLine($"Finalizado o programa, Obrigado!");

            break;

        default:
            Console.WriteLine($"Esta opcao nao existe!");

            break;
    }
} while (escolha != "0");
//menu opcao







//fim senha de acesso





/*Console.WriteLine(@$"
-----Menu-----
1- Cadastrar passagem
2- Listar passagens
0- Sair");
int menu = int.Parse(Console.ReadLine());


switch (menu)
{

    case 1:

        for (quantidadePassageiros = 0; quantidadePassageiros < nome.Length; quantidadePassageiros++)
        {
            Console.WriteLine($"Informe o nome do passageiro: ");
            nome[quantidadePassageiros] = Console.ReadLine();
            Console.WriteLine($"Informe a origem do passageiro: ");
            origem[quantidadePassageiros] = Console.ReadLine();
            Console.WriteLine($"Informe o destino do passageiro: ");
            destino[quantidadePassageiros] = Console.ReadLine();
            Console.WriteLine($"Informe a data do voo do passageiro: ");
            data[quantidadePassageiros] = Console.ReadLine();
        }

        Console.WriteLine("Deseja cadastrar uma nova passagem? (S/N)");
        string cadastrarNovaPassagem = Console.ReadLine();

        while (cadastrarNovaPassagem.ToUpper() != "S" && cadastrarNovaPassagem.ToUpper() != "N")
        {
            Console.WriteLine("Opção inválida. Digite S ou N.");
            cadastrarNovaPassagem = Console.ReadLine();
        }

        if (cadastrarNovaPassagem.ToUpper() == "S")
        {
            Console.WriteLine($"Quanto passageiros vao embarcar?");
            quantidadePassageiros = int.Parse(Console.ReadLine());


            for (quantidadePassageiros = 0; quantidadePassageiros < nome.Length; quantidadePassageiros++)
            {
                Console.WriteLine($"Informe o nome do passageiro: ");
                nome[quantidadePassageiros] = Console.ReadLine();
                Console.WriteLine($"Informe a origem do passageiro: ");
                origem[quantidadePassageiros] = Console.ReadLine();
                Console.WriteLine($"Informe o destino do passageiro: ");
                destino[quantidadePassageiros] = Console.ReadLine();
                Console.WriteLine($"Informe a data do voo do passageiro: ");
                data[quantidadePassageiros] = Console.ReadLine();
            }

        }

        if (cadastrarNovaPassagem.ToUpper() == "N")
        {
            Console.WriteLine(@$"
-----Menu-----
1- Cadastrar passagem
2- Listar passagens
0- Sair");
            menu = int.Parse(Console.ReadLine());
        }

        break;

    case 2:

        Console.WriteLine("Listagem de passagens:");

        foreach (var passagem in nome)
        {
            Console.WriteLine($"nome do infeliz: {nome}");

        }

        break;



    case 0:
        Console.WriteLine("Obrigado por utilizar nosso sistema!");
        break;



    default:
    while(true)
    {

        do
        {
            Console.WriteLine($"Você informou um número inexistente, favor tente novamente: ");
            menu = int.Parse(Console.ReadLine());
        }
        while (menu < 0 || menu > 2);

        for (quantidadePassageiros = 0; quantidadePassageiros < nome.Length; quantidadePassageiros++)
        {
            Console.WriteLine($"Informe o nome do passageiro: ");
            nome[quantidadePassageiros] = Console.ReadLine();
            Console.WriteLine($"Informe a origem do passageiro: ");
            origem[quantidadePassageiros] = Console.ReadLine();
            Console.WriteLine($"Informe o destino do passageiro: ");
            destino[quantidadePassageiros] = Console.ReadLine();
            Console.WriteLine($"Informe a data do voo do passageiro: ");
            data[quantidadePassageiros] = Console.ReadLine();
        }

        Console.WriteLine("Deseja cadastrar uma nova passagem? (S/N)");
        cadastrarNovaPassagem = Console.ReadLine();

        while (cadastrarNovaPassagem.ToUpper() != "S" && cadastrarNovaPassagem.ToUpper() != "N")
        {
            Console.WriteLine("Opção inválida. Digite S ou N.");
            cadastrarNovaPassagem = Console.ReadLine();
        }

        if (cadastrarNovaPassagem.ToUpper() == "S")
        {
            Console.WriteLine($"Quanto passageiros vao embarcar?");
            quantidadePassageiros = int.Parse(Console.ReadLine());


            for (quantidadePassageiros = 0; quantidadePassageiros < nome.Length; quantidadePassageiros++)
            {
                Console.WriteLine($"Informe o nome do passageiro: ");
                nome[quantidadePassageiros] = Console.ReadLine();
                Console.WriteLine($"Informe a origem do passageiro: ");
                origem[quantidadePassageiros] = Console.ReadLine();
                Console.WriteLine($"Informe o destino do passageiro: ");
                destino[quantidadePassageiros] = Console.ReadLine();
                Console.WriteLine($"Informe a data do voo do passageiro: ");
                data[quantidadePassageiros] = Console.ReadLine();
            }

        }

        if (cadastrarNovaPassagem.ToUpper() == "N")
        {
            Console.WriteLine(@$"
-----Menu-----
1- Cadastrar passagem
2- Listar passagens
0- Sair");
            menu = int.Parse(Console.ReadLine());
    }

        }
        break;

}

*/