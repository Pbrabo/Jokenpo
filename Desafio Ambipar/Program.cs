
using System.Collections;
using System.Runtime.CompilerServices;

Console.WriteLine("Bem-vindo ao Jokenpo");
Console.WriteLine("Faça sua escolha e aguarde enquanto o Player 2 faz a escolha dele para revelarmos o resultado.");

//apresentando as opção dos jogadores
Console.WriteLine("Escolha entre: pedra, papel, tesoura, lagarto ou spock");

//Fazer leitura da escolha com ReadLine
string suaEscolha = Console.ReadLine();
string escolhaAdversario = Console.ReadLine();


//declarando as opções de escolha do usuario1
switch (suaEscolha)

{
    case "pedra":
        Console.WriteLine("Você escolheu Pedra\n");
        break;

    case "papel":
        Console.WriteLine("Você escolheu papel\n");
        break;

    case "tesoura":
        Console.WriteLine("Você escolheu tesoura\n");
        break;

    case "lagarto":
        Console.WriteLine("Você escolheu lagarto\n");
        break;

    case "spock":
        Console.WriteLine("Você escolheu spock\n");
        break;

    default:
        Console.WriteLine("Valor inválido\n");
        break;
}

//Condição de escolha do segundo usuario na ideia de ser uma pessoa em outra tela.
switch (escolhaAdversario)

{
    case "pedra":
        Console.WriteLine("Seu adversário escolheu Pedra\n");
        break;

    case "papel":
        Console.WriteLine("Jogador 2 escolheu papel\n");
        break;

    case "tesoura":
        Console.WriteLine("Jogador 2 escolheu tesoura\n");
        break;

    case "lagarto":
        Console.WriteLine("Jogador 2 escolheu lagarto\n");
        break;

    case "spock":
        Console.WriteLine("Jogador 2 escolheu spock\n");
        break;

    default:
        Console.WriteLine("Valor inválido\n");
        break;
}


string resultado = suaEscolha + " " + escolhaAdversario;

    //Usei o Switch como comparadores durante algumas pesquisas e testes que fiz e achei que ele ficou visualmente melhor do que várias condições de IF e Else IF.
    //Não sei se esse formato é considerado bom mas gostei da forma que o código ficou mais legivel.

    switch (resultado)
    {
        //Condição de vitória
        case "pedra tesoura":
        case "pedra lagarto":
        case "papel pedra":
        case "papel spock":
        case "tesoura papel":
        case "tesoura lagarto":
        case "lagarto spock":
        case "lagarto papel":
        case "spock tesoura":
        case "spock pedra":
            Console.WriteLine("Você venceu");
        break;

        //Condição de perda
        case "tesoura pedra":
        case "lagarto pedra":
        case "pedra papel":
        case "spock papel":
        case "papel tesoura":
        case "lagarto tesoura":
        case "spock lagarto":
        case "papel lagarto":
        case "tesoura spock":
        case "pedra spock":
            Console.WriteLine("Você perdeu");
        break;
        
        //Condição de empate
        default:
        Console.WriteLine("Empate");
        break;  
    }

