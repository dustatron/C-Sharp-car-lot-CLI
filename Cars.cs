using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public string Info;

  //New constructor code below.
  public Car(string makeModel, int price, int miles, string info)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Info = info;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Price < maxPrice);
  }

  public bool LowMileage(int maxMileage)
  {
    return (Miles < maxMileage);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "Looks bad but runs great.");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "One owner and well maintained.");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Used as a taxi for a group of hobbits.");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "Was enchanted by a mystical wizard. May be able to fly.");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.Write("{0,25:N7}","Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.Write("{0,25:N7}","Enter a maximum mileage: ");
    string stringMaxMileage = Console.ReadLine();
    int maxMileage = int.Parse(stringMaxMileage);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice) && automobile.LowMileage(maxMileage))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("No cars matched your search.");
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine();
      Console.WriteLine(automobile.MakeModel);
      Console.WriteLine("Price : $"+automobile.Price);
      Console.WriteLine("Miles: "+automobile.Miles);
      Console.WriteLine("Details: "+automobile.Info);
      Console.WriteLine();
    }
  }
}