using DesafioPOO.Models;

// Teste Interativo:
class Program 
{
    static void Main()
    {   
        // Manter o menu ligado
        bool ExibirMenu = true;
        // variavel para decidir qual o smartphone (Nokia ou Iphone)
        string smartphone = string.Empty;
        
        // Verificação para não ser vazio.
        Console.Write("Digite o tipo do seu Smartphone: ");
        do
        {
            smartphone = Console.ReadLine().ToLower();
        }while(smartphone.Length < 1);
        
        // Variáveis a serem colocadas no Smartphone:
        Console.Write("Número do Smartphone:");
        string numero = Console.ReadLine();
        Console.Write("Modelo do Smartphone:");
        string modelo = Console.ReadLine();
        Console.Write("IMEI do Smartphone:");
        string imei = Console.ReadLine();
        Console.Write("Memória do Smartphone: ");
        int.TryParse(Console.ReadLine(), out int memoria);

        if (smartphone == "iphone")
        {   
            Iphone iphone = new Iphone(numero, modelo, imei, memoria);
            
            while (ExibirMenu)
            {   
                Console.Clear();
                Console.WriteLine("Opções: ");
                Console.WriteLine("1 - Instalar aplicativos");
                Console.WriteLine("2 - Configurações do sistema");
                Console.WriteLine("3 - Ligar para o contato");
                Console.WriteLine("4 - Receber ligação");
                Console.WriteLine("5 - Exibir aplicativos instalados");
                Console.WriteLine("6 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Entrando no aplicativo de instalação...");

                        Console.Write("Qual aplicativo deseja instalar: ");
                        
                        string aplicativo = string.Empty;

                        do
                        {
                            aplicativo = Console.ReadLine().ToLower();
                        }while(aplicativo.Length < 1);

                        iphone.InstalarAplicativo(aplicativo);
                        break;
                    case "2":
                        Console.WriteLine("Configurações do seu Iphone:");
                        iphone.ExibirConfiguracoes();
                        break;
                    case "3":
                        iphone.Ligar();
                        break;
                    case "4":
                        iphone.ReceberLigacao();
                        break;
                    case "5":   
                        Console.WriteLine("Aplicativos instalados do seu Iphone: ");
                        iphone.ExibirAplicativos();
                        break;
                    case "6":
                        ExibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadLine();
            }
            
        }

        else if (smartphone == "nokia")
        {
            Nokia nokia = new Nokia(numero, modelo, imei, memoria);
            
            nokia.InstalarAplicativo("Whatsapp");

            while (ExibirMenu)
            {   
                Console.Clear();
                Console.WriteLine("Opções: ");
                Console.WriteLine("1 - Instalar Aplicativos");
                Console.WriteLine("2 - Configurações do sistema");
                Console.WriteLine("3 - Ligar para o contato");
                Console.WriteLine("4 - Receber ligação");
                Console.WriteLine("5 - Exibir aplicativos instalados");
                Console.WriteLine("6 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Entrando no aplicativo de instalação...");
                        Console.Write("Qual aplicativo deseja instalar: ");
                        
                        string aplicativo = string.Empty;

                        do
                        {
                            aplicativo = Console.ReadLine().ToLower();
                        }while(aplicativo.Length < 1);

                        nokia.InstalarAplicativo(aplicativo);
                        break;
                    case "2":
                        Console.WriteLine("Configurações do seu Nokia:");
                        nokia.ExibirConfiguracoes();
                        break;
                    case "3":
                        nokia.Ligar();
                        break;
                    case "4":
                        nokia.ReceberLigacao();
                        break;
                    case "5":
                        Console.WriteLine("Aplicativos instalados do seu Nokia: ");
                        nokia.ExibirAplicativos();
                        break;
                    case "6":
                        ExibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadLine();

            }
            
        }
    }
}
