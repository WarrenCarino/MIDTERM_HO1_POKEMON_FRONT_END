namespace Pokemonbackend_Web
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string? Summary { get; set; }
    }

    public class Pokemontoh
    {
        public string? Name { get; set; }
        public string? Imageurl { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public string? Type { get; set; }
    }

    public static class PokemonRepository
    {
        private static readonly List<Pokemontoh> PokemonList;

        static PokemonRepository()
        {
            PokemonList = new List<Pokemontoh>
            {
                new Pokemontoh
                {
                    Name = "Charizard",
                    Imageurl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fcharacterprofile.fandom.com%2Fwiki%2FCharizard&psig=AOvVaw3Bjf2eEp5vL7PH76O14e7P&ust=1742109793797000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCJiU9-3Gi4wDFQAAAAAdAAAAABAJ",
                    Height = 1.7f,
                    Weight = 90.5f,
                    Type = "Fire/Flying"
                }
            };
        }

        public static List<Pokemontoh> GetAllPokemons()
        {
            return PokemonList;
        }

        public static void AddPokemon(Pokemontoh pokemon)
        {
            PokemonList.Add(pokemon);
        }
    }
}
