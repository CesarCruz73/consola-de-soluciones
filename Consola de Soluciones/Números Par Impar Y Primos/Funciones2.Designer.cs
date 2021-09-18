
namespace Números_Par_Impar_Y_Primos
{
    partial class Funciones2
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
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumeroParButton = new System.Windows.Forms.Button();
            this.NumeroPrimoButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Un Número.";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(141, 35);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(135, 20);
            this.Numero1TextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Numero1TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores.";
            // 
            // NumeroParButton
            // 
            this.NumeroParButton.Location = new System.Drawing.Point(24, 19);
            this.NumeroParButton.Name = "NumeroParButton";
            this.NumeroParButton.Size = new System.Drawing.Size(111, 23);
            this.NumeroParButton.TabIndex = 0;
            this.NumeroParButton.Text = "Número Par o Impar";
            this.NumeroParButton.UseVisualStyleBackColor = true;
            this.NumeroParButton.Click += new System.EventHandler(this.NumeroParButton_Click);
            // 
            // NumeroPrimoButton
            // 
            this.NumeroPrimoButton.Location = new System.Drawing.Point(172, 19);
            this.NumeroPrimoButton.Name = "NumeroPrimoButton";
            this.NumeroPrimoButton.Size = new System.Drawing.Size(83, 23);
            this.NumeroPrimoButton.TabIndex = 2;
            this.NumeroPrimoButton.Text = "Número Primo";
            this.NumeroPrimoButton.UseVisualStyleBackColor = true;
            this.NumeroPrimoButton.Click += new System.EventHandler(this.NumeroPrimoButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(121, 48);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 3;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LimpiarButton);
            this.groupBox2.Controls.Add(this.NumeroPrimoButton);
            this.groupBox2.Controls.Add(this.NumeroParButton);
            this.groupBox2.Location = new System.Drawing.Point(429, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones.";
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.Location = new System.Drawing.Point(225, 31);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(79, 16);
            this.ResultadoLabel.TabIndex = 0;
            this.ResultadoLabel.Text = "Resultado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultadoLabel);
            this.groupBox3.Location = new System.Drawing.Point(83, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(631, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado.";
            // 
            // Funciones2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Funciones2";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NumeroParButton;
        private System.Windows.Forms.Button NumeroPrimoButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

