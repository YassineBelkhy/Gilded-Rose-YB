using System;

namespace GildedRose.Items
{
    public class AgingItem : Item
    { 
        public AgingItem(string name , int sellIn, int quality) 
        : base(name, sellIn, quality)
        { }

        public override void Update()
        {
            this.UpdateSellIn();
            this.UpdateQuality();
            
        }

        private void UpdateSellIn()
        {
            this.SellIn--;
             
            if (this.SellIn < 0)
                this.Quality--;
        }

        private void UpdateQuality()
        {
            this.Quality++;

            FloorQualityToZero();
            CeilQualityToFifty();
        }

        private void CeilQualityToFifty()
        {
            throw new NotImplementedException();
        }

        public override void GetValue()
        {
            throw new NotImplementedException();
        }
    }
}