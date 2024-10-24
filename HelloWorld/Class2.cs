using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  internal class Class2
  {
    private int _val;
    private int _val2;

    public Class2()
    {
      throw new System.NotImplementedException();
    }

    public int Val
    {
      get => _val;
      set
      {
      _val = value;
      }
    }

    public void DoWork(string msg)
    {
      throw new System.NotImplementedException();
    }
    public void Output(){ }
  }
}
