namespace examen
{
    partial class examen
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.exam = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.duree = new System.Windows.Forms.Label();
            this.matiere = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exam
            // 
            this.exam.AutoSize = true;
            this.exam.Location = new System.Drawing.Point(130, 47);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(40, 13);
            this.exam.TabIndex = 0;
            this.exam.Text = "idexam";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(258, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 20);
            this.textBox3.TabIndex = 3;
            // 
            // duree
            // 
            this.duree.AutoSize = true;
            this.duree.Location = new System.Drawing.Point(135, 95);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(34, 13);
            this.duree.TabIndex = 4;
            this.duree.Text = "duree";
            // 
            // matiere
            // 
            this.matiere.AutoSize = true;
            this.matiere.Location = new System.Drawing.Point(135, 138);
            this.matiere.Name = "matiere";
            this.matiere.Size = new System.Drawing.Size(41, 13);
            this.matiere.TabIndex = 5;
            this.matiere.Text = "matiere";
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(563, 32);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(99, 43);
            this.valider.TabIndex = 6;
            this.valider.Text = "valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(563, 95);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(99, 45);
            this.question.TabIndex = 7;
            this.question.Text = "question";
            this.question.UseVisualStyleBackColor = true;
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.question);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.matiere);
            this.Controls.Add(this.duree);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exam);
            this.Name = "examen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label duree;
        private System.Windows.Forms.Label matiere;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button question;
    }
}

