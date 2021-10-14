using Capitulo10_12WPF.Entidades;
using System;
using System.Collections;
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

namespace Capitulo10_12WPF.Capitulo_10
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        private List<Tienda> producto = new List<Tienda>();
        public Ejercicio1()
        {
            InitializeComponent();
        }
        private void guardar_Click(object sender, RoutedEventArgs e)
        {
           
        producto.Add(new Tienda(int.Parse(CodigoProducto.Text), Descripcion.Text, int.Parse(cantidad.Text), double.Parse(precio.Text)));

         CodigoProducto.Text = "";
         Descripcion.Text = "";
         precio.Text = "";
         cantidad.Text = "";
        }
    }
}
