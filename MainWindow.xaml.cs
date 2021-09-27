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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularButtonClick(object sender, RoutedEventArgs e)
        {
            int res = default;
            try
            {
                switch (operador.Text)
                {
                    case "+":
                        {
                            res = int.Parse(operando1.Text) + int.Parse(operando2.Text);
                            break;
                        }
                    case "-":
                        {
                            res = int.Parse(operando1.Text) - int.Parse(operando2.Text);
                            break;
                        }
                    case "*":
                        {
                            res = int.Parse(operando1.Text) * int.Parse(operando2.Text);
                            break;
                        }
                    case "/":
                        {
                            res = int.Parse(operando1.Text) / int.Parse(operando2.Text);


                            break;
                        }
                }
                resultado.Text = res.ToString();
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
                resultado.Text = "NaN";
            }
            catch(FormatException)
            {
                MessageBox.Show("Introduce un dato valido");
            }
            
            
        }

        private void LimpiarButtonClick(object sender, RoutedEventArgs e)
        {
            operando1.Text = "";
            operando2.Text = "";
            operador.Text = "";
            resultado.Text = "";
        }

        private void operadorTextChanged(object sender, TextChangedEventArgs args)
        {
            if (operador.Text == "+" || operador.Text == "-" || operador.Text == "*" || operador.Text == "/")
            {
                calcular.IsEnabled = true;
            }
            else
            {
                calcular.IsEnabled = false;
            }
        }
    }
}
