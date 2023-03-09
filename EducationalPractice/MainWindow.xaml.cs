using System;
using System.Windows;

namespace EducationalPractice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int result = Calculation();
            MessageBox.Show($"Test result: {result}");
        }

        public int Calculation()
        {
            return WSUniversalLib.Calculation.GetQuantityForProduct(
                Int32.Parse(tbProductType.Text),
                Int32.Parse(tbMaterialType.Text),
                Int32.Parse(tbCount.Text),
                Int32.Parse(tbWidht.Text),
                Int32.Parse(tbLength.Text)
                );
        }
    }
}
