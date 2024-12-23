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

namespace Raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int correctNumber;
        int attempt = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            numberTextBox.Clear();
            guessTextBox.Clear();
            attemptTextBox.Clear();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int guess = int.Parse(numberTextBox.Text);
            if(guess == correctNumber)
            {
                guessTextBox.Text = "gefeliciteerd! je hebt het number correct geraaden!";
                attemptTextBox.Text = $"aantal pogingen: {attempt}";
            }
            else if(guess < correctNumber)
            {
                guessTextBox.Text = "raad hoger!";
                attemptTextBox.Text = $"aantal pogingen: {attempt}";
                attempt++;
            }
            else if(guess > correctNumber)
            {
                guessTextBox.Text = "raad lager!";
                attemptTextBox.Text = $"aantal pogingen: {attempt}";
                attempt++;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Random number = new Random();
            correctNumber = number.Next(1, 101);
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            timeLabel.Content = currentTime.ToLongDateString() + " - " + currentTime.ToShortTimeString();
        }
    }
}