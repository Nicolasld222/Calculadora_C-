namespace CAlculadoraC_
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
            calculador = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnSuma = new Button();
            btnResta = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            buttonBorrar = new Button();
            button0 = new Button();
            buttonBorrarTodo = new Button();
            buttonIgual = new Button();
            lblOperacion = new Label();
            SuspendLayout();
            // 
            // calculador
            // 
            calculador.AutoSize = true;
            calculador.Font = new Font("Segoe UI", 35F);
            calculador.Location = new Point(134, 49);
            calculador.Name = "calculador";
            calculador.Size = new Size(233, 62);
            calculador.TabIndex = 0;
            calculador.Text = "Resultado";
            calculador.Click += calculador_Click;
            // 
            // button1
            // 
            button1.Location = new Point(67, 193);
            button1.Name = "button1";
            button1.Size = new Size(77, 66);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(196, 193);
            button2.Name = "button2";
            button2.Size = new Size(77, 66);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(321, 193);
            button3.Name = "button3";
            button3.Size = new Size(79, 66);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(67, 279);
            button4.Name = "button4";
            button4.Size = new Size(77, 72);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(196, 279);
            button5.Name = "button5";
            button5.Size = new Size(77, 72);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(321, 279);
            button6.Name = "button6";
            button6.Size = new Size(79, 72);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(67, 375);
            button7.Name = "button7";
            button7.Size = new Size(77, 68);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(196, 375);
            button8.Name = "button8";
            button8.Size = new Size(77, 68);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(321, 375);
            button9.Name = "button9";
            button9.Size = new Size(79, 68);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(67, 140);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(77, 37);
            btnSuma.TabIndex = 10;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(150, 140);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(77, 37);
            btnResta.TabIndex = 11;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(233, 140);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(77, 37);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(323, 140);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(77, 37);
            btnMul.TabIndex = 13;
            btnMul.Text = "X";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(67, 462);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(77, 68);
            buttonBorrar.TabIndex = 14;
            buttonBorrar.Text = "<-";
            buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(196, 462);
            button0.Name = "button0";
            button0.Size = new Size(77, 68);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonBorrarTodo
            // 
            buttonBorrarTodo.Location = new Point(321, 462);
            buttonBorrarTodo.Name = "buttonBorrarTodo";
            buttonBorrarTodo.Size = new Size(79, 68);
            buttonBorrarTodo.TabIndex = 16;
            buttonBorrarTodo.Text = "C";
            buttonBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // buttonIgual
            // 
            buttonIgual.Font = new Font("Segoe UI", 20F);
            buttonIgual.Location = new Point(67, 537);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(333, 68);
            buttonIgual.TabIndex = 17;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.FlatStyle = FlatStyle.Flat;
            lblOperacion.Font = new Font("Segoe UI", 16F);
            lblOperacion.Location = new Point(233, 19);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(0, 30);
            lblOperacion.TabIndex = 18;
            lblOperacion.Click += lblOperacion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 617);
            Controls.Add(lblOperacion);
            Controls.Add(buttonIgual);
            Controls.Add(buttonBorrarTodo);
            Controls.Add(button0);
            Controls.Add(buttonBorrar);
            Controls.Add(btnMul);
            Controls.Add(btnDiv);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(calculador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label calculador;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDiv;
        private Button btnMul;
        private Button buttonBorrar;
        private Button button0;
        private Button buttonBorrarTodo;
        private Button buttonIgual;
        private Label lblOperacion;
    }
}
