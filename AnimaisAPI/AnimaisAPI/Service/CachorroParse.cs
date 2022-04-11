using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class CachorroParse
    {
        public static Cachorro? CreateFromLine(string? line)
        {
            int arraySize = 3;
            if(line == null)
                return null;
            String [] array = line.Split("|");
            if(array.Length != arraySize)
                return null;
            if(!(array[0].ToLower().Trim() == "cachorro"))
                return null;
            if (array[1] == null)
                return null;
            if(!float.TryParse(array[2], out float idade))
                return null;

            /*public static Cachorro? IsValid(string? line, Animal animal)
            {
                int arraySize = 3;
                if (line == null)
                    return null;
                String[] array = line.Split("|");
                if (array.Length != arraySize)
                    return null;
                if (!(array[0].ToUpper().Trim() == animal.Especie ))
                    return null;
                if (array[1] == null)
                    return null;
                if (!float.TryParse(array[2], out float idade))
                    return null;
            }*/
            var cachorro = new Cachorro(array[1], idade);
            if(!cachorro.IsValid())
                return null;
            return cachorro;
        }
    }
}
