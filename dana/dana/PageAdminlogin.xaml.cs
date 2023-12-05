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

namespace dana
{
    /// <summary>
    /// Interaction logic for PageAdminlogin.xaml
    /// </summary>
    public partial class PageAdminlogin : Page
    {
        login_Entities1 db = new login_Entities1();
        public PageAdminlogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Admin_ admin  = new Admin_();
            admin = db.Admin_.First(x => x.admin_username == adminName.Text && x.admin_pass == adminpassword.Text);
            MessageBox.Show("login is done");

            PageSearch search  = new PageSearch();
            this.NavigationService.Navigate(search);
        }
    }
}
