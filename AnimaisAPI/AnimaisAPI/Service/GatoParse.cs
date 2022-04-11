using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class GatoParse
    {
        public static Gato? CreateFromLine(string? line)
        {
            int arraySize = 3;
            if (line == null)
                return null;
            String[] array = line.Split("|"); 
            if (array.Length != arraySize) 
                return null;
            if (array[0].ToLower().Trim() != "gato")
                return null;
            if (!float.TryParse(array[2], out float idade))
                return null;
            if (array[1].ToLower().Trim() == null)
                return null;
            var Gato = new Gato(array[1], idade);
            if(!Gato.IsValid())
                return null;
            return Gato;    
        }
    }
}
