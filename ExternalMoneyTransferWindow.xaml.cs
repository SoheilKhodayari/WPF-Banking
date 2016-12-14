﻿using System;
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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for ExternalMoneyTransferWindow.xaml
    /// </summary>
    public partial class ExternalMoneyTransferWindow : Window
    {
        public string bank_code { get; set; }
        public ExternalMoneyTransferWindow(string bank_code)
        {
            this.bank_code = bank_code;
            InitializeComponent();
        }

        private void btn_reset_clicked(object sender, RoutedEventArgs e)
        {
            this.DestinationBank.Clear();
            this.DestinationAccount.Clear();
            this.SourceAccount.Clear();
            this.RequesterName.Clear();
            this.AmountMoney.Clear();
        }

        private void btn_submit_clicked(object sender, RoutedEventArgs e)
        {
            var amountTransfer = this.AmountMoney.Text;
            var srcTransfer = this.SourceAccount.Text;
            var destTransfer = this.DestinationAccount.Text;
            var srcBankTranfer = this.bank_code;
            var destBankTransfer = this.DestinationBank.Text; // to do: convert bankname to code
            var reqName = this.RequesterName.Text;

            // to do
            MessageBox.Show("Transaction Confirmed");
            
        }
    }
}
