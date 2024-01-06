namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set;}
        private string IMEI { get; set;}
        private int Memoria { get; set;}
        public List<string> aplicativos {get; set;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            aplicativos = new List<string>();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public void ExibirAplicativos()
        {
            if (aplicativos.Count != 0)
            {
                foreach(string item in aplicativos)
                {
                Console.WriteLine($"- {item}");
                }
            }
            else
            {
                Console.WriteLine("Seu smartphone não possue aplicativos instalados.");
            }

        }
        public void ExibirConfiguracoes()
        {
            Console.WriteLine($"Número: {Numero}\nModelo: {Modelo}\nIMEI: {IMEI}\nMemória: {Memoria}GB");
        }
    }
}