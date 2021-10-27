namespace G5_Ejercicio2F
{
    partial class FrmPromedio
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtperiod1 = new System.Windows.Forms.TextBox();
            this.txtperiod2 = new System.Windows.Forms.TextBox();
            this.txtperiod3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorpro = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorpro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo 1:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtperiod3);
            this.groupBox1.Controls.Add(this.txtperiod2);
            this.groupBox1.Controls.Add(this.txtperiod1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Periodo 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Periodo 3:";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Gold;
            this.btncalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncalcular.Location = new System.Drawing.Point(12, 273);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(237, 31);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtperiod1
            // 
            this.txtperiod1.Location = new System.Drawing.Point(83, 37);
            this.txtperiod1.Name = "txtperiod1";
            this.txtperiod1.Size = new System.Drawing.Size(100, 20);
            this.txtperiod1.TabIndex = 2;
            this.txtperiod1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtperiod1_KeyPress);
            // 
            // txtperiod2
            // 
            this.txtperiod2.Location = new System.Drawing.Point(83, 89);
            this.txtperiod2.Name = "txtperiod2";
            this.txtperiod2.Size = new System.Drawing.Size(100, 20);
            this.txtperiod2.TabIndex = 3;
            this.txtperiod2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtperiod2_KeyPress);
            // 
            // txtperiod3
            // 
            this.txtperiod3.Location = new System.Drawing.Point(83, 142);
            this.txtperiod3.Name = "txtperiod3";
            this.txtperiod3.Size = new System.Drawing.Size(100, 20);
            this.txtperiod3.TabIndex = 4;
            this.txtperiod3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtperiod3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "PROMEDIO";
            // 
            // errorpro
            // 
            this.errorpro.ContainerControl = this;
            // 
            // FrmPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(262, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FrmPromedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPromedio_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorpro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtperiod3;
        private System.Windows.Forms.TextBox txtperiod2;
        private System.Windows.Forms.TextBox txtperiod1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorpro;
    }
}