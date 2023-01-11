namespace GildedRose.Items
{
    public class ConjuredItem : Item
    { 
        public ConjuredItem(string name , int sellIn, int quality) 
        : base(name, sellIn, quality)
        { }

        public override void GetValue()
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {
            this.UpdateQuality();
            
        }

        private void UpdateQuality()
        {
            this.Quality--;
             
            
        
    } 
    }
}