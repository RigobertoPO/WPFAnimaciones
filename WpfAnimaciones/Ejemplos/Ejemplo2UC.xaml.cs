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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAnimaciones.Ejemplos
{
    /// <summary>
    /// Lógica de interacción para Ejemplo2UC.xaml
    /// </summary>
    public partial class Ejemplo2UC : UserControl
    {
        public Ejemplo2UC()
        {
            InitializeComponent();
        }
        public bool  fueEnviado { get; set; }

        private void EnviarButton_Click(object sender, RoutedEventArgs e)
        {
            if (fueEnviado == false)
            {
                fueEnviado = true;
                Storyboard s = (Storyboard)TryFindResource("EnviarStoryboard");
                s.Begin();
            }
        }

        private void RegresarButton_Click(object sender, RoutedEventArgs e)
        {
            if (fueEnviado == true)
            {
                fueEnviado = false;
                Storyboard s = (Storyboard)TryFindResource("RegresarStoryboard");
                s.Begin();
            }
        }
    }
}
