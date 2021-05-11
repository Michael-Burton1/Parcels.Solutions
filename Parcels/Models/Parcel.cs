using System;
using System.Collections.Generic;

namespace EpicodusShipping.Models
{
  public class Size
  {
    public double[] Dimensions { get; set; }
    public Size(double x, double y, double z)
    {
      Dimensions = new double[3] { x, y, z };
    }
  }
  public class Parcel : Size
  {
    private static List<Parcel> _instances = new() { };
    public static Dictionary<(string, int), Size> StandardSizes = new()
    {
      { ("Small", 10), new Size(8.63, 5.5, 1.75) },
      { ("Medium", 12), new Size(11.25, 6, 8.75) },
      { ("Large", 15), new Size(12.25, 12.25, 6) },
    };

    public double Weight { get; set; }

    public Parcel(double w, double x, double y, double z)
    : base(x, y, z)
    {
      Weight = w;
      _instances.Add(this);
    }
    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public double Volume()
    {
      return Dimensions[0] * Dimensions[1] * Dimensions[2];
    }
    public (string, int) FindBox()
    {
      Array.Sort(Dimensions);
      foreach (KeyValuePair<(string, int), Size> standardSize in StandardSizes)
      {
        (string boxName, int boxPrice) = standardSize.Key;
        double[] boxDimensions = standardSize.Value.Dimensions;
        Array.Sort(boxDimensions);
        try
        {
          for (int i = 0; i < Dimensions.Length; i++)
          {
            double boxDimension = boxDimensions[i];
            double dimension = Dimensions[i];
            if (dimension > boxDimension) throw new Exception(); // new() = shorthand 
          }
          return (boxName, boxPrice);
        }
        catch (Exception) { continue; }
      }
      return ("Sorry, We don't ship packages of that caliber. Try USPS, UPS or FedEx!", 0);
    }
  }
}


