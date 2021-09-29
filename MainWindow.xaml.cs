using BeautySolutions.View.ViewModel;
using MaterialDesignThemes.Wpf;
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

namespace dropDown_menu
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var item0 = new ItemMenu("Dashboard", new UserControl(), PackIconKind.ViewDashboard);

            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Мой профиль"));
            menuRegister.Add(new SubItem("Настройка"));
            var item1 = new ItemMenu("Регистрация", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItem>();
            menuSchedule.Add(new SubItem("Питта"));
            menuSchedule.Add(new SubItem("Вата"));
            menuSchedule.Add(new SubItem("Капха"));
            var item2 = new ItemMenu("Твоя Доша", menuSchedule, PackIconKind.Schedule);

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Муладхара"));
            menuReports.Add(new SubItem("Свадхистана"));
            menuReports.Add(new SubItem("Манипура"));
            menuReports.Add(new SubItem("Анахата"));
            menuReports.Add(new SubItem("Вишудха"));
            menuReports.Add(new SubItem("Аджна"));
            menuReports.Add(new SubItem("Сахасрара"));
            var item3 = new ItemMenu("Чакры", menuReports, PackIconKind.FileReport);

            var menuExpenses = new List<SubItem>();
            menuExpenses.Add(new SubItem("Избранное"));
            menuExpenses.Add(new SubItem("Мои покупки"));
            var item4 = new ItemMenu("Корзина", menuExpenses, PackIconKind.ShoppingBasket);

            var menuFinancial = new List<SubItem>();
            menuFinancial.Add(new SubItem("Вконтакте"));
            menuFinancial.Add(new SubItem("Инстаграм"));
            menuFinancial.Add(new SubItem("FaceBoock"));
            var item5 = new ItemMenu("Соц.Сети", menuFinancial, PackIconKind.ScaleBalance);

            

            Menu.Children.Add(new UserControl_menu(item0));
            Menu.Children.Add(new UserControl_menu(item1));
            Menu.Children.Add(new UserControl_menu(item2));
            Menu.Children.Add(new UserControl_menu(item3));
            Menu.Children.Add(new UserControl_menu(item4));
            Menu.Children.Add(new UserControl_menu(item5));
           
        }
    }
}

