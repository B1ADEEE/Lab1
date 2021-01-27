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
            Band Name1 = new Band() { BandName = "AC/DC" , YearFormed = 1973, Members = "Bon Scott,Angus Young,Malcolm Young,Cliff Williams,Phil Rudd" };
            Band Name2 = new Band() { BandName = "ColdPlay", YearFormed = 1996, Members = "Chris Martin,Johnny Buckland,Guy Berryman,Will Champion,Phil Harvey" };
            Band Name3 = new Band() { BandName = "The Lumineers", YearFormed = 2005, Members = "Wesley Schultz,Jeremiah Fraites" };
            Band Name4 = new Band() { BandName = "One Republic", YearFormed = 2002, Members = "Ryan Tedder,Zach Filkins,Drew Brown,Brent Kutzie,Eddie Fisher, Brian Willett" };
            Band Name5 = new Band() { BandName = "Imagine Dragons", YearFormed = 2008, Members = "Dan Reynolds,Wayne Serman,Ben Mckee,Daniel Platzman" };
            Band Name6 = new Band() { BandName = "Take That", YearFormed = 1990, Members = "Gary Barlow,Howard Donald,Mark Owen,Robbie Williams,Jason Orange" };

            Bands.Add(Name1);
            Bands.Add(Name2);
            Bands.Add(Name3);
            Bands.Add(Name4);
            Bands.Add(Name5);
            Bands.Add(Name6);

        }
    }
}
