using PokeGen;

namespace PokeGen
{
    public class PokemonSpecies
    {
        public List<NameUrl> results { get; set; }
    }

    // For simplicity
    public class NameUrl
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
