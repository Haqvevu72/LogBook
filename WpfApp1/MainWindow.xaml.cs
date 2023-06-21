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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>() 
        {
            new Student("Pictures\\R.png","Haqverdiyev Elgun Elnur",0,"Very Funny Guy",3),
            new Student("Pictures\\R.png","Nagiyev Gunduz Veli",0,"Professional",3),
            new Student("Pictures\\R.png","Eminli Hikmet Yalchin",0,"Blessed",3)
        };
        public MainWindow()
        {
            InitializeComponent();
            LogBook.ItemsSource = students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button comment = sender as Button;
            StackPanel logbook=comment.Parent as StackPanel;
            TextBox message = logbook.Children[7] as TextBox;
            if (message.Visibility == Visibility.Visible) { message.Visibility = Visibility.Hidden; }
            else { message.Visibility = Visibility.Visible; }
        }
    }
}
