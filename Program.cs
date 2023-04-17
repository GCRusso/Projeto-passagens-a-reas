/*Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
O sistema deve exibir um menu com as seguintes opções:

1- Cadastrar passagem
2- Listar Passagens
0- Sair


Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).


1- acesso ao sistema SENHA
2- cadastrar nome,origem, destino e data 5 passageiros
3- menu
4- cadastrar uma nova passagem? ou nao.*/


Console.WriteLine($"------Bem Vindo a Russo's AirLines------");

//Senha para acesso ao app
Console.WriteLine($"Digite a senha: ");
string senha = Console.ReadLine();

while (senha != "123456")
{
    Console.WriteLine($"Tente novamente: ");
    senha = Console.ReadLine();
}
Console.WriteLine($"Acesso Liberado! ");
//fim senha de acesso



Console.WriteLine(@$"
-----Menu-----
1- Cadastrar passagem
2- Listar passagens
0- Sair");
int menu = int.Parse(Console.ReadLine());


//quantidade de passageiros para embarcar no voô
Console.WriteLine($"Quanto passageiros vao embarcar?");

int quantidadePassageiros = int.Parse(Console.ReadLine());

//static void formularioCadastro(){

string[] nome = new string[quantidadePassageiros];
string[] origem = new string[quantidadePassageiros];
string[] destino = new string[quantidadePassageiros];
string[] data = new string[quantidadePassageiros];




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

        break;

}

