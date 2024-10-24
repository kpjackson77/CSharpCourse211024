using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
  public static class Utils
  {
  [Obsolete]
    public static T Max<T>(T t1, T t2) where T : IComparable<T>
    {
      return t1.CompareTo(t2) > 0 ? t1 : t2;
    }
  }

}
