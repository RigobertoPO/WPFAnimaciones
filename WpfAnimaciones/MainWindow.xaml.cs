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

namespace WpfAnimaciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region CONSTRUCTOR
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion
        #region EVENTOS DE CONTROLES
        private void Opcion1BotonUC_Click(object sender, EventArgs e)
        {
            ContenedorGrid.Children.Clear(); //limpia el area donde pondremos los controles
            Ejemplos.Ejemplo1UC ejemplo1 = new Ejemplos.Ejemplo1UC(); //Instancia la clase 
            ContenedorGrid.Children.Add(ejemplo1);  //agregamos el objeto creado al area contenedora
        }

        private void Opcion2BotonUC_Click(object sender, EventArgs e)
        {
            ContenedorGrid.Children.Clear(); //limpia el area donde pondremos los controles
            Ejemplos.Ejemplo2UC ejemplo2 = new Ejemplos.Ejemplo2UC(); //Instancia la clase 
            ContenedorGrid.Children.Add(ejemplo2);  //agregamos el objeto creado al area contenedora
        }

        private void Opcion3BotonUC_Click(object sender, EventArgs e)
        {
            ContenedorGrid.Children.Clear(); //limpia el area donde pondremos los controles
            Ejemplos.Ejemplo3UC ejemplo3 = new Ejemplos.Ejemplo3UC(); //Instancia la clase 
            ContenedorGrid.Children.Add(ejemplo3);  //agregamos el objeto creado al area contenedora
        }

        private void Opcion4BotonUC_Click(object sender, EventArgs e)
        {
            ContenedorGrid.Children.Clear(); //limpia el area donde pondremos los controles
            Ejemplos.Ejemplo4UC ejemplo4 = new Ejemplos.Ejemplo4UC(); //Instancia la clase 
            ContenedorGrid.Children.Add(ejemplo4);  //agregamos el objeto creado al area contenedora
        }
        #endregion


    }
}
