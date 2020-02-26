using System;
using System.Collections.Generic;

namespace Dealership.Models
{
  
  public class Car
  
  {
    private static List<Car> Cars = new List<Car>(){};

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

    /////////////////////////////////////////////////////////
    /////////////// CAR LIST Get : Set //////////////////////
    public static void addCarToList(Car auto)
    {
      Cars.Add(auto);
    }

    public static List<Car> GetCarList()
    {
      return Cars;
    }

    //////////////////////////////////////////////////////////
    //////////////  CAR OBJECT Get : Set /////////////////////

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