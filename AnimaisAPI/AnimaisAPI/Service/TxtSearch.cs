namespace AnimaisAPI.Service
{
    public class TxtSearch
    {
        public static String[] Search()
        {
            var allLines = File.ReadAllLines(@"C:\Users\Kley\Desktop\LEITURABICHO.txt");
            return allLines;
        }
    }
}
