namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
            // Contagem da instalação.
            string[] contagem = {"2%","15%","28%","50%","75%","100%"};

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{nomeApp} {contagem[i]}");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"{nomeApp} instalado com sucesso!");
            aplicativos.Add(nomeApp);
        }


    }
}