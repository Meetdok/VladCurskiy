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
using VladCurskiy.DTO;
using VladCurskiy.ViewModels;

namespace VladCurskiy.Pages
{
    /// <summary>
    /// Interaction logic for ViewMessagePage.xaml
    /// </summary>
    public partial class ViewMessagePage : Page
    {
        public ViewMessagePage(User selectedUser)
        {
            InitializeComponent();
            DataContext = new ViewMessageVM(selectedUser);
        }
    }
}
