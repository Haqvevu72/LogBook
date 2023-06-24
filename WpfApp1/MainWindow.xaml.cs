using Microsoft.Win32;
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
using Newtonsoft.Json;
using System.IO;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students;
        public MainWindow()
        {
            InitializeComponent();
            string getting = File.ReadAllText("C:\\Users\\Elgun\\source\\repos\\LogBook\\WpfApp1\\Qosa1.json");
            students = JsonConvert.DeserializeObject<List<Student>>(getting);
            LogBook.ItemsSource = students;
            Qosa2.ItemsSource = students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button comment = sender as Button;
            StackPanel logbook=comment.Parent as StackPanel;
            TextBox message = logbook.Children[8] as TextBox;
            if (message.Visibility == Visibility.Visible) { message.Visibility = Visibility.Hidden; }
            else { message.Visibility = Visibility.Visible; }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string save = JsonConvert.SerializeObject(students);
            File.WriteAllText("C:\\Users\\Elgun\\source\\repos\\LogBook\\WpfApp1\\Qosa1.json", save);
            MessageBox.Show("Successfuly Saved !","Save",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            int value = int.Parse((cb.SelectedIndex+1).ToString());
            StackPanel logbook = cb.Parent as StackPanel;
            Label id = logbook.Children[0] as Label;
            int index = int.Parse(id.Content.ToString());
            students[index - 1].average = value;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox comment = sender as TextBox;
            StackPanel logbook = comment.Parent as StackPanel;
            Label id = logbook.Children[0] as Label;
            int index = int.Parse(id.Content.ToString());
            students[index-1].comment = comment.Text.ToString();
        }
    }
}
