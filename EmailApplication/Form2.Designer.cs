namespace EmailApplication
{
    partial class Form2
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
            view_user = new Button();
            label1 = new Label();
            from_input = new TextBox();
            label2 = new Label();
            to_input = new TextBox();
            subject = new Label();
            subject_input = new TextBox();
            message = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // view_user
            // 
            view_user.Location = new Point(338, 370);
            view_user.Name = "view_user";
            view_user.Size = new Size(94, 29);
            view_user.TabIndex = 0;
            view_user.Text = "Send";
            view_user.UseVisualStyleBackColor = true;
            view_user.Click += view_user_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 35);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "From";
            // 
            // from_input
            // 
            from_input.Location = new Point(96, 58);
            from_input.Name = "from_input";
            from_input.Size = new Size(257, 27);
            from_input.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 35);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 3;
            label2.Text = "To";
            // 
            // to_input
            // 
            to_input.Location = new Point(419, 58);
            to_input.Name = "to_input";
            to_input.Size = new Size(257, 27);
            to_input.TabIndex = 4;
            // 
            // subject
            // 
            subject.AutoSize = true;
            subject.Location = new Point(96, 119);
            subject.Name = "subject";
            subject.Size = new Size(58, 20);
            subject.TabIndex = 5;
            subject.Text = "Subject";
            // 
            // subject_input
            // 
            subject_input.Location = new Point(96, 142);
            subject_input.Name = "subject_input";
            subject_input.Size = new Size(580, 27);
            subject_input.TabIndex = 6;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(96, 219);
            message.Name = "message";
            message.Size = new Size(67, 20);
            message.TabIndex = 7;
            message.Text = "Message";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 251);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(580, 85);
            textBox1.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(message);
            Controls.Add(subject_input);
            Controls.Add(subject);
            Controls.Add(to_input);
            Controls.Add(label2);
            Controls.Add(from_input);
            Controls.Add(label1);
            Controls.Add(view_user);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button view_user;
        private Label label1;
        private TextBox from_input;
        private Label label2;
        private TextBox to_input;
        private Label subject;
        private TextBox subject_input;
        private Label message;
        private TextBox textBox1;
    }
}