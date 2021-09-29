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
            int resultado = default;
            try
            {
                switch (OperadorTextBox.Text)
                {
                    case "+":
                        {
                            resultado = int.Parse(Operando1TextBox.Text) + int.Parse(Operando2TextBox.Text);
                            break;
                        }
                    case "-":
                        {
                            resultado = int.Parse(Operando1TextBox.Text) - int.Parse(Operando2TextBox.Text);
                            break;
                        }
                    case "*":
                        {
                            resultado = int.Parse(Operando1TextBox.Text) * int.Parse(Operando2TextBox.Text);
                            break;
                        }
                    case "/":
                        {
                            resultado = int.Parse(Operando1TextBox.Text) / int.Parse(Operando2TextBox.Text);


                            break;
                        }
                }
                ResultadoTextBox.Text = resultado.ToString();
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
                ResultadoTextBox.Text = "NaN";
            }
            catch(FormatException)
            {
                MessageBox.Show("Introduce un dato valido");
            }
            
            
        }

        private void LimpiarButtonClick(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = "";
            Operando2TextBox.Text = "";
            OperadorTextBox.Text = "";
            ResultadoTextBox.Text = "";
        }

        private void operadorTextChanged(object sender, TextChangedEventArgs args)
        {
            if (OperadorTextBox.Text == "+" || OperadorTextBox.Text == "-" || OperadorTextBox.Text == "*" || OperadorTextBox.Text == "/")
            {
                CalcularButton.IsEnabled = true;
            }
            else
            {
                CalcularButton.IsEnabled = false;
            }
        }
    }
}
