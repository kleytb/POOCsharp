using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class GatoParse
    {
        public static Gato? CreateFromLine(string? line)
        {
            var array = ArrayValidation.IsArrayValid(line);
            if (array != null)
            {
                var isValidCat = Gato.IsValidCat(float.Parse(array[2]), array[1], array[0]);
                if(!isValidCat)
                    return null;
                var gato = new Gato(array[1], array[2]);
                return gato;
            }
            return null;
        }
    }
}
