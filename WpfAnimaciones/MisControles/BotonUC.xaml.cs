using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfAnimaciones.MisControles
{
    /// <summary>
    /// Lógica de interacción para BotonUC.xaml
    /// </summary>
    public partial class BotonUC : UserControl
    {
        #region EVENTO
        public event EventHandler Click;
        #endregion
       
        #region CONSTRUCTOR
        public BotonUC()
        {
            InitializeComponent();
        }
        #endregion
      
        #region PROPIEDAD
        /// <summary>
        /// Titulo o Nombre mostrado para el Tile
        /// </summary>
        [DefaultValue("Titulo Tile")]
        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register("Titulo", typeof(string), typeof(BotonUC),
            new PropertyMetadata((d, e) =>
            {
                if (e.NewValue != null) ((BotonUC)d).TituloTextBlock.Text = e.NewValue.ToString();
            }));
        #endregion
       
        #region EVENTOS DE CONTROLES
        private void BotonGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Click != null) Click(this, new EventArgs());
        }
        #endregion


    }
}
