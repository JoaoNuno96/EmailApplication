namespace EmailApplication
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
            email_input = new TextBox();
            label1 = new Label();
            enviar = new Button();
            destination = new Label();
            destination_input = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // email_input
            // 
            email_input.Location = new Point(267, 175);
            email_input.Name = "email_input";
            email_input.Size = new Size(248, 27);
            email_input.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 141);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // enviar
            // 
            enviar.Location = new Point(336, 308);
            enviar.Name = "enviar";
            enviar.Size = new Size(94, 29);
            enviar.TabIndex = 2;
            enviar.Text = "LogIn";
            enviar.UseVisualStyleBackColor = true;
            enviar.Click += enviar_Click;
            // 
            // destination
            // 
            destination.AutoSize = true;
            destination.Location = new Point(360, 219);
            destination.Name = "destination";
            destination.RightToLeft = RightToLeft.No;
            destination.Size = new Size(70, 20);
            destination.TabIndex = 3;
            destination.Text = "Password";
            // 
            // destination_input
            // 
            destination_input.Location = new Point(267, 252);
            destination_input.Name = "destination_input";
            destination_input.PasswordChar = '*';
            destination_input.Size = new Size(248, 27);
            destination_input.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(250, 26);
            label2.Name = "label2";
            label2.Size = new Size(290, 38);
            label2.TabIndex = 5;
            label2.Text = "Authentication Screen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(250, 74);
            label3.Name = "label3";
            label3.Size = new Size(281, 20);
            label3.TabIndex = 6;
            label3.Text = "Currently only works with Microsoft emails";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 448);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(destination_input);
            Controls.Add(destination);
            Controls.Add(enviar);
            Controls.Add(label1);
            Controls.Add(email_input);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email_input;
        private Label label1;
        private Button enviar;
        private Label destination;
        private TextBox destination_input;
        private Label label2;
        private Label label3;
    }
}
