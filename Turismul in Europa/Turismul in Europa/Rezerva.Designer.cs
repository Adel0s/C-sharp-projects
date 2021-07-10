namespace Turismul_in_Europa
{
    partial class Rezerva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezerva));
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(806, 245);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(60, 60);
            this.next.TabIndex = 1;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.Transparent;
            this.prev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prev.BackgroundImage")));
            this.prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prev.FlatAppearance.BorderSize = 0;
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Location = new System.Drawing.Point(6, 245);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(60, 60);
            this.prev.TabIndex = 2;
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(72, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 507);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(377, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pagina ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(63)))), ((int)(((byte)(191)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(624, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rezervă acum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(63)))), ((int)(((byte)(191)))));
            this.button2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Vacantele mele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rezerva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(876, 632);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Name = "Rezerva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezerva";
            this.Load += new System.EventHandler(this.Rezerva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}