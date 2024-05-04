// Screen Sound
string mensagemBoasVindas = "\nBem-Vindos ao Screen Sound!";
List<string> listaBandas = new List<string> {"Coldplay"};

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine(" ");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para cadastrar uma banda");
    Console.WriteLine("Digite 2 para exibir todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair do menu");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // A '!' exige que o valor seja uma STRING, evitando valores nulos.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: CadastrarBandas();
            break;

        case 2: MostrarBandas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 0: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}

void CadastrarBandas()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("*******************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
    Thread.Sleep(1000); // Essa função da um delay de 2000 segundos para passar para a próxima linha de código
    Console.Clear();
   ExibirOpcoesDoMenu();
}
void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Bandas cadastradas");
    Console.WriteLine("*******************\n");

    /*for (int i = 0; i < listaBandas.Count; i++) // lista.Count (Enquanto houver bandas, percorra pelo loop.)
    {
        Console.WriteLine($"Banda: {listaBandas[i]}");
    }*/
    foreach (string banda in listaBandas) // PARA CADA BANDA NA ListaBANDAS, exiba: console.writeline
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.Write("\nPressione qualquer tecla para voltar ao menu principal ");
    Console.ReadKey(); // Faz voltar a tela inicial com qualquer click
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();