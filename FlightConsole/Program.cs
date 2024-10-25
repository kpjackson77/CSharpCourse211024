using FlightHandling;
using System.Threading.Channels;

namespace FlightConsole
{
  class SomeData : DiagnosticCount<SomeData> { }
  internal class Program
  {
    static void Main(string[] args)
    {
      {
        SomeData sd = new SomeData();
        SomeData sd2 = new SomeData();
      }
      {
        const int MAXPASSENGERS = 4;

        PassengerDetails pd = null;// new PassengerDetails();
        int cnt = 0;
        //PassengerDetails[] details = new PassengerDetails[MAXPASSENGERS];
        List<PassengerDetails> details = new List<PassengerDetails>();


        bool exit = false;
        do
        {
          Console.WriteLine("i - input, s - silver, o - output, a - output all, x = exit\nPlease enter an option:");
          string opt = Console.ReadLine();

          switch (opt)
          {
            case "i":
              {
                try
                {
                  pd = new PassengerDetails();
                  pd.Input();

                  details.Add(pd);
                  cnt++;
                }
                catch (Exception ex) when (LogIt(ex))
                {
                  Console.WriteLine("Could be any exception!!!");
                }
                catch (FormatException fe)
                {
                  Console.WriteLine("Invalid entry, please try again!");
                }

              }
              break;
            case "s":
              {
                pd = new SilverPassengerDetails();
                pd.Input();

                details.Add(pd);
                cnt++;
              }
              break;
            case "o":
              //OutputPassengerDetails(name, weight);
              //if (pd != null)
              //{
              pd?.Output();
              //}
              break;
            case "a":
              details.Sort(new PassengerDetails.CompareByWeight());
              foreach (var item in details)
              {
                item.Output();
              }
              break;
            case "x":
              exit = true;
              break;
            case "f":
              string? nameToFind;
              Console.WriteLine("Please enter a name to find:");
              nameToFind = Console.ReadLine();
              if (nameToFind != null)
              {
                details.ForEach(p =>
                {
                  if (p.Name == nameToFind)
                  {
                    Console.WriteLine(p.ToString());
                  }
                });
                //var found = from p in details where p.Name == nameToFind select p;

                //foreach (var item in found)
                //{
                //  Console.WriteLine(item);
                //}
                //var found = details.FirstOrDefault(p => p.Name == nameToFind);
                //if (found != null)
                //{
                //  Console.WriteLine("Found:");
                //  found.Output();
                //}
                //else
                //{
                //  Console.WriteLine("Not found!");
                //}
                //  details.Sort();
                //  int ind = details.BinarySearch(new PassengerDetails(nameToFind, 0));
                //  if (ind == -1)
                //  {
                //    Console.WriteLine("Not found!");
                //  }
                //  else
                //  {
                //    Console.WriteLine("Found:");
                //    details[ind].Output();
                //  }
              }
              break;
          }
        } while (!exit);
      }
      Console.WriteLine("Hello, World!");
    }
    private static bool LogIt(Exception ex)
    {
      Console.WriteLine($"Problem: {ex.Message}");
      return false;
    }

    //private static void OutputPassengerDetails(string name, int weight)
    //{
    //  Console.WriteLine($"Name: {name}, baggage weight: {weight}");
    //}

    //private static void InputPassengerDetails(out string name, out int weight)
    //{
    //  Console.WriteLine("Please enter a name:");
    //  name = Console.ReadLine();
    //  Console.WriteLine("Please enter baggage weight:");
    //  weight = int.Parse(Console.ReadLine());
    //}
  }
}
