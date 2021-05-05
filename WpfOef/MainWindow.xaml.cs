using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfOef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Persoon> personen = new List<Persoon>();
        public MainWindow()
        {
            InitializeComponent();
            personen.Add(new Persoon() { VoorNaam = "Aiii", Achternaam = "Lmao" });
            personen.Add(new Persoon() { VoorNaam = "AiiiAiii", Achternaam = "Lmao" });
            personen.Add(new Persoon() { VoorNaam = "AiiiAiiiAiii", Achternaam = "Lmao" });
            personen.Add(new Persoon() { VoorNaam = "AiiiAiiiAiiiAiii", Achternaam = "Lmao" });
        }

        private void btnKnop_ClickGetIndex(object sender, RoutedEventArgs e)
        {
            int index = Convert.ToInt32(tbIndex.Text);
            MessageBox.Show($"{personen[index]}");
        }

        private void btnKnop_ClickAddPersoon(object sender, RoutedEventArgs e)
        {
            personen.Add(new Persoon() { VoorNaam = tbVoornaam.Text, Achternaam = tbAchternaam.Text });
        }
        /*
private void Button_Click(object sender, RoutedEventArgs e)
{
MessageBox.Show("Hello world");
}

private void Button_ClickInhoud(object sender, RoutedEventArgs e)
{
//MessageBox.Show(btnTest.Content.ToString());
}

private void btnKnop_Click(object sender, RoutedEventArgs e)
{
int first = Convert.ToInt32(tbFirstNumber.Text);
int second = Convert.ToInt32(tbSecondNumber.Text);

MessageBox.Show($"{first} + {second} = {first + second}");
}

private void btnKnop_Clickaf(object sender, RoutedEventArgs e)
{
int first = Convert.ToInt32(tbFirstNumber.Text);
int second = Convert.ToInt32(tbSecondNumber.Text);

MessageBox.Show($"{first} + {second} = {first - second}");
}

private void btnKnop_Clickmaal(object sender, RoutedEventArgs e)
{
int first = Convert.ToInt32(tbFirstNumber.Text);
int second = Convert.ToInt32(tbSecondNumber.Text);

MessageBox.Show($"{first} + {second} = {first * second}");
}

private void btnKnop_Clickplus(object sender, RoutedEventArgs e)
{
int first = Convert.ToInt32(tbFirstNumber.Text);
int second = Convert.ToInt32(tbSecondNumber.Text);

MessageBox.Show($"{first} + {second} = {first + second}");
}

private void btnKnop_Clickdelen(object sender, RoutedEventArgs e)
{
double first = Convert.ToInt32(tbFirstNumber.Text);
double second = Convert.ToInt32(tbSecondNumber.Text);

MessageBox.Show($"{first} + {second} = {first / second}");
}
*/
    }
}
