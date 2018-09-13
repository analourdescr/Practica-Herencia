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

namespace Herencia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Animal> animales = new List<Animal>();

            Ave tucan = new Ave();
            tucan.Nombre = "Ana";

            Mamifero tigre = new Mamifero();
            tigre.Nombre = "Pintito";

            animales.Add(tucan);
            animales.Add(tigre);

            Pez Pezdorado = new Pez();
            Pezdorado.Nombre = "Antonio";

            animales.Add(Pezdorado);

            Animal cocodrilo = new Reptil();
            cocodrilo.Nombre = "Jaime";

            animales.Add(cocodrilo);

            foreach (Animal animal in animales)
            {
                stckRegistro.Children.Add(
                    new TextBlock
                    {
                        Text= animal.desplazar()
                    });
            }
            

            stckRegistro.Children.Add(
                new TextBlock {
                    Text = tucan.desplazar()
                }
            );
            stckRegistro.Children.Add(
                new TextBlock
                {
                    Text = tigre.desplazar()
                }
            );

            imprimir(tigre.comer());
            imprimir(
                        ((Reptil)cocodrilo).cambioPiel()
                );
        }


        public void imprimir(string texto)
        {
            stckRegistro.Children.Add(
                new TextBlock
                {
                    Text = texto
                });
        }
    }
}
