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
using System.Xml;
using System.Text.RegularExpressions;
namespace WpfApp1
{
    public class Item
    {
        public string title;
        public string link;
        public string description;
        public string pubDate;
        public Item() {; }
        public Item(string newTitle, string newLink, string newDescr, string newDate)
        {
            title = newTitle;
            link = newLink;

            description = newDescr;
            pubDate = newDate;
        }
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        private List<Item> listItems = new List<Item>();
        string url = "https://habr.com/ru/rss/interesting/";
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnGetInfo(object sender, RoutedEventArgs e)
        {
            XmlReader reader = XmlReader.Create(url);

            reader.Close();
            string nTitle;
            string nLink;
            string nDescr;
            string nPubdate;
            string nAuthor;

        }

        private void btnCreateXML(object sender, RoutedEventArgs e)
        {

        }
    }
}
