using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.characterButton = new System.Windows.Forms.Button();
            this.statusTextbox = new System.Windows.Forms.TextBox();
            this.characterBox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // characterButton
            // 
            this.characterButton.Location = new System.Drawing.Point(478, 180);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(100, 23);
            this.characterButton.TabIndex = 0;
            this.characterButton.Text = "accept";
            this.characterButton.UseVisualStyleBackColor = true;
            this.characterButton.Click += new System.EventHandler(this.acctepCallback);
            // 
            // statusTextbox
            // 
            this.statusTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusTextbox.Location = new System.Drawing.Point(79, 70);
            this.statusTextbox.Name = "statusTextbox";
            this.statusTextbox.ReadOnly = true;
            this.statusTextbox.Size = new System.Drawing.Size(379, 30);
            this.statusTextbox.TabIndex = 1;
            this.statusTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // characterBox
            // 
            this.characterBox.Location = new System.Drawing.Point(478, 139);
            this.characterBox.MaxLength = 1;
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(100, 20);
            this.characterBox.TabIndex = 2;
            this.characterBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(79, 112);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(379, 160);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(478, 210);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 29);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 312);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.characterBox);
            this.Controls.Add(this.statusTextbox);
            this.Controls.Add(this.characterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button characterButton;
        private System.Windows.Forms.TextBox statusTextbox;
        private System.Windows.Forms.TextBox characterBox;
        private System.Windows.Forms.Panel panel;
        private Button resetButton;
    }
}

