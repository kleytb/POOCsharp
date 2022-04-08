using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class CreateGato
    {
        public static Gato Create(Gato gato)
        {
            StreamWriter writer = File.AppendText(@"C:\Users\Kley\Desktop\LEITURABICHO.txt");
            writer.WriteLine(gato.Especie + "|" + gato.Raca + "|" + gato.Idade);
            writer.Close();
            return gato;
        }   
    }
}
