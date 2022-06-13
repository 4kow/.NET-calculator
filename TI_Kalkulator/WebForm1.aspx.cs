using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TI_Kalkulator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            
            switch (x.Text)
            {              
                case "sqrt":
                    
                    if(String.IsNullOrEmpty(Screen.Text))
                    {
                        Screen.Text = "Błąd";
                    }
                    else if(Screen.Text.Contains("+") || Screen.Text.Contains("-") || Screen.Text.Contains("*") || Screen.Text.Contains("/"))
                    {
                        Screen.Text = "Błąd";
                    }
                    else if (Screen.Text[0].Equals('B'))
                    {
                        Screen.Text = "Błąd";
                    }
                    else
                    {
                        Screen.Text = Math.Sqrt(Convert.ToDouble(Screen.Text)).ToString();
                        TextBox2.Text = Screen.Text;
                    }
                    
                    break;

                case "1/x":

                    if (String.IsNullOrEmpty(Screen.Text))
                    {
                        Screen.Text = "Błąd";
                    }
                    else if (Screen.Text.Contains("+") || Screen.Text.Contains("-") || Screen.Text.Contains("*") || Screen.Text.Contains("/"))
                    {
                        Screen.Text = "Błąd";
                    }
                    else if (Screen.Text[0].Equals('B'))
                    {
                        Screen.Text = "Błąd";
                    }
                    else
                    {
                        Screen.Text = (1 / Convert.ToDouble(Screen.Text)).ToString();
                        TextBox2.Text = Screen.Text;
                    }

                    break;                  

                case "CE": 
                    
                    Screen.Text = ""; TextBox2.Text = null; TextBox1.Text = null; 
                    
                    break;

                case ",":

                    if (TextBox2.Text.IndexOf(',') == -1)
                    {
                        if(String.IsNullOrEmpty(Screen.Text))
                        {
                            Screen.Text += "0,";
                            TextBox2.Text += ",";
                        }
                        else 
                        {
                            Screen.Text += ",";
                            TextBox2.Text += ",";
                        }
                        
                    }

                    break;
                case "+":
                   
                    TextBox1.Text = TextBox2.Text;
                    Screen.Text = Screen.Text + "+";
                    TextBox3.Text = x.Text;
                    TextBox2.Text = null;
                    
                    break;

                case "-":

                    TextBox1.Text = TextBox2.Text;
                    Screen.Text = Screen.Text + "-";
                    TextBox3.Text = x.Text;
                    TextBox2.Text = null;

                    break;

                case "*":

                    TextBox1.Text = TextBox2.Text;
                    Screen.Text = Screen.Text + "*";
                    TextBox3.Text = x.Text;
                    TextBox2.Text = null;

                    break;

                case "/":

                    TextBox1.Text = TextBox2.Text;
                    Screen.Text = TextBox1.Text + "/";
                    TextBox3.Text = x.Text;
                    TextBox2.Text = null;

                    break;

                case "=":

                    char FirstElement = Screen.Text[0];
                    bool number = char.IsDigit(FirstElement); //checking if the first element in the Screen is a number or not
                    if (FirstElement.Equals('+') || Screen.Text[Screen.Text.Length-1].Equals('+') || FirstElement.Equals('-') || Screen.Text[Screen.Text.Length - 1].Equals('-') || FirstElement.Equals('*') || Screen.Text[Screen.Text.Length - 1].Equals('*') || FirstElement.Equals('/') || Screen.Text[Screen.Text.Length - 1].Equals('/') || Screen.Text[Screen.Text.Length - 1].Equals(','))
                    {
                        Screen.Text = "Błąd";                       
                    }
                    else if (FirstElement.Equals('B'))
                    {
                        Screen.Text = "Błąd, wyczyść ekran aby kontynuować";
                    }
                    else if (FirstElement.Equals(number) && !String.IsNullOrEmpty(TextBox1.Text) && !String.IsNullOrEmpty(TextBox2.Text) && !String.IsNullOrEmpty(TextBox3.Text))
                    {
                        Screen.Text = "Błąd, wyczyść ekran aby kontynuować";
                    }
                    else
                    {

                        switch (TextBox3.Text)
                        {
                            case "+":

                                if (FirstElement.Equals(number) && (!String.IsNullOrEmpty(TextBox1.Text) || !String.IsNullOrEmpty(TextBox2.Text) || !String.IsNullOrEmpty(TextBox3.Text)))
                                {
                                    Screen.Text = "Błąd, wyczyść ekran aby kontynuować";
                                }
                                else
                                {
                                    Screen.Text = (Convert.ToDouble(TextBox1.Text) +
                                    Convert.ToDouble(TextBox2.Text)).ToString();
                                    TextBox2.Text = Screen.Text;                                   
                                }
                                break;
                               

                            case "-":

                                if (FirstElement.Equals(number) && (!String.IsNullOrEmpty(TextBox1.Text) || !String.IsNullOrEmpty(TextBox2.Text) || !String.IsNullOrEmpty(TextBox3.Text)))
                                {
                                    Screen.Text = "Błąd, wyczyść ekran aby kontynuować";
                                }
                                else
                                {
                                    Screen.Text = (Convert.ToDouble(TextBox1.Text) -
                                    Convert.ToDouble(TextBox2.Text)).ToString();
                                    TextBox2.Text = Screen.Text;
                                }
                                break;

                            case "*":

                                if (FirstElement.Equals(number) && (!String.IsNullOrEmpty(TextBox1.Text) || !String.IsNullOrEmpty(TextBox2.Text) || !String.IsNullOrEmpty(TextBox3.Text)))
                                {
                                    Screen.Text = "Błąd, wyczyść ekran aby kontynuować";
                                }
                                else
                                {
                                    Screen.Text = (Convert.ToDouble(TextBox1.Text) *
                                    Convert.ToDouble(TextBox2.Text)).ToString();
                                    TextBox2.Text = Screen.Text;
                                }
                                break;

                            case "/":

                                if (FirstElement.Equals(number) && (!String.IsNullOrEmpty(TextBox1.Text) || !String.IsNullOrEmpty(TextBox2.Text) || !String.IsNullOrEmpty(TextBox3.Text)))
                                {
                                    Screen.Text = "Błąd, wyczyść ekran aby kontynuować";
                                }
                                else
                                {
                                    Screen.Text = (Convert.ToDouble(TextBox1.Text) /
                                    Convert.ToDouble(TextBox2.Text)).ToString();
                                    TextBox2.Text = Screen.Text;
                                }
                                break;
                        }
                    }
               break;
                
                default:

                    TextBox2.Text = Convert.ToDouble(TextBox2.Text + x.Text).ToString();
                    Screen.Text = (Screen.Text + x.Text).ToString();
                    break;
            }
        }
    }
}