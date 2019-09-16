namespace Cinéma
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_numerosalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.cache = new System.Windows.Forms.Panel();
            this.lestring = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nbplace = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_reduction = new System.Windows.Forms.CheckBox();
            this.nbplace = new System.Windows.Forms.Button();
            this.labelcache = new System.Windows.Forms.Label();
            this.affiche = new System.Windows.Forms.Label();
            this.cache.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinéma";
            // 
            // tb_numerosalle
            // 
            this.tb_numerosalle.Location = new System.Drawing.Point(304, 19);
            this.tb_numerosalle.Name = "tb_numerosalle";
            this.tb_numerosalle.Size = new System.Drawing.Size(100, 20);
            this.tb_numerosalle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saisir le numéro de la salle ";
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(537, 19);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 3;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // cache
            // 
            this.cache.Controls.Add(this.labelcache);
            this.cache.Controls.Add(this.nbplace);
            this.cache.Controls.Add(this.cb_reduction);
            this.cache.Controls.Add(this.tb_nbplace);
            this.cache.Controls.Add(this.label3);
            this.cache.Controls.Add(this.lestring);
            this.cache.Location = new System.Drawing.Point(13, 121);
            this.cache.Name = "cache";
            this.cache.Size = new System.Drawing.Size(778, 227);
            this.cache.TabIndex = 4;
            this.cache.Visible = false;
            // 
            // lestring
            // 
            this.lestring.AutoSize = true;
            this.lestring.Location = new System.Drawing.Point(335, 31);
            this.lestring.Name = "lestring";
            this.lestring.Size = new System.Drawing.Size(35, 13);
            this.lestring.TabIndex = 0;
            this.lestring.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de place a acheter";
            // 
            // tb_nbplace
            // 
            this.tb_nbplace.Location = new System.Drawing.Point(201, 179);
            this.tb_nbplace.Name = "tb_nbplace";
            this.tb_nbplace.Size = new System.Drawing.Size(100, 20);
            this.tb_nbplace.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Valider);
            this.panel1.Controls.Add(this.tb_numerosalle);
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 60);
            this.panel1.TabIndex = 5;
            // 
            // cb_reduction
            // 
            this.cb_reduction.AutoSize = true;
            this.cb_reduction.Location = new System.Drawing.Point(343, 179);
            this.cb_reduction.Name = "cb_reduction";
            this.cb_reduction.Size = new System.Drawing.Size(75, 17);
            this.cb_reduction.TabIndex = 5;
            this.cb_reduction.Text = "Reduction";
            this.cb_reduction.UseVisualStyleBackColor = true;
            // 
            // nbplace
            // 
            this.nbplace.Location = new System.Drawing.Point(537, 173);
            this.nbplace.Name = "nbplace";
            this.nbplace.Size = new System.Drawing.Size(75, 23);
            this.nbplace.TabIndex = 6;
            this.nbplace.Text = "Valider";
            this.nbplace.UseVisualStyleBackColor = true;
            this.nbplace.Click += new System.EventHandler(this.Nbplace_Click);
            // 
            // labelcache
            // 
            this.labelcache.AutoSize = true;
            this.labelcache.Location = new System.Drawing.Point(681, 90);
            this.labelcache.Name = "labelcache";
            this.labelcache.Size = new System.Drawing.Size(35, 13);
            this.labelcache.TabIndex = 7;
            this.labelcache.Text = "label3";
            this.labelcache.Visible = false;
            // 
            // affiche
            // 
            this.affiche.AutoSize = true;
            this.affiche.Location = new System.Drawing.Point(353, 386);
            this.affiche.Name = "affiche";
            this.affiche.Size = new System.Drawing.Size(0, 13);
            this.affiche.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.affiche);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cache);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cache.ResumeLayout(false);
            this.cache.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_numerosalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Panel cache;
        private System.Windows.Forms.Label lestring;
        private System.Windows.Forms.TextBox tb_nbplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nbplace;
        private System.Windows.Forms.CheckBox cb_reduction;
        private System.Windows.Forms.Label labelcache;
        private System.Windows.Forms.Label affiche;
    }
}

