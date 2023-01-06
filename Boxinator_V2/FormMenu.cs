// using Boxinator_V2.Attribute;
using Boxinator_V2.Usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxinator_V2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            home hm = new home();
            addUserControl(hm);
     
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMainWindow.Controls.Clear();
            panelMainWindow.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void highlightButton(Button button)
        {
            Button[] buttons = { dashboardButton, newButton, openButton, saveButton, categoryButton, docsButton };
            foreach (Button b in buttons)
            {
                if (b == button) 
                {
                    b.BackColor = Color.FromArgb(127, 92, 255);
                }
                else
                {
                    b.BackColor = Color.FromArgb(7, 14, 21);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Logotype_Click(object sender, EventArgs e)
        {
            highlightButton(null);
            home hm = new home();
            addUserControl(hm);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            highlightButton(openButton);
            openProject opP = new openProject();
            addUserControl(opP);
        }

        private void panelMainWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            highlightButton(dashboardButton);
            dboard db = new dboard();
            addUserControl(db);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            highlightButton(newButton);
            newProject np = new newProject();
            addUserControl(np);
        }
		
		//  private void addUserControl_1(SAttri Attribute)
        // {
        //     // Attribute.name = DockStyle.Fill;
		// 	// Attribute.name = .ToString();
        //     panelMainWindow.Controls.Clear();
        //     // panelMainWindow.Controls.Add(Attribute);
        //     Attribute.ToString();
        // }
		
		// private void addUserContro_l(UserControl userControl)
        // {
        //     userControl.Dock = DockStyle.Fill;
        //     panelMainWindow.Controls.Clear();
        //     panelMainWindow.Controls.Add(userControl);
        //     userControl.BringToFront();
        // }
		private void categoryButton_Click(object sender, EventArgs e)
        {
			
			highlightButton(categoryButton);
            var SA = new SAttri();
			//SA.Setname(SA.Getname().ToString());
            // addUserControl();
			
            // highlightButton(categoryButton);
            // SAttri SA = new SAttri();
			
			// SA.Setname(SA.Getname().ToString());
			// var sa = SA.name;
			// categoryButton.(SA.Setname);
			// CategoryAttribute.Add(SA);
			
			// highlightButton(categoryButton);
            // home hm = new home();
            // addUserControl(hm);
        }

	}
}
