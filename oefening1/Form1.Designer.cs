namespace oefening1
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
            this.listoefening1 = new System.Windows.Forms.ListBox();
            this.Mijntext = new System.Windows.Forms.TextBox();
            this.but1oefening1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listoefening1
            // 
            this.listoefening1.FormattingEnabled = true;
            this.listoefening1.Location = new System.Drawing.Point(67, 26);
            this.listoefening1.Name = "listoefening1";
            this.listoefening1.Size = new System.Drawing.Size(120, 95);
            this.listoefening1.TabIndex = 0;
            // 
            // Mijntext
            // 
            this.Mijntext.Location = new System.Drawing.Point(115, 188);
            this.Mijntext.Name = "Mijntext";
            this.Mijntext.Size = new System.Drawing.Size(100, 20);
            this.Mijntext.TabIndex = 1;
            this.Mijntext.Text = "gdg";
            this.Mijntext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mijntext_KeyDown);
            // 
            // but1oefening1
            // 
            this.but1oefening1.Location = new System.Drawing.Point(338, 188);
            this.but1oefening1.Name = "but1oefening1";
            this.but1oefening1.Size = new System.Drawing.Size(75, 23);
            this.but1oefening1.TabIndex = 2;
            this.but1oefening1.Text = "Toevoegen!";
            this.but1oefening1.UseVisualStyleBackColor = true;
            this.but1oefening1.Click += new System.EventHandler(this.but1oefening1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but1oefening1);
            this.Controls.Add(this.Mijntext);
            this.Controls.Add(this.listoefening1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listoefening1;
        private System.Windows.Forms.TextBox Mijntext;
        private System.Windows.Forms.Button but1oefening1;
    }
}

