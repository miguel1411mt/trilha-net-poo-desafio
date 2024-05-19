using System.Reflection;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            Imei = imei;
            Memory = memory;
        }
        public string Number { get; set; }
        public string Model { get; set; }
        public string Imei { get; set; }
        public int Memory { get; set; }

        public void Call (string number)
        {
            Console.WriteLine($"Ligando para: {number}");
        }

        public void ReceiveCall(string number)
        {
            Console.WriteLine($"Recebendo ligação de: {number}");
        }

        public abstract void InstallApp(string name);
    }
}