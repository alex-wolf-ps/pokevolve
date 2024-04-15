namespace PokeGen
{
    public class PokemonDetails
    {
        public PokemonSprites sprites { get; set;  }
        public string imageUrl { get; set; }
        public string name { get; set; }
        public bool loading { get; set; }
    }

    public class PokemonSprites
    {
        public string front_default { get; set; }
    }
}
