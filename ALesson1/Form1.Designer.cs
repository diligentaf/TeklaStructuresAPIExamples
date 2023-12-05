
namespace ALesson1
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
            this.drw_beam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drw_beam
            // 
            this.drw_beam.Location = new System.Drawing.Point(273, 137);
            this.drw_beam.Name = "drw_beam";
            this.drw_beam.Size = new System.Drawing.Size(226, 135);
            this.drw_beam.TabIndex = 1;
            this.drw_beam.Text = "Draw Button";
            this.drw_beam.UseVisualStyleBackColor = true;
            this.drw_beam.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drw_beam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drw_beam;
    }
}

