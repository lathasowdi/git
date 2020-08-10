namespace oefening2
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
            this.cboefening2 = new System.Windows.Forms.ComboBox();
            this.butoefening2 = new System.Windows.Forms.Button();
            this.laboefening1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboefening2
            // 
            this.cboefening2.FormattingEnabled = true;
            this.cboefening2.Location = new System.Drawing.Point(81, 79);
            this.cboefening2.Name = "cboefening2";
            this.cboefening2.Size = new System.Drawing.Size(121, 21);
            this.cboefening2.TabIndex = 0;
            this.cboefening2.SelectedIndexChanged += new System.EventHandler(this.cboefening2_SelectedIndexChanged);
            // 
            // butoefening2
            // 
            this.butoefening2.Location = new System.Drawing.Point(278, 153);
            this.butoefening2.Name = "butoefening2";
            this.butoefening2.Size = new System.Drawing.Size(75, 23);
            this.butoefening2.TabIndex = 1;
            this.butoefening2.Text = "Druk ";
            this.butoefening2.UseVisualStyleBackColor = true;
            this.butoefening2.Click += new System.EventHandler(this.butoefening2_Click);
            // 
            // laboefening1
            // 
            this.laboefening1.AutoSize = true;
            this.laboefening1.Location = new System.Drawing.Point(106, 116);
            this.laboefening1.Name = "laboefening1";
            this.laboefening1.Size = new System.Drawing.Size(52, 13);
            this.laboefening1.TabIndex = 2;
            this.laboefening1.Text = "MijnLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laboefening1);
            this.Controls.Add(this.butoefening2);
            this.Controls.Add(this.cboefening2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboefening2;
        private System.Windows.Forms.Button butoefening2;
        private System.Windows.Forms.Label laboefening1;
    }
}

