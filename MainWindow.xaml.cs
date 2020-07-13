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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Stack<double> values= new Stack<double>();
        Stack<char> signs = new Stack<char>();
        double operand1 = 0;
        double operand2 = 0;
        string sign = " ";
        bool decimalPoint =false;
        double decimalPlace = 10;
        bool result = false; // to check whether what is on the screen is a  calculated result or not

        private void Clear()
        {
            operand1 = 0;
            operand2 = 0;
            Sign.Text = " ";
            //Operand.Text = " ";
            result = false;
            decimalPoint = false;
            decimalPlace = 10;
            display.Text = "0";
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

           
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (7/decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                }
                else
                {
                    operand1 = operand1 * 10 + 7;
                    display.Text = operand1.ToString();
                }

            String t = operand1.ToString();

            Operand.Text += t[t.Length - 1].ToString();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

            if (sign == " ")
            {
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (1 / decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                }
                else
                {
                    operand1 = operand1 * 10 + 1;
                    display.Text = operand1.ToString();
                }
            }
            String t = operand1.ToString();

            Operand.Text += t[t.Length - 1].ToString();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

            if (sign == " ")
            {
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (2 / decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                }
                else
                {
                    operand1 = operand1 * 10 + 2;
                    display.Text = operand1.ToString();
                }
            }
            String t = operand1.ToString();

            Operand.Text += t[t.Length - 1].ToString();
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

            if (sign == " ")
            {
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (3 / decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                }
                else
                {
                    operand1 = operand1 * 10 + 3;
                    display.Text = operand1.ToString();
                }
            }
            String t = operand1.ToString();

            Operand.Text += t[t.Length - 1].ToString();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

            if (sign == " ")
            {
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (4 / decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                }
                else
                {
                    operand1 = operand1 * 10 + 4;
                    display.Text = operand1.ToString();
                }
            }
            String t = operand1.ToString();

            Operand.Text += t[t.Length - 1].ToString();
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

            if (sign == " ")
            {
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (5 / decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                }
                else
                {
                    operand1 = operand1 * 10 + 5;
                    display.Text = operand1.ToString();
                }
            }
            String t = operand1.ToString();

            Operand.Text += t[t.Length - 1].ToString();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

            if (sign == " ")
            {
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (6 / decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                }
                else
                {
                    operand1 = operand1 * 10 + 6;
                    display.Text = operand1.ToString();
                }
            }
            String t = operand1.ToString();

            Operand.Text += t[t.Length - 1].ToString();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

            if (sign == " ")
            {
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (8 / decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                }
                else
                {
                    operand1 = operand1 * 10 + 8;
                    display.Text = operand1.ToString();
                }
            }
            String t = operand1.ToString();

            Operand.Text += t[t.Length - 1].ToString();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

            if (sign == " ")
            {
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (9 / decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                    //Operand.Text += operand1.ToString();
                }
                else
                {
                    operand1 = operand1 * 10 + 9;
                    display.Text = operand1.ToString();
                   // Operand.Text += operand1.ToString();
                }
            }
            String t = operand1.ToString();
            
            Operand.Text += t[t.Length-1].ToString();
            
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            if (decimalPoint == false)
            {
                operand1 = operand1 + 0.0;
                decimalPoint = true;
                display.Text = operand1.ToString() + ".";
                String t = display.Text;

                Operand.Text += t[t.Length - 1].ToString();
            }
            
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (result)
                Clear();

            if (sign == " ")
            {
                if (decimalPoint == true)
                {
                    operand1 = operand1 + (0 / decimalPlace);
                    display.Text = operand1.ToString();
                    decimalPlace *= 10;
                   
                }
                else
                {
                    operand1 = operand1 * 10;
                    display.Text = operand1.ToString();
                    
                }
            }
            String t = operand1.ToString();

            Operand.Text += t[t.Length - 1].ToString();
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (Operand.Text.Length == 0)
                Clear();

            String t = "";
            for (int i = 0; i < Operand.Text.Length - 1; i++)
                t += Operand.Text[i];
            Operand.Text = t;
            /// back space the display of font 50
            String d = "";
            for (int i = 0; i < display.Text.Length - 1; i++)
                d += display.Text[i];
            display.Text = d;
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            Operand.Text = operand1.ToString();
            if (result)
            {
                operand1 = double.Parse(display.Text);
                
            }
            operand1 *= operand1;
            display.Text = operand1.ToString();
            result = true;
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            Operand.Text = operand1.ToString();
            if (result)
            {
                operand1 = double.Parse(display.Text);               
            }
            operand1 = Math.Log10(operand1);
            display.Text = operand1.ToString();
            result = true;
        }

        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            Operand.Text = operand1.ToString();
            if (result)
            {
                operand1 = double.Parse(display.Text);
            }
            operand1 = Math.Sqrt(operand1);
            
            display.Text = operand1.ToString();
            result = true;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Operand.Text = " ";
            Clear();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private int opereationPrecedence(char c)
        {
            switch (c)
            {
                case '+': 
                case '-': return 1;
                   
                case 'x':
                case '/': return 2;
                   
                default: return 3;
            }
            
        }
         
     
      
        private double Calculation( double lhs, char op, double rhs)
        {
            double calcul =0;
            switch (op)
            {
                case '+': calcul = lhs + rhs;
                    break;
                case '-': calcul = rhs - lhs;
                    break;
                case 'x': calcul = lhs * rhs;
                    break;
                case '/':  if (lhs == 0)
                             {
                                 Operand.Text = "ERROR of division by 0!";
                                Clear();
                             }
                    else
                        calcul = rhs / lhs;
                    break;

            }
            return calcul;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
            Operand.Text += " + ";
            Clear();

        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
           Operand.Text += " x ";
            Clear();
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            Operand.Text +=  " - ";
            Clear();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Operand.Text += " / ";
            Clear();
  
        }

        private void LeftParent_Click(object sender, RoutedEventArgs e)
        {

            if (operand1 != 0)
            {
                Operand.Text +=  " ( ";
            }
            else
            {
                Operand.Text += " ( ";
            }
            Clear();

        }

        private void RightParent_Click(object sender, RoutedEventArgs e)
        {          
                if (operand1 != 0)
                {
                    Operand.Text += 
                    " ) ";
                }
                else
                {
                    Operand.Text += " ) ";
                }
                Clear();
  
        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
           char[] token = Operand.Text.ToCharArray();
            //Console.WriteLine(Operand.Text);
            for (int i = 0; i< token.Length; i++)
            {
               // Console.WriteLine("Token: "+token[i].ToString());
                if (token[i] == ' ')
                    continue;

                else if (token[i] == '(')
                {
                    signs.Push(token[i]);
                   // Console.WriteLine("Pushed left parent to signs");
                }

                else if (token[i] >= '0' && token[i] <= '9')
                {
                    //Console.WriteLine(token[i]);

                    String val ="";
                    while (i < token.Length && (token[i] >= '0' && token[i] <= '9' )|| i < token.Length && token[i]=='.')
                    {
                        val+=(token[i++]);
                    }
                    values.Push(double.Parse(val.ToString()));
                }

                else if (token[i] == ')')
                {
                   // Console.WriteLine("In Right parent ");
                    //Console.WriteLine("the peek is" + signs.Peek().ToString());
                    while (signs.Peek() != '(')
                    {
                        double x = Calculation(values.Pop(), signs.Pop(), values.Pop());
                        values.Push(x);
                       // Console.WriteLine("Rigt parent val" + x.ToString());
                        if (signs.Count == 0)
                        {
                            display.Text = "ERROR! Unmatched parenthesis";
                            Clear();
                        }
                    }
                    signs.Pop();
                }

                else if (token[i] == '+' || token[i] == '-' || token[i] == 'x' || token[i] == '/')
                {
                   // Console.WriteLine("Debugging ");
                   
                    while (signs.Count > 0 && (opereationPrecedence(token[i]) >= opereationPrecedence(signs.Peek())))
                    {
                        
                            double y = Calculation(values.Pop(), signs.Pop(), values.Pop());
                            values.Push(y);
                            //Console.WriteLine("Else val " + y.ToString());
                       
                    }
                    signs.Push(token[i]);
                }
            }

            while (signs.Count > 0)
            {

                double z = Calculation(values.Pop(), signs.Pop(), values.Pop());
                values.Push(z);
               // Console.WriteLine("Result val"+z.ToString());

            }

            display.Text = values.Pop().ToString();
            result = true;

        }


    }
}
