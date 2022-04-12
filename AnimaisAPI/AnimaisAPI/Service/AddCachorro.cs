using AnimaisAPI.Interfaces;
using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class AddCachorro : IAddCachorro
    {
        public static void AddCachorros(Cachorro cachorro)
        {
            StreamWriter writer = File.AppendText(@"C:\Users\Kley\Desktop\LEITURABICHO.txt");
            writer.WriteLine(cachorro.Especie + "|" + cachorro.Raca + "|" + cachorro.Idade);
            writer.Close();
        }   
    }
}
