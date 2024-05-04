using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Placeholder
{
    public static class PlaceholderManager
    {
        public static void AddPlaceholder(this TextBox tb, string placeholder)
        {
            tb.ForeColor= Color.Gray;
            tb.Text= placeholder;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {  
                    tb.Text=string.Empty;
                    tb.ForeColor= Color.Black;
                }

            };
            tb.Leave += (s, e) =>
            {
                if(tb.Text == string.Empty)
                {
                    tb.ForeColor = Color.Gray;
                    tb.Text = placeholder;
                }
            };
        }
    }
}
