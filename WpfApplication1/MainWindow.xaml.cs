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
using Microsoft.Win32;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isPlaying;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadButtonClicked(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() {Filter = "Video file (.mp4)|*.mp4"};
            var result = dialog.ShowDialog(this);
            if (result == true)
            {
                var fileName = dialog.FileName;
                VideoPlayer.Source = new Uri(fileName, UriKind.Absolute);
                VideoPlayer.Play();
                isPlaying = true;
            }
        }

        private void PlayPauseClicked(object sender, RoutedEventArgs e)
        {
            if (isPlaying)
            {
                VideoPlayer.Pause();
            }
            else
            {
                VideoPlayer.Play();
            }
        }
    }
}
