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
using System.Windows.Shapes;

///23.06.2025
///17:37

namespace MatchGame
{
    /// <summary>
    /// Lógica interna para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            this.Close();
        }

        private void btnRecorde_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funcionalidade de recorde ainda não implementada");
        }
        private void btnCreditos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Jogo criado por Mateus Jasper Anulhak com base no livro Use a Cabeça - C#, por O'Really");
        }

    }
}
