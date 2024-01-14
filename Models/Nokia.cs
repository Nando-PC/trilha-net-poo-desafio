namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //implementado
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {}
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o Aplicativo {nomeApp} para o Nokia.");
        }

    }
}