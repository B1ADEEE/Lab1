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
            string[] genres = { "All", "Rock", "Pop", "Indie" };
            DropBox_COMBO.ItemsSource = genres;
            
            RockBand Name1 = new RockBand() { BandName = "AC/DC" , YearFormed = 1973, Members = "Bon Scott,Angus Young,Malcolm Young,Cliff Williams,Phil Rudd" };
            RockBand Name2 = new RockBand() { BandName = "ColdPlay", YearFormed = 1996, Members = "Chris Martin,Johnny Buckland,Guy Berryman,Will Champion,Phil Harvey" };
            IndieBand Name3 = new IndieBand() { BandName = "The Lumineers", YearFormed = 2005, Members = "Wesley Schultz,Jeremiah Fraites" };
            PopBand Name4 = new PopBand() { BandName = "One Republic", YearFormed = 2002, Members = "Ryan Tedder,Zach Filkins,Drew Brown,Brent Kutzie,Eddie Fisher, Brian Willett" };
            PopBand Name5 = new PopBand() { BandName = "Imagine Dragons", YearFormed = 2008, Members = "Dan Reynolds,Wayne Serman,Ben Mckee,Daniel Platzman" };
            PopBand Name6 = new PopBand() { BandName = "Take That", YearFormed = 1990, Members = "Gary Barlow,Howard Donald,Mark Owen,Robbie Williams,Jason Orange" };

            Random rand = new Random();
            Album Album1 = new Album() { Name = "The Razors Edge", YearOfRelease = rand.Next(1973, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album2 = new Album() { Name = "Back in Black", YearOfRelease = rand.Next(1973, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album3 = new Album() { Name = "A Head full of Dreams", YearOfRelease = rand.Next(1996, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album4 = new Album() { Name = "Parachutes", YearOfRelease = rand.Next(1996, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album5 = new Album() { Name = "The Lumineers", YearOfRelease = rand.Next(2005, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album6 = new Album() { Name = "Cleopatra", YearOfRelease = rand.Next(2005, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album7 = new Album() { Name = "Native", YearOfRelease = rand.Next(2002, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album8 = new Album() { Name = "Waking Up", YearOfRelease = rand.Next(2002, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album9 = new Album() { Name = "Night Visions", YearOfRelease = rand.Next(2008, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album10 = new Album() { Name = "Evolve", YearOfRelease = rand.Next(2008, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album11 = new Album() { Name = "Beautyful World", YearOfRelease = rand.Next(1990, 2021), Sales = rand.Next(1000000, 10000000) };
            Album Album12 = new Album() { Name = "Never Forget", YearOfRelease = rand.Next(1990, 2021), Sales = rand.Next(1000000, 10000000) };

            Bands.Add(Name1);
            Bands.Add(Name2);
            Bands.Add(Name3);
            Bands.Add(Name4);
            Bands.Add(Name5);
            Bands.Add(Name6);

            Name1.AlbumList.Add(Album1);
            Name1.AlbumList.Add(Album2);
            Name2.AlbumList.Add(Album3);
            Name2.AlbumList.Add(Album4);
            Name3.AlbumList.Add(Album5);
            Name3.AlbumList.Add(Album6);
            Name4.AlbumList.Add(Album7);
            Name4.AlbumList.Add(Album8);
            Name5.AlbumList.Add(Album9);
            Name5.AlbumList.Add(Album10);
            Name6.AlbumList.Add(Album11);
            Name6.AlbumList.Add(Album12);

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

        private void Band_LBOX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band SelectedBand = Band_LBOX.SelectedItem as Band;
            if (SelectedBand != null)
            {
                Album_LBOX.ItemsSource = SelectedBand.AlbumList;
                Topblock_TBLK.Text = string.Format($"Formed in {SelectedBand.YearFormed}" + $"\nMembers: {SelectedBand.Members}");
            }
        }

        private void DropBox_COMBO_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedGenre = DropBox_COMBO.SelectedItem as string;
            List<Band> filteredList = new List<Band>();
            switch(selectedGenre)
            {
                case "All":
                    Band_LBOX.ItemsSource = Bands;
                    break;
                case "Rock":
                    foreach (Band band in Bands)
                    {
                        if (band is RockBand)
                            filteredList.Add(band);
                    }
                    Band_LBOX.ItemsSource = filteredList;
                    break;
                case "Pop":
                    foreach (Band band in Bands)
                    {
                        if (band is PopBand)
                            filteredList.Add(band);
                    }
                    Band_LBOX.ItemsSource = filteredList;
                    break;
                case "Indie":
                    foreach(Band band in Bands)
                    {
                        if (band is IndieBand)
                            filteredList.Add(band);
                    }
                    Band_LBOX.ItemsSource = filteredList;
                    break;
            }
        }
    }
}
