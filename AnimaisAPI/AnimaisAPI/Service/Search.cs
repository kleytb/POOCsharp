using System.Data;
using System.Data.SqlClient;

namespace AnimaisAPI.Service

{
    public class Search
    {
        public static String[] txtSearch()
        {
            var allLines = File.ReadAllLines(@"C:\Users\gabri\Documents\LEITURABICHO.txt");
            return allLines;

        }
    }
}
