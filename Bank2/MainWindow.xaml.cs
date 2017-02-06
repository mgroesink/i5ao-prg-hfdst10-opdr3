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

namespace Bank2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BankAccount b = new BankAccount();
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            b = new BankAccount(0);
            UpdateBalance();
        }

        /// <summary>
        /// Updates the balance.
        /// </summary>
        private void UpdateBalance()
        {
            this.Title = "Huidig saldo: " + b.CurrentBalance.ToString("C");
        }

        /// <summary>
        /// Handles the Click event of the button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double money = 0;
                if(!double.TryParse(textBox.Text , out money))
                {
                    MessageBox.Show("Ongeldig bedrag (alleen cijfers zijn toegestaan)");
                    return;
                }
                if (money > 0)
                {
                    b.Deposit(money);
                }
                else
                {
                    b.WithDraw(Math.Abs(money));
                }
                UpdateBalance();

            }
            catch(BalanceTooLowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
