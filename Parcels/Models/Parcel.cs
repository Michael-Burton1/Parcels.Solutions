namespace EpicodusShipping.Models
{
  public class Parcel
  {
    public double[] Dimensions { get; set; }
    public double Weight { get; set; }

    public Parcel(double w, double x, double y, double z)
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
