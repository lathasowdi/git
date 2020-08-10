namespace oefening4
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
            this.cboefening4 = new System.Windows.Forms.ComboBox();
            this.butoefening4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboefening4
            // 
            this.cboefening4.FormattingEnabled = true;
            this.cboefening4.Location = new System.Drawing.Point(93, 69);
            this.cboefening4.Name = "cboefening4";
            this.cboefening4.Size = new System.Drawing.Size(121, 21);
            this.cboefening4.TabIndex = 0;
            // 
            // butoefening4
            // 
            this.butoefening4.Location = new System.Drawing.Point(84, 132);
            this.butoefening4.Name = "butoefening4";
            this.butoefening4.Size = new System.Drawing.Size(75, 23);
            this.butoefening4.TabIndex = 1;
            this.butoefening4.Text = "click";
            this.butoefening4.UseVisualStyleBackColor = true;
            this.butoefening4.Click += new System.EventHandler(this.butoefening4_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.butoefening4);
            this.Controls.Add(this.cboefening4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboefening4;
        private System.Windows.Forms.Button butoefening4;
    }
}

