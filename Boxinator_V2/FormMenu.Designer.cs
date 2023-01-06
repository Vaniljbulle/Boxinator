using System;

namespace Boxinator_V2
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.docsButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logotype = new System.Windows.Forms.PictureBox();
            this.panelMainWindow = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logotype)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.panelMenu.Controls.Add(this.docsButton);
            this.panelMenu.Controls.Add(this.categoryButton);
            this.panelMenu.Controls.Add(this.saveButton);
            this.panelMenu.Controls.Add(this.openButton);
            this.panelMenu.Controls.Add(this.newButton);
            this.panelMenu.Controls.Add(this.dashboardButton);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(270, 940);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // docsButton
            // 
            this.docsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.docsButton.FlatAppearance.BorderSize = 0;
            this.docsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.docsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.docsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.docsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.docsButton.Image = ((System.Drawing.Image)(resources.GetObject("docsButton.Image")));
            this.docsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.docsButton.Location = new System.Drawing.Point(0, 473);
            this.docsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.docsButton.Name = "docsButton";
            this.docsButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.docsButton.Size = new System.Drawing.Size(270, 77);
            this.docsButton.TabIndex = 6;
            this.docsButton.Text = " Documentation";
            this.docsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.docsButton.UseVisualStyleBackColor = true;
            // 
            // categoryButton
            // 
            this.categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.categoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.categoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryButton.Image = ((System.Drawing.Image)(resources.GetObject("categoryButton.Image")));
            this.categoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.Location = new System.Drawing.Point(0, 396);
            this.categoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.categoryButton.Size = new System.Drawing.Size(270, 77);
            this.categoryButton.TabIndex = 5;
            this.categoryButton.Text = " Categories";
            this.categoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categoryButton.UseVisualStyleBackColor = true;
            //this.categoryButton.Click += new System.EventHandler(this.categoryButton);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(0, 319);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.saveButton.Size = new System.Drawing.Size(270, 77);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = " Save";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // openButton
            // 
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.openButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.openButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openButton.Location = new System.Drawing.Point(0, 242);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openButton.Name = "openButton";
            this.openButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.openButton.Size = new System.Drawing.Size(270, 77);
            this.openButton.TabIndex = 3;
            this.openButton.Text = " Open";
            this.openButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // newButton
            // 
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.newButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(0, 165);
            this.newButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newButton.Name = "newButton";
            this.newButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.newButton.Size = new System.Drawing.Size(270, 77);
            this.newButton.TabIndex = 2;
            this.newButton.Text = " New";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.dashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 88);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(270, 77);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = " Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Logotype);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 88);
            this.panel1.TabIndex = 0;
            // 
            // Logotype
            // 
            this.Logotype.Image = ((System.Drawing.Image)(resources.GetObject("Logotype.Image")));
            this.Logotype.Location = new System.Drawing.Point(18, 18);
            this.Logotype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logotype.Name = "Logotype";
            this.Logotype.Size = new System.Drawing.Size(234, 60);
            this.Logotype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logotype.TabIndex = 0;
            this.Logotype.TabStop = false;
            this.Logotype.Click += new System.EventHandler(this.Logotype_Click);
            // 
            // panelMainWindow
            // 
            this.panelMainWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.panelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainWindow.Location = new System.Drawing.Point(270, 0);
            this.panelMainWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMainWindow.Name = "panelMainWindow";
            this.panelMainWindow.Size = new System.Drawing.Size(1221, 940);
            this.panelMainWindow.TabIndex = 1;
            this.panelMainWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainWindow_Paint);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 940);
            this.Controls.Add(this.panelMainWindow);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logotype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button docsButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logotype;
        private System.Windows.Forms.Panel panelMainWindow;
    }
}

