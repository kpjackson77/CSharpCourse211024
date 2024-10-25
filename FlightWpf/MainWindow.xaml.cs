using FlightHandling;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlightWpf
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
  ObservableCollection<PassengerDetails> _passengers = new ObservableCollection<PassengerDetails>();
    public MainWindow()
    {
      InitializeComponent();
      PassengersList.ItemsSource = _passengers;
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
      AddWindow ad = new AddWindow();
      IAddWindowBuilderVM builder = new PassengerDetailsBuilder();
      ad.DataContext = builder;
      ad.Owner = this;
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