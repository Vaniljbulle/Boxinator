using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxinator_V2.Usercontrol
{
    public partial class newProject : UserControl
    {
        public newProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Chose video file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "mp4",
                Filter = "mp4 files (*.mp4)|*.mp4",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void ProjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SAttri SA = new SAttri();
            SA.Namee = comboBox1.Text;
            /*this.comboBox1.Text = ;*/
            //this.comboBox1. .Items.Add(SA.Namee);
            this.comboBox1.Items.Add(SA.Namee);
            
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
