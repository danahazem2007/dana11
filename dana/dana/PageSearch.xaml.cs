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
    /// Interaction logic for PageSearch.xaml
    /// </summary>
    public partial class PageSearch : Page
    {
        login_Entities1 db = new login_Entities1();
        public PageSearch()
        {
            InitializeComponent();
            dg.ItemsSource = db.uesr_.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uesr_ uesr = new uesr_();
            dg.ItemsSource = db.uesr_.Where(x => x.City == search.Text);
            db.uesr_.Select(x=>new{ x.Username , x.Age ,x.Password_,x.Gender ,x.Phone_number,x.City,);
            db.SaveChanges();
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            uesr_ uesr = new uesr_();
            dg.ItemsSource = db.uesr_.Where(x => x.Phone_number == remove.Text); 
            db.uesr_.Remove(uesr);
            db.SaveChanges();
        }
    }

        
    }
}
