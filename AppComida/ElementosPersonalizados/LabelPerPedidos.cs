using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComida.ElementosPersonalizados
{
    public class LabelPerPedidos:Label
    {
        public LabelPerPedidos(string id, string str)
        {
            this.AutoSize = true;
            this.Font = new Font("Montserrat", 12F, FontStyle.Regular);
            this.Margin = new Padding(left: 3, top: 3, right: 3, bottom: 5);
            this.Name = $"{str}_{id}";
        }
    }
}
