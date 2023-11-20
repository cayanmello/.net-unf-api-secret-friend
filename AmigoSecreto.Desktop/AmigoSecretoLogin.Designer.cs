namespace AmigoSecreto.Desktop
{
    partial class AmigoSecretoLogin
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
            lblEntrar = new Label();
            btnEntrar = new Button();
            inEmail = new TextBox();
            inSenha = new TextBox();
            lblErrorMessage = new Label();
            SuspendLayout();
            // 
            // lblEntrar
            // 
            lblEntrar.AutoSize = true;
            lblEntrar.Location = new Point(335, 173);
            lblEntrar.Name = "lblEntrar";
            lblEntrar.Size = new Size(38, 15);
            lblEntrar.TabIndex = 0;
            lblEntrar.Text = "Entrar";
            lblEntrar.Click += label1_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(305, 283);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(98, 23);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // inEmail
            // 
            inEmail.Location = new Point(200, 201);
            inEmail.Name = "inEmail";
            inEmail.PlaceholderText = "E-mail";
            inEmail.Size = new Size(314, 23);
            inEmail.TabIndex = 2;
            inEmail.Text = "jose.victor@amigosecreto.com.br";
            inEmail.TextChanged += inEmail_TextChanged;
            // 
            // inSenha
            // 
            inSenha.Location = new Point(200, 241);
            inSenha.Name = "inSenha";
            inSenha.PasswordChar = '*';
            inSenha.PlaceholderText = "Senha";
            inSenha.Size = new Size(314, 23);
            inSenha.TabIndex = 3;
            inSenha.Text = "1q2w!Q@W";
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(197, 264);
            lblErrorMessage.Margin = new Padding(0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(143, 13);
            lblErrorMessage.TabIndex = 4;
            lblErrorMessage.Text = "Email ou senha incorretos.";
            // 
            // AmigoSecretoLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 681);
            Controls.Add(lblErrorMessage);
            Controls.Add(inSenha);
            Controls.Add(inEmail);
            Controls.Add(btnEntrar);
            Controls.Add(lblEntrar);
            MaximumSize = new Size(720, 720);
            MinimumSize = new Size(720, 720);
            Name = "AmigoSecretoLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AmigoSecretoLogin";
            Load += AmigoSecretoLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEntrar;
        private Button btnEntrar;
        private TextBox inEmail;
        private TextBox inSenha;
        private Label lblErrorMessage;
    }
}