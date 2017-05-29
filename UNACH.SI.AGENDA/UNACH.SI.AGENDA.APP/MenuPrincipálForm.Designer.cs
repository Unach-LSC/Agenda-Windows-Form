namespace UNACH.SI.AGENDA.APP
{
    partial class MenuPrincipálForm
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
            this.Usuariosdgv = new System.Windows.Forms.DataGridView();
            this.Nuevobtn = new System.Windows.Forms.Button();
            this.Modificarbtn = new System.Windows.Forms.Button();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.Salirbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buscartxt = new System.Windows.Forms.TextBox();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.IdColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContraseñaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Usuariosdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuariosdgv
            // 
            this.Usuariosdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Usuariosdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NombreColumn,
            this.LoginColumn,
            this.ContraseñaColumn});
            this.Usuariosdgv.Location = new System.Drawing.Point(31, 24);
            this.Usuariosdgv.Name = "Usuariosdgv";
            this.Usuariosdgv.Size = new System.Drawing.Size(595, 239);
            this.Usuariosdgv.TabIndex = 0;
            this.Usuariosdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Usuariosdgv_CellContentClick);
            // 
            // Nuevobtn
            // 
            this.Nuevobtn.Location = new System.Drawing.Point(660, 99);
            this.Nuevobtn.Name = "Nuevobtn";
            this.Nuevobtn.Size = new System.Drawing.Size(106, 36);
            this.Nuevobtn.TabIndex = 1;
            this.Nuevobtn.Text = "Nuevo";
            this.Nuevobtn.UseVisualStyleBackColor = true;
            this.Nuevobtn.Click += new System.EventHandler(this.Nuevobtn_Click);
            // 
            // Modificarbtn
            // 
            this.Modificarbtn.Location = new System.Drawing.Point(660, 141);
            this.Modificarbtn.Name = "Modificarbtn";
            this.Modificarbtn.Size = new System.Drawing.Size(106, 38);
            this.Modificarbtn.TabIndex = 2;
            this.Modificarbtn.Text = "Modificar";
            this.Modificarbtn.UseVisualStyleBackColor = true;
            this.Modificarbtn.Click += new System.EventHandler(this.Modificarbtn_Click);
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.Location = new System.Drawing.Point(660, 185);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(106, 36);
            this.Eliminarbtn.TabIndex = 3;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = true;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // Salirbtn
            // 
            this.Salirbtn.Location = new System.Drawing.Point(660, 227);
            this.Salirbtn.Name = "Salirbtn";
            this.Salirbtn.Size = new System.Drawing.Size(106, 36);
            this.Salirbtn.TabIndex = 4;
            this.Salirbtn.Text = "Salir!!!!!";
            this.Salirbtn.UseVisualStyleBackColor = true;
            this.Salirbtn.Click += new System.EventHandler(this.Salirbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar por Nombre";
            // 
            // buscartxt
            // 
            this.buscartxt.Location = new System.Drawing.Point(145, 277);
            this.buscartxt.Name = "buscartxt";
            this.buscartxt.Size = new System.Drawing.Size(303, 20);
            this.buscartxt.TabIndex = 6;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Location = new System.Drawing.Point(463, 277);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(75, 23);
            this.buscarbtn.TabIndex = 7;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = true;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(657, 47);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(33, 13);
            this.Nombrelabel.TabIndex = 8;
            this.Nombrelabel.Text = "vacio";
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Text = "ID";
            // 
            // NombreColumn
            // 
            this.NombreColumn.DataPropertyName = "NombreCompleto";
            this.NombreColumn.HeaderText = "NOMBRE COMPLETO";
            this.NombreColumn.Name = "NombreColumn";
            // 
            // LoginColumn
            // 
            this.LoginColumn.DataPropertyName = "Login";
            this.LoginColumn.HeaderText = "LOGIN";
            this.LoginColumn.Name = "LoginColumn";
            // 
            // ContraseñaColumn
            // 
            this.ContraseñaColumn.DataPropertyName = "Contraseña";
            this.ContraseñaColumn.HeaderText = "CONTRASEÑA";
            this.ContraseñaColumn.Name = "ContraseñaColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(657, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario seleccionado";
            // 
            // MenuPrincipálForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.buscartxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salirbtn);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.Modificarbtn);
            this.Controls.Add(this.Nuevobtn);
            this.Controls.Add(this.Usuariosdgv);
            this.Name = "MenuPrincipálForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipálForm";
            this.Load += new System.EventHandler(this.MenuPrincipálForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Usuariosdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Usuariosdgv;
        private System.Windows.Forms.Button Nuevobtn;
        private System.Windows.Forms.Button Modificarbtn;
        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.Button Salirbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscartxt;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.DataGridViewButtonColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContraseñaColumn;
        private System.Windows.Forms.Label label2;
    }
}