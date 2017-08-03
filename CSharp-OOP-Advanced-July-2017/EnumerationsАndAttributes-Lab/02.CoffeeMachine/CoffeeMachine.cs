using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private List<CoffeeType> coffeesSold;

    public CoffeeMachine()
    {
        this.CoffeesSold = new List<CoffeeType>();
    }

    public List<CoffeeType> CoffeesSold
    {
        get { return this.coffeesSold; }
        private set { this.coffeesSold = value; }
    }

    
    public int TotalCoinValue { get; private set; }

    public void BuyCoffee(string size, string type)
    {
        CoffeePrice coffeePrice;
        CoffeeType coffeeType;
        
        if (Enum.TryParse(size, out coffeePrice) && Enum.TryParse(type, out coffeeType))
        {
            if (this.TotalCoinValue >= (int)coffeePrice)
            {
                this.AddSoldCoffee(coffeeType);
                this.TotalCoinValue = 0;
            }
        }
    }

    private void AddSoldCoffee(CoffeeType coffeeType)
    {
        this.CoffeesSold.Add(coffeeType);
    }

    public void InsertCoin(string coin)
    {
        Coin coinValue;

        if (Enum.TryParse(coin, out coinValue))
        {
            this.TotalCoinValue += (int)coinValue;
        }
    }

}
