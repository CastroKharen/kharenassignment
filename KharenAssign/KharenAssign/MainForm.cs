using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KharenAssign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 frm2 = new Form2();
                frm2.ShowDialog();

                int k = Convert.ToInt16(frm2.txt.Text) + Convert.ToInt16(btnMain.Text);
                btnMain.Text = k.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }            
        }
    }
}
