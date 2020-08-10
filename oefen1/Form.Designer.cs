namespace oefen1
{
    partial class Form
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
            this.lblMijnLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbLeerlingen = new System.Windows.Forms.ComboBox();
            this.lbLeerlingen = new System.Windows.Forms.ListBox();
            this.Mijntext = new System.Windows.Forms.TextBox();
            this.buttoevoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMijnLabel
            // 
            this.lblMijnLabel.AutoSize = true;
            this.lblMijnLabel.Location = new System.Drawing.Point(56, 31);
            this.lblMijnLabel.Name = "lblMijnLabel";
            this.lblMijnLabel.Size = new System.Drawing.Size(55, 13);
            this.lblMijnLabel.TabIndex = 0;
            this.lblMijnLabel.Text = "Mijn Label";
            this.lblMijnLabel.Click += new System.EventHandler(this.lblMijnLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "klick mij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbLeerlingen
            // 
            this.cbLeerlingen.FormattingEnabled = true;
            this.cbLeerlingen.Location = new System.Drawing.Point(44, 127);
            this.cbLeerlingen.Name = "cbLeerlingen";
            this.cbLeerlingen.Size = new System.Drawing.Size(121, 21);
            this.cbLeerlingen.TabIndex = 2;
            this.cbLeerlingen.SelectedIndexChanged += new System.EventHandler(this.cbLeerlingen_SelectedIndexChanged_1);
            // 
            // lbLeerlingen
            // 
            this.lbLeerlingen.FormattingEnabled = true;
            this.lbLeerlingen.Location = new System.Drawing.Point(73, 187);
            this.lbLeerlingen.Name = "lbLeerlingen";
            this.lbLeerlingen.Size = new System.Drawing.Size(120, 95);
            this.lbLeerlingen.TabIndex = 3;
            this.lbLeerlingen.SelectedIndexChanged += new System.EventHandler(this.lbLeerlingen_SelectedIndexChanged);
            // 
            // Mijntext
            // 
            this.Mijntext.Location = new System.Drawing.Point(108, 314);
            this.Mijntext.Name = "Mijntext";
            this.Mijntext.Size = new System.Drawing.Size(100, 20);
            this.Mijntext.TabIndex = 4;
            this.Mijntext.TextChanged += new System.EventHandler(this.Mijntext_TextChanged);
            // 
            // buttoevoe
            // 
            this.buttoevoe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoevoe.Location = new System.Drawing.Point(674, 398);
            this.buttoevoe.Name = "buttoevoe";
            this.buttoevoe.Size = new System.Drawing.Size(75, 23);
            this.buttoevoe.TabIndex = 5;
            this.buttoevoe.Text = "Toevoegen!";
            this.buttoevoe.UseVisualStyleBackColor = true;
            this.buttoevoe.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoevoe);
            this.Controls.Add(this.Mijntext);
            this.Controls.Add(this.lbLeerlingen);
            this.Controls.Add(this.cbLeerlingen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMijnLabel);
            this.Name = "Form1";
            this.Text = "Mijn App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMijnLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbLeerlingen;
        private System.Windows.Forms.ListBox lbLeerlingen;
        private System.Windows.Forms.TextBox Mijntext;
        private System.Windows.Forms.Button buttoevoe;
    }
}

