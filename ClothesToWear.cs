using System;

class ClothesToWear
{
  static void Main()
  {
    Console.WriteLine("What is the current temperature?");
    string stringTemp = Console.ReadLine();
    int temp = int.Parse(stringTemp);

    bool dangerHotTemp = temp < 150 && temp >= 95;
    bool hotTemp = temp < 95 && temp >= 85;
    bool medTemp = temp < 85 && temp >= 75;
    bool coldTemp = temp < 75 && temp >= 65;
    bool dangerColdTemp = temp < 65 && temp >= 0;

    if (dangerColdTemp || dangerHotTemp)
    {
      Console.WriteLine("WARNING!!!!!! You should not go outside at all today!!!!!");
    }
    else if (hotTemp || medTemp)
    {
      Console.WriteLine("It will be a bit warm. You can wear anything you feel comfortable in.");
    }
    else if (coldTemp)
    {
      Console.WriteLine("It will be cold. You may need a jacket.");
    }
  }
}
