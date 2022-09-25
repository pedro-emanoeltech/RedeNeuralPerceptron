namespace RedeNeuralPerceptron
{
    partial class FrmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProcessaarProgressBar = new System.Windows.Forms.ProgressBar();
            this.CaminhoArquivoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.DadosGridView = new System.Windows.Forms.DataGridView();
            this.btnBuscarArquivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BiasTextBox = new System.Windows.Forms.TextBox();
            this.btnProcessa = new System.Windows.Forms.Button();
            this.ResultadoCalculolistView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.PesosGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DadosGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessaarProgressBar
            // 
            this.ProcessaarProgressBar.Location = new System.Drawing.Point(12, 334);
            this.ProcessaarProgressBar.Name = "ProcessaarProgressBar";
            this.ProcessaarProgressBar.Size = new System.Drawing.Size(415, 23);
            this.ProcessaarProgressBar.TabIndex = 0;
            // 
            // CaminhoArquivoTextBox
            // 
            this.CaminhoArquivoTextBox.Location = new System.Drawing.Point(12, 39);
            this.CaminhoArquivoTextBox.Name = "CaminhoArquivoTextBox";
            this.CaminhoArquivoTextBox.Size = new System.Drawing.Size(177, 20);
            this.CaminhoArquivoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho arquivo";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // DadosGridView
            // 
            this.DadosGridView.AllowUserToAddRows = false;
            this.DadosGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.DadosGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DadosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DadosGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DadosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DadosGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DadosGridView.Location = new System.Drawing.Point(15, 69);
            this.DadosGridView.MultiSelect = false;
            this.DadosGridView.Name = "DadosGridView";
            this.DadosGridView.ReadOnly = true;
            dataGridViewCellStyle2.NullValue = null;
            this.DadosGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DadosGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DadosGridView.Size = new System.Drawing.Size(412, 116);
            this.DadosGridView.TabIndex = 3;
            this.DadosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBuscarArquivo
            // 
            this.btnBuscarArquivo.Location = new System.Drawing.Point(195, 34);
            this.btnBuscarArquivo.Name = "btnBuscarArquivo";
            this.btnBuscarArquivo.Size = new System.Drawing.Size(91, 29);
            this.btnBuscarArquivo.TabIndex = 4;
            this.btnBuscarArquivo.Text = "Buscar arquivo";
            this.btnBuscarArquivo.UseVisualStyleBackColor = true;
            this.btnBuscarArquivo.Click += new System.EventHandler(this.btnBuscarArquivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bias/Taxa de Aprendizagem( 0 a 1 )";
            // 
            // BiasTextBox
            // 
            this.BiasTextBox.Location = new System.Drawing.Point(314, 39);
            this.BiasTextBox.Name = "BiasTextBox";
            this.BiasTextBox.Size = new System.Drawing.Size(49, 20);
            this.BiasTextBox.TabIndex = 5;
            // 
            // btnProcessa
            // 
            this.btnProcessa.Location = new System.Drawing.Point(444, 321);
            this.btnProcessa.Name = "btnProcessa";
            this.btnProcessa.Size = new System.Drawing.Size(101, 45);
            this.btnProcessa.TabIndex = 9;
            this.btnProcessa.Text = "Processar";
            this.btnProcessa.UseVisualStyleBackColor = true;
            // 
            // ResultadoCalculolistView
            // 
            this.ResultadoCalculolistView.HideSelection = false;
            this.ResultadoCalculolistView.Location = new System.Drawing.Point(444, 69);
            this.ResultadoCalculolistView.Name = "ResultadoCalculolistView";
            this.ResultadoCalculolistView.Size = new System.Drawing.Size(121, 232);
            this.ResultadoCalculolistView.TabIndex = 10;
            this.ResultadoCalculolistView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Calculos.";
            // 
            // PesosGridView
            // 
            this.PesosGridView.AllowUserToAddRows = false;
            this.PesosGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.PesosGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PesosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.PesosGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PesosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PesosGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.PesosGridView.Location = new System.Drawing.Point(15, 208);
            this.PesosGridView.MultiSelect = false;
            this.PesosGridView.Name = "PesosGridView";
            this.PesosGridView.ReadOnly = true;
            dataGridViewCellStyle4.NullValue = null;
            this.PesosGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PesosGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PesosGridView.Size = new System.Drawing.Size(412, 43);
            this.PesosGridView.TabIndex = 12;
            //this.PesosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Defina o Peso Por Entrada.";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PesosGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultadoCalculolistView);
            this.Controls.Add(this.btnProcessa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BiasTextBox);
            this.Controls.Add(this.btnBuscarArquivo);
            this.Controls.Add(this.DadosGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaminhoArquivoTextBox);
            this.Controls.Add(this.ProcessaarProgressBar);
            this.Name = "FrmPrincipal";
            this.Text = "Rede Neural Perceptron";
            ((System.ComponentModel.ISupportInitialize)(this.DadosGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProcessaarProgressBar;
        private System.Windows.Forms.TextBox CaminhoArquivoTextBox;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView DadosGridView;
        private System.Windows.Forms.Button btnBuscarArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BiasTextBox;
        private System.Windows.Forms.Button btnProcessa;
        private System.Windows.Forms.ListView ResultadoCalculolistView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PesosGridView;
        private System.Windows.Forms.Label label4;
    }
}

