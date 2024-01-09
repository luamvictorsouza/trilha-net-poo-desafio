namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}

namespace DesafioPOO.Models
{
    
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public abstract void InstalarAplicativo(string nome);
    }

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Nokia {Modelo}");
        }
    }

    public class iPhone : Smartphone
    {
        public iPhone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no iPhone {Modelo}");
        }
    }
}
