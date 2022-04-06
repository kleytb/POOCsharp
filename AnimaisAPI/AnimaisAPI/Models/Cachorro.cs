namespace AnimaisAPI.Models
{
    public class Cachorro : Animal
    {
        public Cachorro(string raca, float idade)
        {
            Raca = raca;
            Idade = idade;
        }
        public bool Valido()
        {
            if (Idade > 100)
                return false;
            if (string.IsNullOrEmpty(Raca))
                return false;
            return true;
        }

    }
}
