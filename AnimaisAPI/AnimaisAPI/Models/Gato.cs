namespace AnimaisAPI.Models
{
    public class Gato : Animal
    {
        public Gato(string raca, float idade)
        {
            Raca = raca;
            Idade = idade;
        }
        public bool Valido()
        {
            if (Idade > 5)
                return false;
            if (string.IsNullOrEmpty(Raca))
                return false;
            return true;
        }
    }

}

