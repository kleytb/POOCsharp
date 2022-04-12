using System.Text.Json.Serialization;

namespace AnimaisAPI.Models
{
    public class Animal
    {
        public string? Raca { get; set; } 
        public string? Idade { get; set; }        
        [JsonIgnore]
        public string? Especie { get; set; }       
        
    }
    

}
