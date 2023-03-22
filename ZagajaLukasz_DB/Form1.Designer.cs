namespace ZagajaLukasz_DB
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Imię = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mySqlConnection1 = new MySqlConnector.MySqlConnection();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.WyswietlButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imię,
            this.Nazwisko,
            this.Ocena});
            this.dataGridView1.Location = new System.Drawing.Point(95, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Imię
            // 
            this.Imię.HeaderText = "Imię";
            this.Imię.Name = "Imię";
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            // 
            // Ocena
            // 
            this.Ocena.HeaderText = "Ocena";
            this.Ocena.Name = "Ocena";
            // 
            // mySqlConnection1
            // 
            this.mySqlConnection1.ConnectionString = "server=localhost;database=bazadanych_visual;uid=root;pwd=";
            this.mySqlConnection1.ProvideClientCertificatesCallback = null;
            this.mySqlConnection1.ProvidePasswordCallback = null;
            this.mySqlConnection1.RemoteCertificateValidationCallback = null;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandText = "SELECT * FROM uczniowie;";
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = this.mySqlConnection1;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // WyswietlButton
            // 
            this.WyswietlButton.Location = new System.Drawing.Point(189, 226);
            this.WyswietlButton.Name = "WyswietlButton";
            this.WyswietlButton.Size = new System.Drawing.Size(164, 51);
            this.WyswietlButton.TabIndex = 1;
            this.WyswietlButton.Text = "Wyświetl";
            this.WyswietlButton.UseVisualStyleBackColor = true;
            this.WyswietlButton.Click += new System.EventHandler(this.WyswietlButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WyswietlButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imię;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocena;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MySqlConnector.MySqlConnection mySqlConnection1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button WyswietlButton;
    }
}

