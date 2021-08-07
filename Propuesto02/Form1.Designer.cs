
namespace Propuesto02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbopuntu = new System.Windows.Forms.ComboBox();
            this.cobdefectuosas = new System.Windows.Forms.ComboBox();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lvrespuestas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutos de Tardanza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Observaciones efectuadas";
            // 
            // cbopuntu
            // 
            this.cbopuntu.FormattingEnabled = true;
            this.cbopuntu.Items.AddRange(new object[] {
            "0",
            "1 a 2",
            "3 a 5",
            "6 a 9",
            "Mas de 9"});
            this.cbopuntu.Location = new System.Drawing.Point(163, 113);
            this.cbopuntu.Name = "cbopuntu";
            this.cbopuntu.Size = new System.Drawing.Size(121, 21);
            this.cbopuntu.TabIndex = 2;
            this.cbopuntu.Text = "Seleccionar";
            // 
            // cobdefectuosas
            // 
            this.cobdefectuosas.FormattingEnabled = true;
            this.cobdefectuosas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "Mas de 3"});
            this.cobdefectuosas.Location = new System.Drawing.Point(163, 163);
            this.cobdefectuosas.Name = "cobdefectuosas";
            this.cobdefectuosas.Size = new System.Drawing.Size(121, 21);
            this.cobdefectuosas.TabIndex = 3;
            this.cobdefectuosas.Text = "Seleccionar";
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(345, 88);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(75, 41);
            this.btnprocesar.TabIndex = 4;
            this.btnprocesar.Text = "PROCESAR";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(100, 448);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(113, 55);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(403, 448);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(92, 55);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lvrespuestas
            // 
            this.lvrespuestas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.lvrespuestas.HideSelection = false;
            this.lvrespuestas.Location = new System.Drawing.Point(37, 217);
            this.lvrespuestas.Name = "lvrespuestas";
            this.lvrespuestas.Size = new System.Drawing.Size(858, 192);
            this.lvrespuestas.TabIndex = 7;
            this.lvrespuestas.UseCompatibleStateImageBehavior = false;
            this.lvrespuestas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Empleado";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tardanza";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Observaciones";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Puntaje por puntualidad";
            this.columnHeader4.Width = 148;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Puntaje por rendimiento";
            this.columnHeader5.Width = 141;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Puntuaje total";
            this.columnHeader6.Width = 146;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "EMPLEADO";
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(163, 55);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(121, 20);
            this.txtempleado.TabIndex = 9;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bonificacion";
            this.columnHeader8.Width = 108;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 580);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvrespuestas);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.cobdefectuosas);
            this.Controls.Add(this.cbopuntu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbopuntu;
        private System.Windows.Forms.ComboBox cobdefectuosas;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ListView lvrespuestas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

