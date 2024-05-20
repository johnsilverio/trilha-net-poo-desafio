namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Realizado: 20/05/2024

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicatico " + '"' + nomeApp + '"' + " no Nokia");
        }
    }
}