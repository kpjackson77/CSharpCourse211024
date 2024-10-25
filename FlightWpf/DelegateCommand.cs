using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightWpf
{
  class DelegateCommand : ICommand
  {
    private Action<object>? _act;
    private Predicate<object>? _pred;
    public DelegateCommand(Action<Object>? act,
        Predicate<Object>? pred)
    {
      _act = act;
      _pred = pred;
    }
    public bool CanExecute(object? parameter)
    {
      return _pred(parameter);
    }
    public event EventHandler CanExecuteChanged;
    public void Execute(object? parameter)
    {
      _act(parameter);
    }
  }
}
