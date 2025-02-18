namespace Fiap.Vendas
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
            btnEnter = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPasswrod = new TextBox();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.BackColor = SystemColors.ControlLightLight;
            btnEnter.ForeColor = SystemColors.ActiveCaptionText;
            btnEnter.Location = new Point(74, 159);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(181, 23);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 39);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Username :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 93);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(74, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(181, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPasswrod
            // 
            txtPasswrod.Location = new Point(74, 111);
            txtPasswrod.Name = "txtPasswrod";
            txtPasswrod.Size = new Size(181, 23);
            txtPasswrod.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(322, 225);
            Controls.Add(txtPasswrod);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEnter);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPasswrod;
    }
}
