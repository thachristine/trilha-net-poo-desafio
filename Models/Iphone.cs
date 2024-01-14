namespace DesafioPOO.Models
{
    // Concluido!!!
    public class Iphone
    {
        public Iphone(string numero, string modelo, string ime, int memoria) :
        // TODO: Sobrescrever o método "InstalarAplicativo"
        base(numero,modelo,ime,memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)

        {
            Console.WriteLine($"Instalando o {nomeApp} - Acessar a Apple Store para baixar mais aplicativos no seu Iphone");
        }
    }
}
