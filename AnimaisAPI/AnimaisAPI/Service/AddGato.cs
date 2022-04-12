using AnimaisAPI.Interfaces;
using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class AddGato : IAddGato
    {
        public static void AddGatos(Gato gato)
        {
            StreamWriter writer = File.AppendText(@"C:\Users\Kley\Desktop\LEITURABICHO.txt");
            writer.WriteLine(gato.Especie + "|" + gato.Raca + "|" + gato.Idade);
            writer.Close();
        }   
    }
}
