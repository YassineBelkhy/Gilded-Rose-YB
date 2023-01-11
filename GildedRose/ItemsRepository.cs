using System.Collections.Generic;
using GildedRose.Items;

namespace GildedRose
{
    public class ItemRepository
    {
        private object items;
        string type;
        int quality;

        public IList<Item> Items { get; private set; }

        public ItemRepository(IList<Item> items)
        {
            this.Items = items;
        }

        public void GetInventory()
        {
            foreach (Item item in this.Items)
                items.GetInventory();

        }

        public void SaveInventory(Item[*] items)
        {
            foreach (Item item in this.Items)
                items.SaveInventory();

        }

        public void FindItem(string type, int quality)
        {
                    
            
                this.type = type;
                this.quality = quality;

            }
          
            public override string ToString()
            {
                return "Quality: " + quality + "   item: " + type;
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
                return (this.quality.Equals(other.quality));
            }

        }

    }




}
 

