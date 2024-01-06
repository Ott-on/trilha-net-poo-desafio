namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Iphone...");
            // Contagem da instalação.
            string[] contagem = {"1%","10%","25%","50%","75%","100%"};

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