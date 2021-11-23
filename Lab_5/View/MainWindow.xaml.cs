using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using Lab_5.Model;

namespace Lab_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SoundPlayer player;
        private bool isPlay = false;
        public MainWindow()
        {
            InitializeComponent();

            const string fileName = "music.wav";
            const string path = "Resources.Sounds";
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(string.Format("{0}.{1}.{2}", assembly.GetName().Name, path, fileName));
            player = new SoundPlayer(stream);
        }
    
        private void OnOffMusic(object sender, RoutedEventArgs e)
        {
            isPlay = !isPlay;
            if (isPlay)
            {
                player.Play();
            }
            else
            {
                player.Stop();
            }
        }
    }
}
