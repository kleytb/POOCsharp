namespace AnimaisAPI.Models
{
    public class Cachorro : Animal
    {
        public Cachorro(string raca, float idade)
        {
            Raca = raca;
            Idade = idade;
            Especie = "CACHORRO";
        }
        public bool IsValid()
        {
            if (Idade > 100)
                return false;
            if (string.IsNullOrEmpty(Raca))
                return false;
            return true;
        }

    }
}
