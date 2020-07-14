using System.Collections.Generic;

namespace Barman
{
    public class Cocktail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Time { get; set; }
        public virtual ICollection<Ingredient> Ingredient { get; set; }
        public Cocktail()
        {
            Ingredient = new List<Ingredient>();
        }
    }
}