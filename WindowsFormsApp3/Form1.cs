using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            szamitogep Szamitogep = new szamitogep() { 
                ar = 30000, cpu = "proci 1", ram = 32, op = "op 1", nev = "gep 1"
            };

            szamitogep Szamitogep2 = new szamitogep(){
                ar = 25000, cpu = "proci 2", ram = 8, op = "op 2", nev = "gep 2", Top= Szamitogep.Bottom+1
            };
        

            Szamitogep.changeButtonName();
            Szamitogep2.changeButtonName();

            this.Controls.Add(Szamitogep);
            this.Controls.Add(Szamitogep2);

            
           

        }
    }
}
