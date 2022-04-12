using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class CachorroParse
    {
        public static Cachorro? CreateFromLine(string? line)
        {
            var array = ArrayValidation.IsArrayValid(line);
            if (array != null)
            {
                var isValidDog = Cachorro.IsValidDog(float.Parse(array[2]), array[1], array[0]);
                if(!isValidDog)
                    return null;
                var cachorro = new Cachorro(array[1], array[2]);
                return cachorro;
            }
            return null;
        }
    }
}
