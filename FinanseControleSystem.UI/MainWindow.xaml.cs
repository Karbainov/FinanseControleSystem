using FinanseControleSystem.Logic;
using FinanseControleSystem.Logic.Models;
using System.Windows;
using System.Windows.Controls;

namespace FinanseControleSystem.UI
{
    public partial class MainWindow : Window
    {
        private AccountClient _accountClient;

        public MainWindow()
        {
            InitializeComponent();
            _accountClient = new AccountClient();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AccountModel accountModel = new AccountModel()
            {
                Name=TextBoxName.Text,
                Type=TextBoxType.Text,
                Balance=Convert.ToDecimal(TextBoxMoneyAmount.Text)
            };
            _accountClient.AddAccount(accountModel);

            TextBoxName.Text = "";
            TextBoxType.Text = "";
            TextBoxMoneyAmount.Text = "";

            //ListBoxAcount.Items.Clear();
            //List<string> accounts = _accountClient.GetAllAccountsAsString();
            //foreach (string account in accounts)
            //{
            //    Label l = new Label();
            //    l.Content = account;
            //    ListBoxAcount.Items.Add(l);
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListBoxAcount.Items.Clear();
            List<string> accounts = _accountClient.GetAllAccountsAsString();
            foreach (string account in accounts)
            {
                Label l = new Label();
                l.Content = account;
                ListBoxAcount.Items.Add(l);
            }
        }
    }
}
