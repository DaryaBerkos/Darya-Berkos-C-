using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public class Task1
    {
       public static void TaskOne(string text)
       {
            {
                try
                {     
                    int x = Convert.ToInt32(text);

                    if (x >= 7)
                    {
                        MessageBox.Show("Привет");
                    }
                    else
                    {
                        MessageBox.Show("Число меньше 7");
                    }
                }

                catch (FormatException)
                {
                    MessageBox.Show("Введите цифру, а не букву: ");
                }
            }   
       }

    }
}

            
