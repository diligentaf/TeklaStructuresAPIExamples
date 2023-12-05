
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
            this.create_polybeam_click = new System.Windows.Forms.Button();
            this.profile_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drw_beam
            // 
            this.drw_beam.Location = new System.Drawing.Point(318, 45);
            this.drw_beam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.drw_beam.Name = "drw_beam";
            this.drw_beam.Size = new System.Drawing.Size(176, 40);
            this.drw_beam.TabIndex = 1;
            this.drw_beam.Text = "빔 그리기";
            this.drw_beam.UseVisualStyleBackColor = true;
            this.drw_beam.Click += new System.EventHandler(this.button2_Click);
            // 
            // create_polybeam_click
            // 
            this.create_polybeam_click.Location = new System.Drawing.Point(318, 105);
            this.create_polybeam_click.Name = "create_polybeam_click";
            this.create_polybeam_click.Size = new System.Drawing.Size(180, 36);
            this.create_polybeam_click.TabIndex = 2;
            this.create_polybeam_click.Text = "폴리빔 그리기";
            this.create_polybeam_click.UseVisualStyleBackColor = true;
            this.create_polybeam_click.Click += new System.EventHandler(this.create_polybeam_click_Click);
            // 
            // profile_text
            // 
            this.profile_text.Location = new System.Drawing.Point(114, 105);
            this.profile_text.Name = "profile_text";
            this.profile_text.Size = new System.Drawing.Size(160, 35);
            this.profile_text.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 900);
            this.Controls.Add(this.profile_text);
            this.Controls.Add(this.create_polybeam_click);
            this.Controls.Add(this.drw_beam);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drw_beam;
        private System.Windows.Forms.Button create_polybeam_click;
        private System.Windows.Forms.TextBox profile_text;
    }
}

