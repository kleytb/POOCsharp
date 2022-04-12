namespace AnimaisAPI.Service
{
    public class ArrayValidation
    {
        public static String[]? IsArrayValid(string? line)
        {
            int arraySize = 3;
            if (line == null)
                return null;
            String[] array = line.Split("|");
            if (array.Length != arraySize)
                return null;
            if (array[1] == null)
                return null;
            if (!float.TryParse(array[2], out float idade))
                return null;
            return array;
        }
    }
}
