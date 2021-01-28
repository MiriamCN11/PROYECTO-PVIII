
namespace nominaCS2._1
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.lblBuscarEmpleado = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtIDBuscar = new System.Windows.Forms.TextBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnNominaOPC = new System.Windows.Forms.Button();
            this.btnModificarOPC = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMENU = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarEmpleado
            // 
            this.lblBuscarEmpleado.AutoSize = true;
            this.lblBuscarEmpleado.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEmpleado.Location = new System.Drawing.Point(327, 35);
            this.lblBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarEmpleado.Name = "lblBuscarEmpleado";
            this.lblBuscarEmpleado.Size = new System.Drawing.Size(207, 39);
            this.lblBuscarEmpleado.TabIndex = 4;
            this.lblBuscarEmpleado.Text = "Buscar Empleado";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(132, 131);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 25);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID: ";
            // 
            // txtIDBuscar
            // 
            this.txtIDBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBuscar.Location = new System.Drawing.Point(180, 128);
            this.txtIDBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDBuscar.Name = "txtIDBuscar";
            this.txtIDBuscar.Size = new System.Drawing.Size(323, 30);
            this.txtIDBuscar.TabIndex = 21;
            // 
            // lstDatos
            // 
            this.lstDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 25;
            this.lstDatos.Location = new System.Drawing.Point(137, 177);
            this.lstDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(366, 229);
            this.lstDatos.TabIndex = 22;
            // 
            // btnNominaOPC
            // 
            this.btnNominaOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNominaOPC.Location = new System.Drawing.Point(578, 304);
            this.btnNominaOPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNominaOPC.Name = "btnNominaOPC";
            this.btnNominaOPC.Size = new System.Drawing.Size(204, 39);
            this.btnNominaOPC.TabIndex = 23;
            this.btnNominaOPC.Text = "Crear Nomina";
            this.btnNominaOPC.UseVisualStyleBackColor = true;
            this.btnNominaOPC.Click += new System.EventHandler(this.btnNominaOPC_Click);
            // 
            // btnModificarOPC
            // 
            this.btnModificarOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarOPC.Location = new System.Drawing.Point(578, 183);
            this.btnModificarOPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarOPC.Name = "btnModificarOPC";
            this.btnModificarOPC.Size = new System.Drawing.Size(204, 39);
            this.btnModificarOPC.TabIndex = 24;
            this.btnModificarOPC.Text = "Modificar";
            this.btnModificarOPC.UseVisualStyleBackColor = true;
            this.btnModificarOPC.Click += new System.EventHandler(this.btnModificarOPC_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(578, 243);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(204, 39);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMENU
            // 
            this.btnMENU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMENU.Location = new System.Drawing.Point(578, 367);
            this.btnMENU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMENU.Name = "btnMENU";
            this.btnMENU.Size = new System.Drawing.Size(204, 39);
            this.btnMENU.TabIndex = 26;
            this.btnMENU.Text = "Menu Principal";
            this.btnMENU.UseVisualStyleBackColor = true;
            this.btnMENU.Click += new System.EventHandler(this.btnMENU_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 453);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(541, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(578, 121);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(204, 39);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMENU);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarOPC);
            this.Controls.Add(this.btnNominaOPC);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.txtIDBuscar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblBuscarEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Buscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarEmpleado;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtIDBuscar;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnNominaOPC;
        private System.Windows.Forms.Button btnModificarOPC;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMENU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBuscar;
    }
}