﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for CheckIssuanceWindow.xaml
    /// </summary>
    public partial class CheckIssuanceWindow : Window
    {
        AppContext ctx;
        public CheckIssuanceWindow()
        {
            InitializeComponent();
            ctx = new AppContext();
        }

        private void btn_cancel_clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_issue_clicked(object sender, RoutedEventArgs e)
        {

            string AccountNo = AccountNumber.Text;
            ctx.Database.ExecuteSqlCommand(
                "insert into \"Check\" values(@aid,@checkId,@expirationDate,@paperNo)",
                new SqlParameter("aid", Int32.Parse(AccountNo)),
                new SqlParameter("checkId", 21),
                new SqlParameter("expirationDate", "2015-09-22"),
                new SqlParameter("paperNo", 10)
            );

            // to do
            MessageBox.Show("Check Issuance Confirmed!");
        }
    }
}
