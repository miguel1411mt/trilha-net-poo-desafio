namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory){}

        public override void InstallApp(string name)
        {
            Console.WriteLine($"instalando o {name} para Iphone modelo: {Model}");
        }
    }
}