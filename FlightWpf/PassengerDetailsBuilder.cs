using FlightHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightWpf
{
  enum PassengerType { Ordinary, Silver };
  class PassengerDetailsBuilder : IAddWindowBuilderVM
  {
    PassengerType pt = PassengerType.Ordinary;
    public string Name { get; set; }
    public int Weight { get; set; }
    public bool IsOrdinary
    {
      get { return pt == PassengerType.Ordinary; }
      set
      {
        if (value)
        {
          pt = PassengerType.Ordinary;
        }
      }
    }
    public bool IsSilver
    {
      get { return pt == PassengerType.Silver; }
      set
      {
        if (value)
        {
          pt = PassengerType.Silver;
        }
      }
    }
    public PassengerDetails? Build()
    {
      PassengerDetails? pd = null;

      switch (pt)
      {
        case PassengerType.Ordinary:
          pd = new PassengerDetails(Name, Weight);
          break;
        case PassengerType.Silver:
          pd = new SilverPassengerDetails(Name, Weight);
          break;
      }
      return pd;
    }
  }
}
