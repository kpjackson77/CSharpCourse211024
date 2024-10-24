using static System.Console;

namespace HelloWorld2
{
  interface IMyInterface
  {
    int Value();
  }

  enum Number { One, Two, Three, Four };
  class SomeData : IEquatable<SomeData>, IMyInterface
  {
    public int SomeValue { get; set; }
    public override int GetHashCode()
    {
      return SomeValue;
    }
    public override bool Equals(object? obj)
    {
      if (obj == null) return false;
      SomeData? sd = obj as SomeData;

      if (sd == null) return false;
      return this.SomeValue == sd.SomeValue;
    }
    public bool Equals(SomeData? other)
    {
      if (other == null) return false;
      return this.SomeValue == other.SomeValue;
    }

    public int Value()
    {
      return SomeValue;
    }
  }
  internal class Program
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      {
        List<IMyInterface> data = new List<IMyInterface>();

        data.Add(new SomeData { SomeValue = 1 });

        Console.WriteLine(data[0].Value());
      }
      {
        Dictionary<int, int> data = new Dictionary<int, int>();

        data.Add(1, 1);
        data.Add(2, 2);
        data.Add(3, 3);

        Console.WriteLine($"Value: {data[2]}");

        foreach (var item in data)
        {
          Console.WriteLine($"Key: {item}, value: {item.Value}");
        }
      }
      {
        Dictionary<SomeData, int> data = new Dictionary<SomeData, int>();

        data.Add(new SomeData { SomeValue = 1 }, 1);
        data.Add(new SomeData { SomeValue = 2 }, 2);
        data.Add(new SomeData { SomeValue = 3 }, 3);

        Console.WriteLine($"Value: {data[new SomeData() { SomeValue = 2 }]}");

        foreach (var item in data)
        {
          Console.WriteLine($"Key: {item.Key.SomeValue}, value: {item.Value}");
        }
      }
      {
        double n1 = 35.43, n2 = 5.4;

        double result = Utils.Max(n1, n2);

        Console.WriteLine($"Result: {result}!");
      }
      {
        int n1 = 3543, n2 = 4;

        int result = Utils.Max(n1, n2);

        Console.WriteLine($"Result: {result}!");
      }

      {
        //int n;
        //int a = 23;

        //if (a < 10)
        //{
        //  Console.WriteLine(n);
        //}
      }

      {
        long m = long.MaxValue;

        //checked
        //{
        //  long result = m + m;

        //  Console.WriteLine($"Result: {result}");
        //}
      }
      {
        DateTime dt = DateTime.Now;

        Console.WriteLine(dt.ToLongDateString());
        Console.WriteLine(dt.ToShortDateString());
      }


      {
        Number number = Number.One;

        switch (number)
        {
          case Number.One:
            break;
          case Number.Two:
            break;
          case Number.Three:
            break;
          case Number.Four:
            break;
          default:
            break;
        }
        {
          string? msg = null;

          //int len = msg!.Length;
        }
        {
          WriteLine("Hello, World!");
          Console.WriteLine("Hello");

          DoOutput("Hello", 4);
          string msg2;
          {
            string msg = new string("Greetings");
            int n;
            System.Int32 m = 4;
            msg2 = msg;
          }
          //n = m;
          DoOutput(msg2, 7);

          Console.WriteLine(7.ToString());

          Console.WriteLine(double.MinValue);
          Console.WriteLine(double.MaxValue);
          string normal = "\nHello\nthere!!";
          Console.WriteLine(normal);
          string verbatim = @"\nHello\nthere!!";
          Console.WriteLine(verbatim);
          {
            long l = 2343543;

            int val = (int)l;
          }
          {
            int n = 234;

            object obj = n;

            Console.WriteLine(obj.ToString());
          }
        }
      }
      /// <summary>
      /// Just some output!
      /// </summary>
      /// <param name="msg">Message</param>
      /// <param name="val">A value</param>
      static void DoOutput(string msg, int val)
      {
        Console.WriteLine($"Message: {msg}, value: {val}");
      }
    }
  }
}
