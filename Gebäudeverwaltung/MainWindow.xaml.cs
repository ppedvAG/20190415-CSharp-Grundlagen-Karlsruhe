using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace Gebäudeverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Architekturstile.Add("Barock");
            Architekturstile.Add("Moderne");
            G_Architektur.ItemsSource = Architekturstile;
        }
        public List<string> Architekturstile = new List<string>();

        private void SpeichernButton_Click(object sender, RoutedEventArgs e)
        {
            Gebäude zuSpeicherndesGebäude = new Gebäude();
            zuSpeicherndesGebäude.Name = G_Name.Text;
            zuSpeicherndesGebäude.Fenster = int.Parse(G_Fenster.Text);
            zuSpeicherndesGebäude.Türen = int.Parse(G_Tueren.Text);
            zuSpeicherndesGebäude.Höhe = float.Parse(G_Hoehe.Text);
            zuSpeicherndesGebäude.IstNeu = (bool)G_IstNeu.IsChecked;
            zuSpeicherndesGebäude.Architekturstil = G_Architektur.Text;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Gebäude));
            using (FileStream fs = new FileStream("Gebäude.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fs, zuSpeicherndesGebäude);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gebäude zuLadendesGebäude = new Gebäude();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Gebäude));
            using (FileStream fs = new FileStream("Gebäude.xml", FileMode.Open, FileAccess.Read))
            {
                zuLadendesGebäude = (Gebäude)xmlSerializer.Deserialize(fs);
            }

            G_Name.Text = zuLadendesGebäude.Name;
            G_Fenster.Text = zuLadendesGebäude.Fenster.ToString();
            G_Tueren.Text = zuLadendesGebäude.Türen.ToString();
            G_Hoehe.Text = zuLadendesGebäude.Höhe.ToString();
            G_IstNeu.IsChecked = zuLadendesGebäude.IstNeu;
            G_Architektur.Text = zuLadendesGebäude.Architekturstil;
        }
    }
}
