using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class szamitogep:aru
    {
        public string cpu { get; set; }
        public int ram { get; set; }
        public string op { get; set; }

        public override void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = nev;
            MessageBox.Show($"Számítógép összes tulajdonsága: \n CPU:{cpu} \n RAM: {ram} \n Operációs rendszer: {op}");
        }
    }
}
