﻿using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class CreateCachorro
    {
        public static Cachorro Create(Cachorro cachorro)
        {
            StreamWriter writer = File.AppendText(@"C:\Users\Kley\Desktop\LEITURABICHO.txt");
            writer.WriteLine(cachorro.Especie + "|" + cachorro.Raca + "|" + cachorro.Idade);
            writer.Close();
            return cachorro;
        }   
    }
}
