using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightHandling
{
  public abstract class DiagnosticCount<SomeType>
  {
    static int _count = 0;
    readonly int _index;
    protected DiagnosticCount()
    {
      _index = ++_count;
      Console.WriteLine($"Creating object no: {_index}");
    }
  }
}
