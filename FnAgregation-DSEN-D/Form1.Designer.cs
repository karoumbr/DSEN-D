namespace FnAgregation_DSEN_D
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCountClients = new System.Windows.Forms.Button();
            this.btnMoyenneSoldes = new System.Windows.Forms.Button();
            this.btnSoldeMin = new System.Windows.Forms.Button();
            this.btnSoldeMax = new System.Windows.Forms.Button();
            this.btnSommeSoldes = new System.Windows.Forms.Button();
            this.txtCountClients = new System.Windows.Forms.TextBox();
            this.txtMoyenneSoldes = new System.Windows.Forms.TextBox();
            this.txtSoldeMin = new System.Windows.Forms.TextBox();
            this.txtSoldeMax = new System.Windows.Forms.TextBox();
            this.txtSommeSoldes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdDebiteur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCrediteur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMontantTransfert = new System.Windows.Forms.TextBox();
            this.btnTransfert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCountClients
            // 
            this.btnCountClients.Location = new System.Drawing.Point(26, 44);
            this.btnCountClients.Margin = new System.Windows.Forms.Padding(2);
            this.btnCountClients.Name = "btnCountClients";
            this.btnCountClients.Size = new System.Drawing.Size(106, 19);
            this.btnCountClients.TabIndex = 0;
            this.btnCountClients.Text = "Nombre de clients";
            this.btnCountClients.UseVisualStyleBackColor = true;
            this.btnCountClients.Click += new System.EventHandler(this.btnCountClients_Click);
            // 
            // btnMoyenneSoldes
            // 
            this.btnMoyenneSoldes.Location = new System.Drawing.Point(26, 90);
            this.btnMoyenneSoldes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoyenneSoldes.Name = "btnMoyenneSoldes";
            this.btnMoyenneSoldes.Size = new System.Drawing.Size(106, 19);
            this.btnMoyenneSoldes.TabIndex = 1;
            this.btnMoyenneSoldes.Text = "Moyenne Soldes";
            this.btnMoyenneSoldes.UseVisualStyleBackColor = true;
            this.btnMoyenneSoldes.Click += new System.EventHandler(this.btnMoyenneSoldes_Click);
            // 
            // btnSoldeMin
            // 
            this.btnSoldeMin.Location = new System.Drawing.Point(26, 129);
            this.btnSoldeMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoldeMin.Name = "btnSoldeMin";
            this.btnSoldeMin.Size = new System.Drawing.Size(106, 19);
            this.btnSoldeMin.TabIndex = 2;
            this.btnSoldeMin.Text = "Solde Minimal";
            this.btnSoldeMin.UseVisualStyleBackColor = true;
            this.btnSoldeMin.Click += new System.EventHandler(this.btnSoldeMin_Click);
            // 
            // btnSoldeMax
            // 
            this.btnSoldeMax.Location = new System.Drawing.Point(26, 167);
            this.btnSoldeMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoldeMax.Name = "btnSoldeMax";
            this.btnSoldeMax.Size = new System.Drawing.Size(106, 19);
            this.btnSoldeMax.TabIndex = 3;
            this.btnSoldeMax.Text = "Solde Maximal";
            this.btnSoldeMax.UseVisualStyleBackColor = true;
            this.btnSoldeMax.Click += new System.EventHandler(this.btnSoldeMax_Click);
            // 
            // btnSommeSoldes
            // 
            this.btnSommeSoldes.Location = new System.Drawing.Point(26, 206);
            this.btnSommeSoldes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSommeSoldes.Name = "btnSommeSoldes";
            this.btnSommeSoldes.Size = new System.Drawing.Size(106, 19);
            this.btnSommeSoldes.TabIndex = 4;
            this.btnSommeSoldes.Text = "Somme Soldes";
            this.btnSommeSoldes.UseVisualStyleBackColor = true;
            this.btnSommeSoldes.Click += new System.EventHandler(this.btnSommeSoldes_Click);
            // 
            // txtCountClients
            // 
            this.txtCountClients.Location = new System.Drawing.Point(151, 44);
            this.txtCountClients.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountClients.Name = "txtCountClients";
            this.txtCountClients.Size = new System.Drawing.Size(76, 20);
            this.txtCountClients.TabIndex = 5;
            // 
            // txtMoyenneSoldes
            // 
            this.txtMoyenneSoldes.Location = new System.Drawing.Point(151, 90);
            this.txtMoyenneSoldes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoyenneSoldes.Name = "txtMoyenneSoldes";
            this.txtMoyenneSoldes.Size = new System.Drawing.Size(76, 20);
            this.txtMoyenneSoldes.TabIndex = 6;
            // 
            // txtSoldeMin
            // 
            this.txtSoldeMin.Location = new System.Drawing.Point(151, 129);
            this.txtSoldeMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoldeMin.Name = "txtSoldeMin";
            this.txtSoldeMin.Size = new System.Drawing.Size(76, 20);
            this.txtSoldeMin.TabIndex = 7;
            // 
            // txtSoldeMax
            // 
            this.txtSoldeMax.Location = new System.Drawing.Point(151, 167);
            this.txtSoldeMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoldeMax.Name = "txtSoldeMax";
            this.txtSoldeMax.Size = new System.Drawing.Size(76, 20);
            this.txtSoldeMax.TabIndex = 8;
            // 
            // txtSommeSoldes
            // 
            this.txtSommeSoldes.Location = new System.Drawing.Point(151, 206);
            this.txtSommeSoldes.Margin = new System.Windows.Forms.Padding(2);
            this.txtSommeSoldes.Name = "txtSommeSoldes";
            this.txtSommeSoldes.Size = new System.Drawing.Size(76, 20);
            this.txtSommeSoldes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Table \"Clients\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouterClient.ImageKey = "add.png";
            this.btnAjouterClient.ImageList = this.imageList1;
            this.btnAjouterClient.Location = new System.Drawing.Point(574, 260);
            this.btnAjouterClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(115, 41);
            this.btnAjouterClient.TabIndex = 11;
            this.btnAjouterClient.Text = "Ajouter Client";
            this.btnAjouterClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimerClient.ImageKey = "delete.png";
            this.btnSupprimerClient.ImageList = this.imageList1;
            this.btnSupprimerClient.Location = new System.Drawing.Point(717, 260);
            this.btnSupprimerClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(118, 41);
            this.btnSupprimerClient.TabIndex = 12;
            this.btnSupprimerClient.Text = "Supprimer Client";
            this.btnSupprimerClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.adresse,
            this.solde});
            this.dgvClients.Location = new System.Drawing.Point(258, 44);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(577, 201);
            this.dgvClients.TabIndex = 13;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 125;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "adresse";
            this.adresse.MinimumWidth = 6;
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            this.adresse.Width = 125;
            // 
            // solde
            // 
            this.solde.HeaderText = "solde";
            this.solde.MinimumWidth = 6;
            this.solde.Name = "solde";
            this.solde.ReadOnly = true;
            this.solde.Width = 125;
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(106, 386);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(100, 20);
            this.txtIdClient.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "id client";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(224, 384);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(91, 23);
            this.btnRecherche.TabIndex = 16;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "adresse";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(106, 412);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 19;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(106, 438);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 20;
            // 
            // txtSolde
            // 
            this.txtSolde.Location = new System.Drawing.Point(106, 464);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(100, 20);
            this.txtSolde.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "solde";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(106, 501);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Enregistrer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransfert);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMontantTransfert);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdCrediteur);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIdDebiteur);
            this.groupBox1.Location = new System.Drawing.Point(346, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 152);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfert";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "id client débiteur";
            // 
            // txtIdDebiteur
            // 
            this.txtIdDebiteur.Location = new System.Drawing.Point(17, 60);
            this.txtIdDebiteur.Name = "txtIdDebiteur";
            this.txtIdDebiteur.Size = new System.Drawing.Size(100, 20);
            this.txtIdDebiteur.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "id client créditeur";
            // 
            // txtIdCrediteur
            // 
            this.txtIdCrediteur.Location = new System.Drawing.Point(145, 60);
            this.txtIdCrediteur.Name = "txtIdCrediteur";
            this.txtIdCrediteur.Size = new System.Drawing.Size(100, 20);
            this.txtIdCrediteur.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "solde";
            // 
            // txtMontantTransfert
            // 
            this.txtMontantTransfert.Location = new System.Drawing.Point(261, 60);
            this.txtMontantTransfert.Name = "txtMontantTransfert";
            this.txtMontantTransfert.Size = new System.Drawing.Size(100, 20);
            this.txtMontantTransfert.TabIndex = 20;
            // 
            // btnTransfert
            // 
            this.btnTransfert.Location = new System.Drawing.Point(380, 57);
            this.btnTransfert.Name = "btnTransfert";
            this.btnTransfert.Size = new System.Drawing.Size(91, 23);
            this.btnTransfert.TabIndex = 22;
            this.btnTransfert.Text = "Transfert";
            this.btnTransfert.UseVisualStyleBackColor = true;
            this.btnTransfert.Click += new System.EventHandler(this.btnTransfert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSolde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSommeSoldes);
            this.Controls.Add(this.txtSoldeMax);
            this.Controls.Add(this.txtSoldeMin);
            this.Controls.Add(this.txtMoyenneSoldes);
            this.Controls.Add(this.txtCountClients);
            this.Controls.Add(this.btnSommeSoldes);
            this.Controls.Add(this.btnSoldeMax);
            this.Controls.Add(this.btnSoldeMin);
            this.Controls.Add(this.btnMoyenneSoldes);
            this.Controls.Add(this.btnCountClients);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountClients;
        private System.Windows.Forms.Button btnMoyenneSoldes;
        private System.Windows.Forms.Button btnSoldeMin;
        private System.Windows.Forms.Button btnSoldeMax;
        private System.Windows.Forms.Button btnSommeSoldes;
        private System.Windows.Forms.TextBox txtCountClients;
        private System.Windows.Forms.TextBox txtMoyenneSoldes;
        private System.Windows.Forms.TextBox txtSoldeMin;
        private System.Windows.Forms.TextBox txtSoldeMax;
        private System.Windows.Forms.TextBox txtSommeSoldes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn solde;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTransfert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMontantTransfert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdCrediteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdDebiteur;
    }
}

