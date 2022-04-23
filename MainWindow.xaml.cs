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
using System.Media;

namespace Carro
{
    public partial class MainWindow : Window


    {




        public MainWindow()
        {

            InitializeComponent();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BT_Luces(object sender, RoutedEventArgs e)
        {
            GifLuces g = new GifLuces();

            g.ShowDialog();



        }

        private void BT_Apagarluces(object sender, RoutedEventArgs e)

        {
            ApagarLuces l = new ApagarLuces();
            l.ShowDialog();

        }

        private void BT_Claxon(object sender, RoutedEventArgs e)
        {
            var claxon = new System.Media.SoundPlayer();
            claxon.SoundLocation = @"C:\\mp3\\claxon.wav";

            claxon.Play();
        }

        private void BT_ClickRadio(object sender, EventArgs e)
        {
            var player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\\mp3\\mymp3.wav";

            player.Play();
        }

        private void BT_Stop(object sender, EventArgs e)
        {
            var player = new System.Media.SoundPlayer();
            player.Stop();
        }
        private void BT_Puerta(object sender, EventArgs e)
        {
            var door = new System.Media.SoundPlayer();
            door.SoundLocation = @"C:\\mp3\\door.wav";

            door.Play();

            MessageBox.Show("Abriste la puerta del carro!");
        }

        private void BT_Motor(object sender, EventArgs e)
        {
            var motor = new System.Media.SoundPlayer();
            motor.SoundLocation = @"C:\\mp3\\motor.wav";

            motor.Play();

            Motor m = new Motor();
            m.ShowDialog();
      
        }
        private void BT_Freno(object sender, EventArgs e)
        {
            MessageBox.Show("El auto está frenando!");
        }
    }
}


