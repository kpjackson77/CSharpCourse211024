using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightHandling
{
  public class PassengerDetails : DiagnosticCount<PassengerDetails>, IComparable<PassengerDetails>, IEquatable<PassengerDetails>
  {
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [Range(0, 30)]
    public int Weight { get; set; }

    public PassengerDetails(string name, int weight)
    {
      Name = name;
      Weight = weight;
    }
    public PassengerDetails()
    {
    }
    public virtual void Output()
    {
      Console.WriteLine($"Name: {this.Name}, baggage weight: {this.Weight}");
    }
    public virtual void Input()
    {
      Console.WriteLine("Please enter a name:");
      this.Name = Console.ReadLine();
      //bool ok = false;
      //do
      //{
      Console.WriteLine("Please enter baggage weight:");
      //  try
      //  {
      this.Weight = int.Parse(Console.ReadLine());
      //    ok = true;
      //  }
      //  catch (FormatException fe)
      //  {
      //    Console.WriteLine("Invalid entry, please try again!");
      //    ok = false;
      //  }
      //} while (!ok);
    }
    public override int GetHashCode()
    {
      return Name.GetHashCode() + Weight.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
      if (obj == null) return false;
      PassengerDetails? pd = obj as PassengerDetails;
      if (pd == null) return false;
      return this.Name.Equals(pd.Name) && this.Weight == pd.Weight;
    }
    public bool Equals(PassengerDetails? other)
    {
      if (other == null) return false;
      return this.Name.Equals(other.Name) && this.Weight == other.Weight;
    }
    public override string ToString()
    {
      return $"Name: {Name}, baggage weight: {Weight}";
    }
    public int CompareTo(PassengerDetails? other)
    {
      return this.Name.CompareTo(other?.Name);
    }



    public class CompareByWeightReverse : IComparer<PassengerDetails>
    {
      int IComparer<PassengerDetails>.Compare(PassengerDetails? x, PassengerDetails? y)
      {
        if (x == null || y == null) throw new NullReferenceException("Something wrong!");

        return y.Weight - x.Weight;
      }
    }
    public class CompareByWeight : IComparer<PassengerDetails>
    {
      int IComparer<PassengerDetails>.Compare(PassengerDetails? x, PassengerDetails? y)
      {
        if (x == null || y == null) throw new NullReferenceException("Something wrong!");

        return x.Weight - y.Weight;
      }
    }
  }
}
