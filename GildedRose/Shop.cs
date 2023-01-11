using System.Collections.Generic;
using GildedRose.Items;

namespace GildedRose
{
    public class Shop
    {
        private object items;
        string type;
        int quality;

        public IList<Item> Items {get; private set;}

        public Shop(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in this.Items)
            items.Update();
            
        }

     public void SellItem(string type, int quality)
        {
                    
            
                this.type = type;
                this.quality = quality;

            }

        public override string ToString()
        {
            return "Quality: " + quality + "   Type: " + type;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Item objAsitem = obj as Item;
            if (objAsitem == null) return false;
            else return Equals(objAsitem);
        }
        public override int GetHashCode()
        {
            return quality;
        }
        public bool Equals(Item other)
        {
            if (other == null) return false;
            return (this.quality.Equals(other.Quality));
        }
 
    }

    }
    
}

