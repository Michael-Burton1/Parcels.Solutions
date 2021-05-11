using System.Collections.Generic;

namespace EpicodusShipping.Models
{
  public class Size
  {
    public double[] Dimensions { get; set; }
    public Size(double x, double y, double z)
    {
      Dimensions = new double[3];
      Dimensions[0] = x;
      Dimensions[1] = y;
      Dimensions[2] = z;
    }
  }
  public class Parcel : Size
  {
    public static Dictionary<string, Size> StandardSizes = new()
    {
      { "Small", new Size(8.63, 5.5, 1.75) },
      { "Medium", new Size(11.25, 6, 8.75) },
      { "Large", new Size(12.25, 12.25, 6) },
    };

    public double Weight { get; set; }

    public Parcel(double w, double x, double y, double z)
    : base(x, y, z)
    {
      Weight = w;

      Dimensions = new double[3];
      Dimensions[0] = x;
      Dimensions[1] = y;
      Dimensions[2] = z;
    }
    public double Volume()
    {
      return Dimensions[0] * Dimensions[1] * Dimensions[2];
    }
  }
}

// class Size {
//   constructor(whatever) {
//     this.whatever = whatever
//   }
// }
// class Parcel extends Size {
//   constructor(whatever, whateverElse) {
//     super(whatever)
//     this.whateverElse = whateverElse
//   }
// }
