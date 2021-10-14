using Capitulo10_12WPF.Entidades;
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

namespace Capitulo10_12WPF.Capitulo_10
{
    /// <summary>
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        private List<Escuela> estudiante = new List<Escuela>();
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, RoutedEventArgs e)
        {
            estudiante.Add(new Escuela(int.Parse(matricula.Text), nombre.Text, apellido.Text, curso.Text));

            matricula.Text = "";
            nombre.Text = "";
            apellido.Text = "";
            curso.Text = "";
        }
    }
}
