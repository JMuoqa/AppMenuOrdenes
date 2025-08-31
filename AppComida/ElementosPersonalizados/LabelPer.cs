using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppComida.ElementosPersonalizados
{
    public class LabelPer : Label
    {
        public LabelPer() 
        {
            this.AutoSize = true;
            this.Font = new Font("Montserrat Medium", 14F, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.MaximumSize = new Size(256, 0);
            this.Margin = new Padding(this.Margin.Left, this.Margin.Top, this.Margin.Right, 10);
        }
    }
}
