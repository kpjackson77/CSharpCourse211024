using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightHandling
{
  public class SilverPassengerDetails : PassengerDetails
  {
    public SilverPassengerDetails(string name, int weight) : base(name, weight) { }
    public SilverPassengerDetails() : base(string.Empty, 0) { }

    public override void Input()
    {
      Console.WriteLine("Silver Club Passenger: ");
      base.Input();
    }
    public override void Output()
    {
      Console.WriteLine("Silver Club Passenger: ");
      base.Output();
    }
  }
}
