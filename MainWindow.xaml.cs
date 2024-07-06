using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicPlayerUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        songList.ItemsSource = new[]

        {

            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Broken Mirror", ArtistName = "Hardwell"},

            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Rebels Never Die", ArtistName = "Hardwell"},
            
            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Pacman", ArtistName = "Hardwell"},
            
            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Broken Mirror", ArtistName = "Hardwell"},
            
            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Broken Mirror", ArtistName = "Hardwell"},
            
            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Broken Mirror", ArtistName = "Hardwell"}


        };
        
        songList2.ItemsSource = new[]

        {

            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Broken Mirror", ArtistName = "Hardwell"},

            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Rebels Never Die", ArtistName = "Hardwell"},
            
            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Rebels Never Die", ArtistName = "Hardwell"},
            
            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Rebels Never Die", ArtistName = "Hardwell"},
            
            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Rebels Never Die", ArtistName = "Hardwell"},
            
            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Rebels Never Die", ArtistName = "Hardwell"},
            
            new Song { ImageUrl = "C:\\Users\\Alienware\\RiderProjects\\MusicPlayerUI\\Images\\500x500-000000-80-0-0.jpg", SongName = "Rebels Never Die", ArtistName = "Hardwell"}
            
        };
    }
    
   
}

public class Song

{

    public string ImageUrl { get; set; }

   

    public string SongName { get; set; }

    public string ArtistName { get; set; }

}