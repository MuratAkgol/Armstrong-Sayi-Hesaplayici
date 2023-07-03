namespace WindowsFormsApp1
{
    partial class Sayı_genel_hesaplama
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
            this.lb_genel = new System.Windows.Forms.ListBox();
            this.lb_bulunan = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_genel
            // 
            this.lb_genel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_genel.FormattingEnabled = true;
            this.lb_genel.ItemHeight = 16;
            this.lb_genel.Location = new System.Drawing.Point(0, 0);
            this.lb_genel.Name = "lb_genel";
            this.lb_genel.Size = new System.Drawing.Size(324, 714);
            this.lb_genel.TabIndex = 0;
            this.lb_genel.SelectedIndexChanged += new System.EventHandler(this.lb_genel_SelectedIndexChanged);
            // 
            // lb_bulunan
            // 
            this.lb_bulunan.FormattingEnabled = true;
            this.lb_bulunan.ItemHeight = 16;
            this.lb_bulunan.Location = new System.Drawing.Point(359, 98);
            this.lb_bulunan.Name = "lb_bulunan";
            this.lb_bulunan.Size = new System.Drawing.Size(324, 180);
            this.lb_bulunan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(354, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bulunan Armstrong sayıları";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._8011592;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(744, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 26);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Sayı_genel_hesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 714);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_bulunan);
            this.Controls.Add(this.lb_genel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sayı_genel_hesaplama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otomatik hesaplayıcı";
            this.Load += new System.EventHandler(this.Sayı_genel_hesaplama_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sayı_genel_hesaplama_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sayı_genel_hesaplama_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sayı_genel_hesaplama_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_genel;
        private System.Windows.Forms.ListBox lb_bulunan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}