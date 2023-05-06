namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nro1 = new TextBox();
            nro2 = new TextBox();
            lblResultado = new Label();
            btn_Soma = new Button();
            btn_Sub = new Button();
            btn_Mult = new Button();
            btn_Div = new Button();
            SuspendLayout();
            // 
            // nro1
            // 
            nro1.Location = new Point(35, 53);
            nro1.Name = "nro1";
            nro1.Size = new Size(100, 23);
            nro1.TabIndex = 0;
            // 
            // nro2
            // 
            nro2.Location = new Point(35, 83);
            nro2.Name = "nro2";
            nro2.Size = new Size(100, 23);
            nro2.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(55, 119);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // btn_Soma
            // 
            btn_Soma.Location = new Point(162, 52);
            btn_Soma.Name = "btn_Soma";
            btn_Soma.Size = new Size(44, 23);
            btn_Soma.TabIndex = 3;
            btn_Soma.Text = "+";
            btn_Soma.UseVisualStyleBackColor = true;
            btn_Soma.Click += btn_Soma_Click;
            // 
            // btn_Sub
            // 
            btn_Sub.Location = new Point(212, 53);
            btn_Sub.Name = "btn_Sub";
            btn_Sub.Size = new Size(45, 23);
            btn_Sub.TabIndex = 4;
            btn_Sub.Text = "-";
            btn_Sub.UseVisualStyleBackColor = true;
            btn_Sub.Click += btn_Sub_Click;
            // 
            // btn_Mult
            // 
            btn_Mult.Location = new Point(162, 82);
            btn_Mult.Name = "btn_Mult";
            btn_Mult.Size = new Size(44, 23);
            btn_Mult.TabIndex = 5;
            btn_Mult.Text = "*";
            btn_Mult.UseVisualStyleBackColor = true;
            btn_Mult.Click += btn_Div_Click;
            // 
            // btn_Div
            // 
            btn_Div.Location = new Point(212, 82);
            btn_Div.Name = "btn_Div";
            btn_Div.Size = new Size(45, 23);
            btn_Div.TabIndex = 6;
            btn_Div.Text = "/";
            btn_Div.UseVisualStyleBackColor = true;
            btn_Div.Click += btn_Multi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Div);
            Controls.Add(btn_Mult);
            Controls.Add(btn_Sub);
            Controls.Add(btn_Soma);
            Controls.Add(lblResultado);
            Controls.Add(nro2);
            Controls.Add(nro1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nro1;
        private TextBox nro2;
        private Label lblResultado;
        private Button btn_Soma;
        private Button btn_Sub;
        private Button btn_Mult;
        private Button btn_Div;
    }
}