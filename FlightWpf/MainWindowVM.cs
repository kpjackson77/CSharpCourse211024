using FlightHandling;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightWpf
{
  class MainWindowVM
  {
    ObservableCollection<PassengerDetails> _passengers = new ObservableCollection<PassengerDetails>();

    public ObservableCollection<PassengerDetails> Passengers { get { return _passengers; } }

    public ICommand AddPassengerCommand { get; set; }
    public ICommand DeletePassengerCommand { get; set; }
    public MainWindowVM()
    {
      AddPassengerCommand = new DelegateCommand(AddPassengerAction, (param) => true);
      DeletePassengerCommand = new DelegateCommand(DeletePassengerAction, (param) => true);
    }
    void DeletePassengerAction(object? param)
    {
      var pd = param as PassengerDetails;
      if (pd != null)
      {
        _passengers.Remove(pd);
      }
    }
    void AddPassengerAction(object param)
    {
      AddWindow ad = new AddWindow();
      IAddWindowBuilderVM builder = new PassengerDetailsBuilder();
      ad.DataContext = builder;

      if (ad.ShowDialog() ?? false)
      {
        var pd = builder.Build();
        if (pd != null)
        {
          _passengers.Add(pd);
        }
      }
    }
  }
}
