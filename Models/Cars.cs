using System;

namespace Dealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _info;

    //New constructor code below.
    public Car(string makeModel, int price, int miles, string info)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _info = info;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public int GetPrice()
    {
      return _price;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public string GetInfo()
    {
      return _info;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
    public bool LowMileage(int maxMileage)
    {
      return (_miles < maxMileage);
    }
  }
}