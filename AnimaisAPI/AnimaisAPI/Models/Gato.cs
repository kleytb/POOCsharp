namespace AnimaisAPI.Models
{
    public class Gato : Animal
    {
        public Gato(string raca, float idade)
        {
            Raca = raca;
            Idade = idade;
            Especie = "GATO";
        }
        public static bool IsValidCat(float idade, string raca, string especie)
        {
            if (idade > 5)
                return false;
            if (string.IsNullOrEmpty(raca))
                return false;
            if (especie.ToLower().Trim() != "gato")
                return false;
            return true;
        }
    }
}

