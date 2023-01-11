namespace GildedRose.Items
{

    public abstract class Item
    {
        public string Name {get; protected set;}
        public int SellIn {get; protected set;}
        public int Quality {get; protected set;}
        public int BasePrice {get; protected set;}
        
        public Item(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
            this.BasePrice = BasePrice;
            
        }

             public abstract void Update();

              public abstract void GetValue();
        
        protected void FloorQualityToZero()
        {
            if(this.Quality < 0)
               this.Quality = 0;
        }
      
        protected void CeilQuality(int quality)
        {
            if(this.Quality < 50)
               this.Quality = 50;
        }

    }
    
}


