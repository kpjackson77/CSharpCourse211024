using FlightHandling;

namespace FlightWpf
{
  internal interface IAddWindowBuilderVM
  {
    bool IsOrdinary { get; set; }
    bool IsSilver { get; set; }
    string Name { get; set; }
    int Weight { get; set; }
    PassengerDetails? Build();
  }
}