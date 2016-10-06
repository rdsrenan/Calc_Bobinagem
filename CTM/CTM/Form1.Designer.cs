namespace CTM
{
    partial class Form1
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
            this.bt_transformador = new System.Windows.Forms.Button();
            this.bt_motor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_avancar = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_transformador
            // 
            this.bt_transformador.Location = new System.Drawing.Point(157, 165);
            this.bt_transformador.Name = "bt_transformador";
            this.bt_transformador.Size = new System.Drawing.Size(150, 100);
            this.bt_transformador.TabIndex = 0;
            this.bt_transformador.Text = "Transformador";
            this.bt_transformador.UseVisualStyleBackColor = true;
            this.bt_transformador.Click += new System.EventHandler(this.bt_Transformador_Click);
            // 
            // bt_motor
            // 
            this.bt_motor.Location = new System.Drawing.Point(406, 165);
            this.bt_motor.Name = "bt_motor";
            this.bt_motor.Size = new System.Drawing.Size(150, 100);
            this.bt_motor.TabIndex = 1;
            this.bt_motor.Text = "Motor";
            this.bt_motor.UseVisualStyleBackColor = true;
            this.bt_motor.Click += new System.EventHandler(this.bt_motor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_motor);
            this.panel1.Controls.Add(this.bt_transformador);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 375);
            this.panel1.TabIndex = 2;
            // 
            // bt_avancar
            // 
            this.bt_avancar.Location = new System.Drawing.Point(641, 409);
            this.bt_avancar.Name = "bt_avancar";
            this.bt_avancar.Size = new System.Drawing.Size(75, 23);
            this.bt_avancar.TabIndex = 3;
            this.bt_avancar.Text = "Avançar";
            this.bt_avancar.UseVisualStyleBackColor = true;
            this.bt_avancar.Visible = false;
            this.bt_avancar.Click += new System.EventHandler(this.bt_avancar_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(41, 409);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(75, 23);
            this.bt_voltar.TabIndex = 4;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Visible = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(131, 409);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 5;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Visible = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 375);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.bt_avancar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Magneto";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_transformador;
        private System.Windows.Forms.Button bt_motor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_avancar;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Panel panel2;
    }
}

