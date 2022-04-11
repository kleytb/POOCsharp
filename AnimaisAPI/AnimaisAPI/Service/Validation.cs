namespace AnimaisAPI.Service
{
    public class Validation
    {
        public bool VerificarLinha(string pathLine, string[] line)
        {
            int arraySize = 3;
            if (pathLine == null)
                return true;
            if (line.Length != arraySize) 
                return true;
            return false;
        }

        public bool Gato()
        {
            return true;
        }
    }
}
