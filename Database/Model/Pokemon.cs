using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    public class Pokemon
    {
        /// <summary>
        /// Pokedex id (national dex)
        /// </summary>
        [JsonPropertyName("id")]
        public int ID { get; set; }

        /// <summary>
        /// name of the pokemon
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// base expirience grandet for defeating
        /// </summary>
        [JsonPropertyName("base_expiriance")]
        public int Base_expiriance { get; set; }

        /// <summary>
        /// pokemon's height
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// weight of the pokemon in hectrograms
        /// </summary>
        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Set for exactly pokemon used as the default for each species
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool Is_defult { get; set; }

        /// <summary>
        /// order for sorting. Almost national, except families age grouped together
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }

        /// <summary>
        /// a list of abilities this pokemon could potentially have
        /// </summary>
        [JsonPropertyName("abilities")]
        public List<PokemonAbility> Abilities { get; set; }

        /// <summary>
        /// list of forms this pokemon can take on
        /// </summary>
        [JsonPropertyName("forms")]
        public List<NamedAPIResource> Forms { get; set; }

        /// <summary>
        /// a list of game indeces relevant to pokemon item by generation
        /// </summary>
        [JsonPropertyName("game_indices")]
        public List<VersionGameIndex> Game_indices { get; set; }

        /// <summary>
        /// a list of items pokemon may be holding when encountered
        /// </summary>
        [JsonPropertyName("held_items")]
        public List<PokemonHeldItem> Held_items { get; set; }

        /// <summary>
        /// a link to a list of areas, as well as encounter details partaining to specific version
        /// </summary>
        [JsonPropertyName("location_area_encounters")]
        public string Location_area_encounters { get; set; }

        /// <summary>
        /// a list of pokemon moves
        /// </summary>
        [JsonPropertyName("moves")]
        public List<PokemonMove> Moves { get; set; }

        /// <summary>
        /// a set of spirites used this pokemon in the game
        /// </summary>
        [JsonPropertyName("spirites")]
        public PokemonSpirites Spirites { get; set; }

        /// <summary>
        /// the species this pokemon belongs to
        /// </summary>
        [JsonPropertyName("species")]
        public NamedAPIResource Species { get; set; }

        /// <summary>
        /// A list of base stat values for this pokemon
        /// </summary>
        [JsonPropertyName("Stats")]
        public List<PokemonStat> Stats { get; set; }

        /// <summary>
        /// The types that the pokemon belongs to
        /// </summary>
        [JsonPropertyName("types")]
        public List<PokemonType> Types { get; set; }


    }
}



//public int id { get; set; }
//public string name { get; set; }
//public List<ability> abilities { get; set; }
//public int evolution { get; set; }
//public DateTime condition { get; set; }
