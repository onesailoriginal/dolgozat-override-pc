using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class aru : UserControl
    {
        public Button button1;

        public int ar { get; set; }
        public string nev { get; set; }
        public aru()
        {
            InitializeComponent();
        }

        public virtual void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "asd";
            MessageBox.Show($"Ára: {ar}");
        }

        public void changeButtonName()
        {
            button1.Text = $"{nev}";
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // aru
            // 
            this.Controls.Add(this.button1);
            this.Name = "aru";
            this.Size = new System.Drawing.Size(82, 23);
            this.ResumeLayout(false);

        }

        public virtual void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Ára: {ar}");
        }
    }
}
