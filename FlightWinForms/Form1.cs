using FlightHandling;

namespace FlightWinForms
{
  public partial class Form1 : Form
  {
    public List<PassengerDetails> Passengers { get; set; }
    public Form1()
    {
      InitializeComponent();
      Passengers = new List<PassengerDetails>();
      Passengers.Add(new PassengerDetails("Fred", 23));
      Passengers.Add(new PassengerDetails("Jim", 12));
      Passengers.Add(new PassengerDetails("Alice", 32));
      Passengers.Add(new PassengerDetails("Graham", 9));
    }
    private async void button1_Click(object sender, EventArgs e)
    {
      using (StreamWriter sw = new StreamWriter("D:/Temp/passengers.txt"))
      {
        foreach (var item in Passengers)
        {
          await sw.WriteLineAsync(item.ToString());
        }
      }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      listBox1.DataSource = Passengers;
    }
  }
}
