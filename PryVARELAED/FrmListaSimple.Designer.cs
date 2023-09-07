namespace PryVARELAED
{
    partial class FrmListaSimple
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
            this.MRCnuevoelemento = new System.Windows.Forms.GroupBox();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.TXTtramite = new System.Windows.Forms.TextBox();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.LBLtramite = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.TXTcodigo = new System.Windows.Forms.TextBox();
            this.LBLcodigo = new System.Windows.Forms.Label();
            this.MRCelementoaeliminar = new System.Windows.Forms.GroupBox();
            this.BTNeliminar = new System.Windows.Forms.Button();
            this.LBLcodigo2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MRClistasimple = new System.Windows.Forms.GroupBox();
            this.CMDcodigo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRCnuevoelemento.SuspendLayout();
            this.MRCelementoaeliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MRClistasimple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.MRCnuevoelemento.Location = new System.Drawing.Point(246, 48);
            this.MRCnuevoelemento.Name = "MRCnuevoelemento";
            this.MRCnuevoelemento.Size = new System.Drawing.Size(191, 163);
            this.MRCnuevoelemento.TabIndex = 2;
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
            // MRCelementoaeliminar
            // 
            this.MRCelementoaeliminar.Controls.Add(this.CMDcodigo);
            this.MRCelementoaeliminar.Controls.Add(this.LBLcodigo2);
            this.MRCelementoaeliminar.Controls.Add(this.BTNeliminar);
            this.MRCelementoaeliminar.Location = new System.Drawing.Point(456, 54);
            this.MRCelementoaeliminar.Name = "MRCelementoaeliminar";
            this.MRCelementoaeliminar.Size = new System.Drawing.Size(166, 156);
            this.MRCelementoaeliminar.TabIndex = 3;
            this.MRCelementoaeliminar.TabStop = false;
            this.MRCelementoaeliminar.Text = "Elementa a eliminar";
            // 
            // BTNeliminar
            // 
            this.BTNeliminar.Location = new System.Drawing.Point(29, 126);
            this.BTNeliminar.Name = "BTNeliminar";
            this.BTNeliminar.Size = new System.Drawing.Size(89, 20);
            this.BTNeliminar.TabIndex = 0;
            this.BTNeliminar.Text = "Eliminar";
            this.BTNeliminar.UseVisualStyleBackColor = true;
            // 
            // LBLcodigo2
            // 
            this.LBLcodigo2.AutoSize = true;
            this.LBLcodigo2.Location = new System.Drawing.Point(11, 98);
            this.LBLcodigo2.Name = "LBLcodigo2";
            this.LBLcodigo2.Size = new System.Drawing.Size(40, 13);
            this.LBLcodigo2.TabIndex = 1;
            this.LBLcodigo2.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryVARELAED.Properties.Resources.lisa;
            this.pictureBox1.Location = new System.Drawing.Point(18, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 121);
            this.listBox1.TabIndex = 5;
            // 
            // MRClistasimple
            // 
            this.MRClistasimple.Controls.Add(this.dataGridView1);
            this.MRClistasimple.Controls.Add(this.listBox1);
            this.MRClistasimple.Location = new System.Drawing.Point(18, 231);
            this.MRClistasimple.Name = "MRClistasimple";
            this.MRClistasimple.Size = new System.Drawing.Size(751, 195);
            this.MRClistasimple.TabIndex = 6;
            this.MRClistasimple.TabStop = false;
            this.MRClistasimple.Text = "Listado en una Lista y Grilla";
            // 
            // CMDcodigo
            // 
            this.CMDcodigo.FormattingEnabled = true;
            this.CMDcodigo.Location = new System.Drawing.Point(65, 99);
            this.CMDcodigo.Name = "CMDcodigo";
            this.CMDcodigo.Size = new System.Drawing.Size(82, 21);
            this.CMDcodigo.TabIndex = 2;
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
            // FrmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MRClistasimple);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MRCelementoaeliminar);
            this.Controls.Add(this.MRCnuevoelemento);
            this.Name = "FrmListaSimple";
            this.Text = "FrmListaSimple";
            this.MRCnuevoelemento.ResumeLayout(false);
            this.MRCnuevoelemento.PerformLayout();
            this.MRCelementoaeliminar.ResumeLayout(false);
            this.MRCelementoaeliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MRClistasimple.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MRCnuevoelemento;
        private System.Windows.Forms.Button BTNagregar;
        private System.Windows.Forms.TextBox TXTtramite;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.Label LBLtramite;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.TextBox TXTcodigo;
        private System.Windows.Forms.Label LBLcodigo;
        private System.Windows.Forms.GroupBox MRCelementoaeliminar;
        private System.Windows.Forms.Label LBLcodigo2;
        private System.Windows.Forms.Button BTNeliminar;
        private System.Windows.Forms.ComboBox CMDcodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox MRClistasimple;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramte;
    }
}