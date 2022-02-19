namespace Proyecto_img
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_img
            // 
            this.pbx_img.Location = new System.Drawing.Point(34, 113);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(180, 180);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_img.TabIndex = 0;
            this.pbx_img.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(31, 43);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(31, 78);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(101, 40);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(170, 20);
            this.txt_id.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(101, 75);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(211, 20);
            this.txt_nombre.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(34, 308);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(127, 308);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 6;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(237, 165);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 7;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 351);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.pbx_img);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_img;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

