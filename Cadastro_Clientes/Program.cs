string idCliente = "";
string nomeCliente = "";
string idade = "";
string corDoCabelo = "";

string? inputUser;
string escolhaMenu = "";
bool inputValido = false;

int idadeCliente = 0;
int maxClientes = 10;

string[,] usuarios = new string[maxClientes, 4];

for (int i = 0; i < maxClientes; i++)
{
    switch (i)
    {
        case 0:
            idCliente = "L1";
            nomeCliente = "Lucas";
            corDoCabelo = "Castanho";
            idade = "19";
            break;

        case 1:
            idCliente = "A1";
            nomeCliente = "Antônio";
            corDoCabelo = "Preto";
            idade = "25";
            break;

        case 2:
            idCliente = "F1";
            nomeCliente = "Felipe";
            corDoCabelo = "Loiro";
            idade = "46";
            break;

        default:
            idCliente = "";
            nomeCliente = "";
            corDoCabelo = "";
            idade = "";
            break;
    }
    usuarios[i, 0] = "ID #: " + idCliente;
    usuarios[i, 1] = "Nome: " + nomeCliente;
    usuarios[i, 2] = "Cor do Cabelo: " + corDoCabelo;
    usuarios[i, 3] = "Idade: " + idade;
}

do
{
    Console.Clear();

    Console.WriteLine("Bem-Vindo ao seu sistema de cadastro de clientes!\n");
    Console.WriteLine(" 1. Listar todos os clientes e suas informações");
    Console.WriteLine(" 2. Cadastrar um novo cliente");
    Console.WriteLine(" 3. Certificar que a cor de cabelo está preenchida");
    Console.WriteLine(" 4. Certificar que a idade está preenchida");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    inputUser = Console.ReadLine();
    if (inputUser != null)
    {
        escolhaMenu = inputUser.ToLower();
    }

    switch (escolhaMenu)
    {
        case "1":
            for (int i = 0; i < maxClientes; i++)
            {
                if (usuarios[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 4 ; j++)
                    {
                        Console.WriteLine(usuarios[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("Pressione Enter para retornar ao menu");
            Console.ReadLine();
            break;
    }

} while (escolhaMenu != "exit");