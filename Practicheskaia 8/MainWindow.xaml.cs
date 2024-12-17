using System.Windows;

namespace Practicheskaia_8
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(tbPerimetrKryga.Text, out int perimetrKrega);
            int.TryParse(tbPloshadKryga.Text, out int ploshadKryga);
            int.TryParse(tbPerimetrPramoygolnika.Text, out int perinmetrPramoegolnika);
            int.TryParse(tbPloshadPramoygolnika.Text, out int ploshadPramoygolnika);
            Pramoygolnik pramoygolnik = new Pramoygolnik(perinmetrPramoegolnika, ploshadPramoygolnika);
            Kryg kryg = new Kryg(perimetrKrega, ploshadKryga);
            string resultSravnenia = "";
            string infoPramoygolnika = pramoygolnik.Information();
            string infoKryga = kryg.Information();
            if (pramoygolnik.CompareTo(kryg) == true) resultSravnenia = "Пложади равны";
            else resultSravnenia = "Площади не равны";
            tbResult.Text = infoPramoygolnika + "\n" + infoKryga + "\n" + resultSravnenia;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа");
        }
    }
}