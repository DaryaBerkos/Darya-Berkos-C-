using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
   public class Task2
   {  

        public static void TaskTwo (string name)
        {

            if (name == "Вячеслав")
            {
                MessageBox.Show("Привет, Вячеслав");
            }
            else
            {
                MessageBox.Show("Нету такого имени");
            }
        }
    }
}
