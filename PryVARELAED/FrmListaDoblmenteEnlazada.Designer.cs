namespace PryVARELAED
{
    partial class FrmListaDoblmenteEnlazada
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
            this.MRClistasimple = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LSTlistadoble = new System.Windows.Forms.ListBox();
            this.MRCelementoaeliminar = new System.Windows.Forms.GroupBox();
            this.CMDcodigo = new System.Windows.Forms.ComboBox();
            this.LBLcodigo2 = new System.Windows.Forms.Label();
            this.BTNeliminar = new System.Windows.Forms.Button();
            this.MRCnuevoelemento = new System.Windows.Forms.GroupBox();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.TXTtramite = new System.Windows.Forms.TextBox();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.LBLtramite = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.TXTcodigo = new System.Windows.Forms.TextBox();
            this.LBLcodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MRClistardatos = new System.Windows.Forms.GroupBox();
            this.OPTdescendiente = new System.Windows.Forms.RadioButton();
            this.OPTascendente = new System.Windows.Forms.RadioButton();
            this.MRClistasimple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MRCelementoaeliminar.SuspendLayout();
            this.MRCnuevoelemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MRClistardatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // MRClistasimple
            // 
            this.MRClistasimple.Controls.Add(this.dataGridView1);
            this.MRClistasimple.Controls.Add(this.LSTlistadoble);
            this.MRClistasimple.Location = new System.Drawing.Point(25, 219);
            this.MRClistasimple.Name = "MRClistasimple";
            this.MRClistasimple.Size = new System.Drawing.Size(751, 195);
            this.MRClistasimple.TabIndex = 9;
            this.MRClistasimple.TabStop = false;
            this.MRClistasimple.Text = "Listado en una Lista y Grilla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramte});
            this.dataGridView1.Location = new System.Drawing.Point(192, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 140);
            this.dataGridView1.TabIndex = 6;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tramte
            // 
            this.Tramte.HeaderText = "Tramite";
            this.Tramte.Name = "Tramte";
            // 
            // LSTlistadoble
            // 
            this.LSTlistadoble.FormattingEnabled = true;
            this.LSTlistadoble.Location = new System.Drawing.Point(0, 26);
            this.LSTlistadoble.Name = "LSTlistadoble";
            this.LSTlistadoble.Size = new System.Drawing.Size(175, 121);
            this.LSTlistadoble.TabIndex = 5;
            // 
            // MRCelementoaeliminar
            // 
            this.MRCelementoaeliminar.Controls.Add(this.CMDcodigo);
            this.MRCelementoaeliminar.Controls.Add(this.LBLcodigo2);
            this.MRCelementoaeliminar.Controls.Add(this.BTNeliminar);
            this.MRCelementoaeliminar.Location = new System.Drawing.Point(463, 42);
            this.MRCelementoaeliminar.Name = "MRCelementoaeliminar";
            this.MRCelementoaeliminar.Size = new System.Drawing.Size(166, 89);
            this.MRCelementoaeliminar.TabIndex = 8;
            this.MRCelementoaeliminar.TabStop = false;
            this.MRCelementoaeliminar.Text = "Elementa a eliminar";
            // 
            // CMDcodigo
            // 
            this.CMDcodigo.FormattingEnabled = true;
            this.CMDcodigo.Location = new System.Drawing.Point(61, 34);
            this.CMDcodigo.Name = "CMDcodigo";
            this.CMDcodigo.Size = new System.Drawing.Size(82, 21);
            this.CMDcodigo.TabIndex = 2;
            // 
            // LBLcodigo2
            // 
            this.LBLcodigo2.AutoSize = true;
            this.LBLcodigo2.Location = new System.Drawing.Point(7, 33);
            this.LBLcodigo2.Name = "LBLcodigo2";
            this.LBLcodigo2.Size = new System.Drawing.Size(40, 13);
            this.LBLcodigo2.TabIndex = 1;
            this.LBLcodigo2.Text = "Codigo";
            // 
            // BTNeliminar
            // 
            this.BTNeliminar.Location = new System.Drawing.Point(25, 61);
            this.BTNeliminar.Name = "BTNeliminar";
            this.BTNeliminar.Size = new System.Drawing.Size(89, 21);
            this.BTNeliminar.TabIndex = 0;
            this.BTNeliminar.Text = "Eliminar";
            this.BTNeliminar.UseVisualStyleBackColor = true;
            // 
            // MRCnuevoelemento
            // 
            this.MRCnuevoelemento.Controls.Add(this.BTNagregar);
            this.MRCnuevoelemento.Controls.Add(this.TXTtramite);
            this.MRCnuevoelemento.Controls.Add(this.TXTnombre);
            this.MRCnuevoelemento.Controls.Add(this.LBLtramite);
            this.MRCnuevoelemento.Controls.Add(this.LBLnombre);
            this.MRCnuevoelemento.Controls.Add(this.TXTcodigo);
            this.MRCnuevoelemento.Controls.Add(this.LBLcodigo);
            this.MRCnuevoelemento.Location = new System.Drawing.Point(253, 36);
            this.MRCnuevoelemento.Name = "MRCnuevoelemento";
            this.MRCnuevoelemento.Size = new System.Drawing.Size(191, 177);
            this.MRCnuevoelemento.TabIndex = 7;
            this.MRCnuevoelemento.TabStop = false;
            this.MRCnuevoelemento.Text = "Nuevo Elemento";
            // 
            // BTNagregar
            // 
            this.BTNagregar.Location = new System.Drawing.Point(74, 132);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(85, 21);
            this.BTNagregar.TabIndex = 6;
            this.BTNagregar.Text = "Agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            // 
            // TXTtramite
            // 
            this.TXTtramite.Location = new System.Drawing.Point(78, 106);
            this.TXTtramite.Name = "TXTtramite";
            this.TXTtramite.Size = new System.Drawing.Size(82, 20);
            this.TXTtramite.TabIndex = 5;
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(78, 68);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(82, 20);
            this.TXTnombre.TabIndex = 4;
            // 
            // LBLtramite
            // 
            this.LBLtramite.AutoSize = true;
            this.LBLtramite.Location = new System.Drawing.Point(6, 109);
            this.LBLtramite.Name = "LBLtramite";
            this.LBLtramite.Size = new System.Drawing.Size(42, 13);
            this.LBLtramite.TabIndex = 3;
            this.LBLtramite.Text = "Tramite";
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(6, 68);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(44, 13);
            this.LBLnombre.TabIndex = 2;
            this.LBLnombre.Text = "Nombre";
            // 
            // TXTcodigo
            // 
            this.TXTcodigo.Location = new System.Drawing.Point(80, 42);
            this.TXTcodigo.Name = "TXTcodigo";
            this.TXTcodigo.Size = new System.Drawing.Size(80, 20);
            this.TXTcodigo.TabIndex = 1;
            // 
            // LBLcodigo
            // 
            this.LBLcodigo.AutoSize = true;
            this.LBLcodigo.Location = new System.Drawing.Point(6, 31);
            this.LBLcodigo.Name = "LBLcodigo";
            this.LBLcodigo.Size = new System.Drawing.Size(40, 13);
            this.LBLcodigo.TabIndex = 0;
            this.LBLcodigo.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryVARELAED.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(17, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MRClistardatos
            // 
            this.MRClistardatos.Controls.Add(this.OPTdescendiente);
            this.MRClistardatos.Controls.Add(this.OPTascendente);
            this.MRClistardatos.Location = new System.Drawing.Point(463, 137);
            this.MRClistardatos.Name = "MRClistardatos";
            this.MRClistardatos.Size = new System.Drawing.Size(143, 76);
            this.MRClistardatos.TabIndex = 11;
            this.MRClistardatos.TabStop = false;
            this.MRClistardatos.Text = "Listar Datos";
            // 
            // OPTdescendiente
            // 
            this.OPTdescendiente.AutoSize = true;
            this.OPTdescendiente.Location = new System.Drawing.Point(25, 42);
            this.OPTdescendiente.Name = "OPTdescendiente";
            this.OPTdescendiente.Size = new System.Drawing.Size(91, 17);
            this.OPTdescendiente.TabIndex = 1;
            this.OPTdescendiente.TabStop = true;
            this.OPTdescendiente.Text = "Descendiente";
            this.OPTdescendiente.UseVisualStyleBackColor = true;
            // 
            // OPTascendente
            // 
            this.OPTascendente.AutoSize = true;
            this.OPTascendente.Location = new System.Drawing.Point(25, 19);
            this.OPTascendente.Name = "OPTascendente";
            this.OPTascendente.Size = new System.Drawing.Size(82, 17);
            this.OPTascendente.TabIndex = 0;
            this.OPTascendente.TabStop = true;
            this.OPTascendente.Text = "Ascendente";
            this.OPTascendente.UseVisualStyleBackColor = true;
            // 
            // FrmListaDoblmenteEnlazada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MRClistardatos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MRClistasimple);
            this.Controls.Add(this.MRCelementoaeliminar);
            this.Controls.Add(this.MRCnuevoelemento);
            this.Name = "FrmListaDoblmenteEnlazada";
            this.Text = "FrmListaDoblmenteEnlazada";
            this.MRClistasimple.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MRCelementoaeliminar.ResumeLayout(false);
            this.MRCelementoaeliminar.PerformLayout();
            this.MRCnuevoelemento.ResumeLayout(false);
            this.MRCnuevoelemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MRClistardatos.ResumeLayout(false);
            this.MRClistardatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MRClistasimple;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramte;
        private System.Windows.Forms.ListBox LSTlistadoble;
        private System.Windows.Forms.GroupBox MRCelementoaeliminar;
        private System.Windows.Forms.ComboBox CMDcodigo;
        private System.Windows.Forms.Label LBLcodigo2;
        private System.Windows.Forms.Button BTNeliminar;
        private System.Windows.Forms.GroupBox MRCnuevoelemento;
        private System.Windows.Forms.Button BTNagregar;
        private System.Windows.Forms.TextBox TXTtramite;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.Label LBLtramite;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.TextBox TXTcodigo;
        private System.Windows.Forms.Label LBLcodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox MRClistardatos;
        private System.Windows.Forms.RadioButton OPTdescendiente;
        private System.Windows.Forms.RadioButton OPTascendente;
    }
}