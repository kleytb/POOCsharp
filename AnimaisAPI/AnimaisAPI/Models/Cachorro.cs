namespace AnimaisAPI.Models
{
    public class Cachorro : Animal
    {
        public Cachorro(string raca, string idade)
        {
            Raca = raca;
            Idade = idade;
            Especie = "CACHORRO";
        }
        public static bool IsValidDog(float idade, string raca, string especie)
        {
            if (idade > 100)
                return false;
            if (string.IsNullOrEmpty(raca))
                return false;
            if(especie.ToLower().Trim() != "cachorro")
                return false;
            return true;
        }
    }
}
