using System.Collections.Generic;

namespace Barman
{
    public class Ingredient
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public override string ToString()
        {
            return Name;
        }

        public virtual ICollection<Cocktail> Cocktail { get; set; }
        public Ingredient()
        {
            Cocktail = new List<Cocktail>();
        }
    }
}