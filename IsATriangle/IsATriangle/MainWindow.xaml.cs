using System.Windows;

namespace IsATriangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            if (int.TryParse(FirstSideTb.Text, out a) && 
                int.TryParse(SecondSideTb.Text, out b) &&
                int.TryParse(ThirdSideTb.Text, out c))
            {
                Output.Text = IsTriangle.IsATiangle(a, b, c).ToString();
            }
            else
            {
                Output.Text = "The given input is not a number.";
            }
        }
    }
}
