namespace examen
{
    partial class questiondirect
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
            this.numqueston = new System.Windows.Forms.Label();
            this.proposition = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numqueston
            // 
            this.numqueston.AutoSize = true;
            this.numqueston.Location = new System.Drawing.Point(97, 48);
            this.numqueston.Name = "numqueston";
            this.numqueston.Size = new System.Drawing.Size(67, 13);
            this.numqueston.TabIndex = 0;
            this.numqueston.Text = "numquestion";
            // 
            // proposition
            // 
            this.proposition.AutoSize = true;
            this.proposition.Location = new System.Drawing.Point(132, 114);
            this.proposition.Name = "proposition";
            this.proposition.Size = new System.Drawing.Size(58, 13);
            this.proposition.TabIndex = 1;
            this.proposition.Text = "proposition";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(98, 259);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 4;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(286, 259);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(75, 23);
            this.modifier.TabIndex = 5;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(460, 259);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(75, 23);
            this.supprimer.TabIndex = 6;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // questiondirect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.proposition);
            this.Controls.Add(this.numqueston);
            this.Name = "questiondirect";
            this.Text = "questiondirect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numqueston;
        private System.Windows.Forms.Label proposition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
    }
}