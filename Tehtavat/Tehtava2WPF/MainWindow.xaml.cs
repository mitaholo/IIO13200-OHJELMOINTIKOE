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
using System.IO;
using Microsoft.Win32;
using System.Xml.Linq;
using System.Configuration;
using System.Data;

namespace Tehtava2WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XDocument xml;
        List<XElement> allCountries;
        DataTable countryTable;

        public MainWindow()
        {
            InitializeComponent();
            //IEnumerable<XElement> countries;
            //List<XElement> countries;
            countryTable = new DataTable();

            if (File.Exists(ConfigurationManager.AppSettings["datapath"]))
            {
                xml = XDocument.Load(ConfigurationManager.AppSettings["datapath"]);
                allCountries = xml.Root.Descendants("ROW").ToList<XElement>();

                IEnumerable<string> continents = from country in xml.Root.Descendants("ROW")
                                                    let continent = (string)country.Element("Continent")
                                                    orderby continent
                                                    select continent;
                continents = continents.Distinct();
                cbSelectContinent.ItemsSource = continents;

                countryTable.Columns.Add("Name", typeof(string));
                countryTable.Columns.Add("Continent", typeof(string));
                countryTable.Columns.Add("Populaton", typeof(string));
                countryTable.Columns.Add("Local name", typeof(string));
                countryTable.Columns.Add("Head of state", typeof(string));

                LoadCountries(allCountries);

                //cbSelectContinent
                //allCountries

            }
            else
            {
                ShowErrorMessageBox("Virhe","Tiedostoa ei löydy");
            }
        }

        public void LoadCountries(List<XElement> countries)
        {
            countryTable.Clear();

            foreach (var country in countries)
            {
                countryTable.Rows.Add(
                    country.Element("Name").Value,
                    country.Element("Continent").Value,
                    country.Element("Population").Value,
                    country.Element("LocalName").Value,
                    country.Element("HeadOfState").Value
                );
            }

            dgCountries.DataContext = null;
            dgCountries.DataContext = countryTable;
        }

        public void ShowErrorMessageBox(string title, string message)
        {
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Error;
            MessageBox.Show(message, title, button, icon);
        }

        public void ShowInfoMessageBox(string title, string message)
        {
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(message, title, button, icon);
        }

        private void CountCountries(object sender, RoutedEventArgs e)
        {
            ShowInfoMessageBox("Maat laskettu", "Maita yhteensä " + allCountries.Count.ToString());
        }

        private void CountPopulations(object sender, RoutedEventArgs e)
        {
            int totalPopulation = 0;
            foreach (var country in allCountries)
            {
                int population;
                if (Int32.TryParse(country.Element("Population").Value, out population))
                {
                    totalPopulation += population;
                }
            }

            ShowInfoMessageBox("Kansalaiset laskettu", "Asukkaita yhteensä " + totalPopulation.ToString());
        }

        

        private void TopPopulation(object sender, RoutedEventArgs e)
        {
            LoadCountries(allCountries.OrderByDescending(country => country.Element("Population").Value, new NumericStringComparer()).Take(10).ToList());
        }

        private void TopArea(object sender, RoutedEventArgs e)
        {
            LoadCountries(allCountries.OrderByDescending(country => country.Element("SurfaceArea").Value, new NumericStringComparer()).Take(10).ToList());
        }

        private void FilterName(object sender, RoutedEventArgs e)
        {
            LoadCountries(allCountries.Where(country => country.Element("Name").Value.ToLower().Contains(txtFilterName.Text.ToLower())).ToList());
        }

        private void SelectContinent(object sender, RoutedEventArgs e)
        {
            LoadCountries(allCountries.Where(country => country.Element("Continent").Value.ToLower().Equals(cbSelectContinent.Text.ToLower())).ToList());
        }
    }
}
