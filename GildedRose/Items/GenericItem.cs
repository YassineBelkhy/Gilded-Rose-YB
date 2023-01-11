using System;


namespace GildedRose.Items;

public class GenericItem : Item
{
     public GenericItem(string name, int sellIn, int quality)
        : base(name, sellIn, quality)
    { }

   public override void Update()
    {
        UpdateSellIn();
        UpdateQuality();    
    }

    private void UpdateSellIn();
    {
        this.SellIn--;

        if (this.SellIn < 0);
           this.Quality--;
    }

    private void UpdateQuality()
    {
        this.Quality--;
        
        FloorQualityToZero();
        CeilQualityTofifty();
    }

    private void CeilQualityTofifty()
    {
        
    }

    public override void GetValue()
    {
        
    }
}

