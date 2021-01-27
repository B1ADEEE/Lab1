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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> Bands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Band_LBOX_Loaded(object sender, RoutedEventArgs e)
        {
            RockBand Name1 = new RockBand() { BandName = "AC/DC" , YearFormed = 1973, Members = "Bon Scott,Angus Young,Malcolm Young,Cliff Williams,Phil Rudd" };
            RockBand Name2 = new RockBand() { BandName = "ColdPlay", YearFormed = 1996, Members = "Chris Martin,Johnny Buckland,Guy Berryman,Will Champion,Phil Harvey" };
            IndieBand Name3 = new IndieBand() { BandName = "The Lumineers", YearFormed = 2005, Members = "Wesley Schultz,Jeremiah Fraites" };
            PopBand Name4 = new PopBand() { BandName = "One Republic", YearFormed = 2002, Members = "Ryan Tedder,Zach Filkins,Drew Brown,Brent Kutzie,Eddie Fisher, Brian Willett" };
            PopBand Name5 = new PopBand() { BandName = "Imagine Dragons", YearFormed = 2008, Members = "Dan Reynolds,Wayne Serman,Ben Mckee,Daniel Platzman" };
            PopBand Name6 = new PopBand() { BandName = "Take That", YearFormed = 1990, Members = "Gary Barlow,Howard Donald,Mark Owen,Robbie Williams,Jason Orange" };

            Bands.Add(Name1);
            Bands.Add(Name2);
            Bands.Add(Name3);
            Bands.Add(Name4);
            Bands.Add(Name5);
            Bands.Add(Name6);

            Bands.Sort();

            Band_LBOX.ItemsSource = Bands;
        }
        public class RockBand : Band
        {
            public override string ToString()
            {
                return base.ToString() + " - Rock Band"; 
            }
        }
        public class  PopBand : Band
        {
            public override string ToString()
            {
                return base.ToString() + " - Pop band";
            }
        }
        public class IndieBand : Band
        {
            public override string ToString()
            {
                return base.ToString() +" - Indie Band";
            }
        }
    }
}
