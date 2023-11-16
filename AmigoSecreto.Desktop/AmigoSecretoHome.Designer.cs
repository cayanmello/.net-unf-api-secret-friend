namespace AmigoSecreto.Desktop
{
    partial class AmigoSecretoHome
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
            listaAmigosView = new DataGridView();
            btnAtualizarLista = new Button();
            label1 = new Label();
            inNome = new TextBox();
            inEmail = new TextBox();
            btnCadastrar = new Button();
            btnGerarAmigos = new Button();
            label2 = new Label();
            label3 = new Label();
            lblQuantidadeDeCadastrados = new Label();
            btnExcluirTodos = new Button();
            inParam = new TextBox();
            label5 = new Label();
            btnBuscarAmigo = new Button();
            ((System.ComponentModel.ISupportInitialize)listaAmigosView).BeginInit();
            SuspendLayout();
            // 
            // listaAmigosView
            // 
            listaAmigosView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaAmigosView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            listaAmigosView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaAmigosView.Location = new Point(13, 317);
            listaAmigosView.Name = "listaAmigosView";
            listaAmigosView.RowTemplate.Height = 25;
            listaAmigosView.Size = new Size(678, 351);
            listaAmigosView.TabIndex = 0;
            listaAmigosView.CellContentClick += listaAmigosView_CellContentClick;
            // 
            // btnAtualizarLista
            // 
            btnAtualizarLista.BackgroundImage = Properties.Resources.cloudrefresh;
            btnAtualizarLista.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtualizarLista.Location = new Point(626, 279);
            btnAtualizarLista.Name = "btnAtualizarLista";
            btnAtualizarLista.Size = new Size(23, 23);
            btnAtualizarLista.TabIndex = 1;
            btnAtualizarLista.UseVisualStyleBackColor = true;
            btnAtualizarLista.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "Cadastrar amigo";
            // 
            // inNome
            // 
            inNome.Location = new Point(13, 33);
            inNome.Name = "inNome";
            inNome.PlaceholderText = "Nome";
            inNome.Size = new Size(306, 23);
            inNome.TabIndex = 3;
            // 
            // inEmail
            // 
            inEmail.Location = new Point(325, 33);
            inEmail.Name = "inEmail";
            inEmail.PlaceholderText = "Email";
            inEmail.Size = new Size(273, 23);
            inEmail.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(604, 33);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnGerarAmigos
            // 
            btnGerarAmigos.Location = new Point(13, 96);
            btnGerarAmigos.Name = "btnGerarAmigos";
            btnGerarAmigos.Size = new Size(113, 23);
            btnGerarAmigos.TabIndex = 6;
            btnGerarAmigos.Text = "Gerar";
            btnGerarAmigos.UseVisualStyleBackColor = true;
            btnGerarAmigos.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 78);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 7;
            label2.Text = "Gerar amigos secretos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(91, 261);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 8;
            label3.Text = "Cadastrados até o momento:";
            // 
            // lblQuantidadeDeCadastrados
            // 
            lblQuantidadeDeCadastrados.AutoSize = true;
            lblQuantidadeDeCadastrados.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantidadeDeCadastrados.Location = new Point(247, 262);
            lblQuantidadeDeCadastrados.Name = "lblQuantidadeDeCadastrados";
            lblQuantidadeDeCadastrados.Size = new Size(19, 13);
            lblQuantidadeDeCadastrados.TabIndex = 9;
            lblQuantidadeDeCadastrados.Text = "27";
            // 
            // btnExcluirTodos
            // 
            btnExcluirTodos.BackgroundImage = Properties.Resources.lixeira;
            btnExcluirTodos.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcluirTodos.Location = new Point(655, 279);
            btnExcluirTodos.Name = "btnExcluirTodos";
            btnExcluirTodos.Size = new Size(24, 23);
            btnExcluirTodos.TabIndex = 10;
            btnExcluirTodos.UseVisualStyleBackColor = true;
            btnExcluirTodos.Click += button4_Click;
            // 
            // inParam
            // 
            inParam.Location = new Point(12, 279);
            inParam.Name = "inParam";
            inParam.PlaceholderText = "Id, Email ou Nome";
            inParam.Size = new Size(307, 23);
            inParam.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 261);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 12;
            label5.Text = "Buscar amigo";
            // 
            // btnBuscarAmigo
            // 
            btnBuscarAmigo.BackgroundImage = Properties.Resources.search;
            btnBuscarAmigo.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscarAmigo.Location = new Point(325, 279);
            btnBuscarAmigo.Name = "btnBuscarAmigo";
            btnBuscarAmigo.Size = new Size(24, 23);
            btnBuscarAmigo.TabIndex = 13;
            btnBuscarAmigo.UseVisualStyleBackColor = true;
            btnBuscarAmigo.Click += btnBuscarAmigo_Click;
            // 
            // AmigoSecretoHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(704, 681);
            Controls.Add(btnBuscarAmigo);
            Controls.Add(label5);
            Controls.Add(inParam);
            Controls.Add(btnExcluirTodos);
            Controls.Add(lblQuantidadeDeCadastrados);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGerarAmigos);
            Controls.Add(btnCadastrar);
            Controls.Add(inEmail);
            Controls.Add(inNome);
            Controls.Add(label1);
            Controls.Add(btnAtualizarLista);
            Controls.Add(listaAmigosView);
            Name = "AmigoSecretoHome";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amigo Secreto -Home";
            Load += AmigoSecretoHome_Load;
            ((System.ComponentModel.ISupportInitialize)listaAmigosView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView listaAmigosView;
        private Button btnAtualizarLista;
        private Label label1;
        private TextBox inNome;
        private TextBox inEmail;
        private Button btnCadastrar;
        private Button btnGerarAmigos;
        private Button btnBuscarAmigo;
        private Label label2;
        private Label label3;
        private Label lblQuantidadeDeCadastrados;
        private Button btnExcluirTodos;
        private TextBox inParam;
        private Label label5;
    }
}