namespace PausasActivas.Modulos
{
    public class OsteoForm : System.Windows.Forms.Form
    {
        public OsteoForm()
        {
            this.Text = "Prevención Osteomuscular";
            this.Size = new System.Drawing.Size(600, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // TODO Equipo 2: construir la UI aquí
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new System.Windows.Forms.Label();
            botonCuello = new Guna.UI2.WinForms.Guna2Button();
            BotonMuñeca = new Guna.UI2.WinForms.Guna2Button();
            BotonEspalda = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            LabelEstiramiento = new System.Windows.Forms.Label();
            TemporizadorBar = new System.Windows.Forms.ProgressBar();
            label3 = new System.Windows.Forms.Label();
            BotonSiguiente = new Guna.UI2.WinForms.Guna2Button();
            BotonPausa = new Guna.UI2.WinForms.Guna2Button();
            BotonAnterior = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lora", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label1.Location = new System.Drawing.Point(171, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(618, 71);
            label1.TabIndex = 0;
            label1.Text = "Prevencion Osteomuscular";
            label1.Click += label1_Click;
            // 
            // botonCuello
            // 
            botonCuello.Animated = true;
            botonCuello.BackColor = System.Drawing.Color.Transparent;
            botonCuello.BorderRadius = 20;
            botonCuello.CustomizableEdges = customizableEdges1;
            botonCuello.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            botonCuello.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            botonCuello.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            botonCuello.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            botonCuello.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            botonCuello.Font = new System.Drawing.Font("Nunito Sans Normal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            botonCuello.ForeColor = System.Drawing.Color.Black;
            botonCuello.Location = new System.Drawing.Point(89, 117);
            botonCuello.Name = "botonCuello";
            botonCuello.ShadowDecoration.CustomizableEdges = customizableEdges2;
            botonCuello.Size = new System.Drawing.Size(221, 79);
            botonCuello.TabIndex = 2;
            botonCuello.Text = "Cuello";
            // 
            // BotonMuñeca
            // 
            BotonMuñeca.Animated = true;
            BotonMuñeca.BackColor = System.Drawing.Color.Transparent;
            BotonMuñeca.BorderRadius = 20;
            BotonMuñeca.CustomizableEdges = customizableEdges3;
            BotonMuñeca.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BotonMuñeca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BotonMuñeca.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BotonMuñeca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BotonMuñeca.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            BotonMuñeca.Font = new System.Drawing.Font("Nunito Sans Normal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BotonMuñeca.ForeColor = System.Drawing.Color.Black;
            BotonMuñeca.Location = new System.Drawing.Point(352, 117);
            BotonMuñeca.Name = "BotonMuñeca";
            BotonMuñeca.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BotonMuñeca.Size = new System.Drawing.Size(221, 79);
            BotonMuñeca.TabIndex = 3;
            BotonMuñeca.Text = "Muñecas";
            // 
            // BotonEspalda
            // 
            BotonEspalda.Animated = true;
            BotonEspalda.BackColor = System.Drawing.Color.Transparent;
            BotonEspalda.BorderRadius = 20;
            BotonEspalda.CustomizableEdges = customizableEdges5;
            BotonEspalda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BotonEspalda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BotonEspalda.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BotonEspalda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BotonEspalda.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            BotonEspalda.Font = new System.Drawing.Font("Nunito Sans Normal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BotonEspalda.ForeColor = System.Drawing.Color.Black;
            BotonEspalda.Location = new System.Drawing.Point(627, 117);
            BotonEspalda.Name = "BotonEspalda";
            BotonEspalda.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BotonEspalda.Size = new System.Drawing.Size(221, 79);
            BotonEspalda.TabIndex = 4;
            BotonEspalda.Text = "Espalda";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(50, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(798, 162);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(325, 304);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(257, 20);
            label2.TabIndex = 6;
            label2.Text = "Aqui van las imagenes o animaciones";
            // 
            // LabelEstiramiento
            // 
            LabelEstiramiento.AutoSize = true;
            LabelEstiramiento.Font = new System.Drawing.Font("Lora", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            LabelEstiramiento.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            LabelEstiramiento.Location = new System.Drawing.Point(41, 413);
            LabelEstiramiento.Name = "LabelEstiramiento";
            LabelEstiramiento.Size = new System.Drawing.Size(598, 45);
            LabelEstiramiento.TabIndex = 7;
            LabelEstiramiento.Text = "Estiramiento de (Cambia con los botones)";
            // 
            // TemporizadorBar
            // 
            TemporizadorBar.Location = new System.Drawing.Point(50, 479);
            TemporizadorBar.Name = "TemporizadorBar";
            TemporizadorBar.Size = new System.Drawing.Size(373, 70);
            TemporizadorBar.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Lora", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label3.Location = new System.Drawing.Point(50, 552);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(146, 36);
            label3.TabIndex = 9;
            label3.Text = "Paso _ de _";
            // 
            // BotonSiguiente
            // 
            BotonSiguiente.Animated = true;
            BotonSiguiente.BackColor = System.Drawing.Color.Transparent;
            BotonSiguiente.BorderRadius = 20;
            BotonSiguiente.CustomizableEdges = customizableEdges7;
            BotonSiguiente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BotonSiguiente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BotonSiguiente.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BotonSiguiente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BotonSiguiente.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            BotonSiguiente.Font = new System.Drawing.Font("Nunito Sans Normal", 14F, System.Drawing.FontStyle.Bold);
            BotonSiguiente.ForeColor = System.Drawing.Color.Black;
            BotonSiguiente.Location = new System.Drawing.Point(579, 620);
            BotonSiguiente.Name = "BotonSiguiente";
            BotonSiguiente.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BotonSiguiente.Size = new System.Drawing.Size(159, 65);
            BotonSiguiente.TabIndex = 12;
            BotonSiguiente.Text = "Siguiente >";
            // 
            // BotonPausa
            // 
            BotonPausa.Animated = true;
            BotonPausa.BackColor = System.Drawing.Color.Transparent;
            BotonPausa.BorderRadius = 20;
            BotonPausa.CustomizableEdges = customizableEdges9;
            BotonPausa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BotonPausa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BotonPausa.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BotonPausa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BotonPausa.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            BotonPausa.Font = new System.Drawing.Font("Nunito Sans Normal", 14F, System.Drawing.FontStyle.Bold);
            BotonPausa.ForeColor = System.Drawing.Color.Black;
            BotonPausa.Location = new System.Drawing.Point(427, 620);
            BotonPausa.Name = "BotonPausa";
            BotonPausa.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BotonPausa.Size = new System.Drawing.Size(146, 65);
            BotonPausa.TabIndex = 11;
            BotonPausa.Text = "II Pausar";
            // 
            // BotonAnterior
            // 
            BotonAnterior.Animated = true;
            BotonAnterior.BackColor = System.Drawing.Color.Transparent;
            BotonAnterior.BorderRadius = 20;
            BotonAnterior.CustomizableEdges = customizableEdges11;
            BotonAnterior.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BotonAnterior.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BotonAnterior.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BotonAnterior.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BotonAnterior.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            BotonAnterior.Font = new System.Drawing.Font("Nunito Sans Normal", 14F, System.Drawing.FontStyle.Bold);
            BotonAnterior.ForeColor = System.Drawing.Color.Black;
            BotonAnterior.Location = new System.Drawing.Point(271, 620);
            BotonAnterior.Name = "BotonAnterior";
            BotonAnterior.ShadowDecoration.CustomizableEdges = customizableEdges12;
            BotonAnterior.Size = new System.Drawing.Size(150, 65);
            BotonAnterior.TabIndex = 10;
            BotonAnterior.Text = "< Anterior";
            // 
            // OsteoForm
            // 
            BackColor = System.Drawing.Color.FromArgb(243, 248, 253);
            ClientSize = new System.Drawing.Size(934, 697);
            Controls.Add(BotonSiguiente);
            Controls.Add(BotonPausa);
            Controls.Add(BotonAnterior);
            Controls.Add(label3);
            Controls.Add(TemporizadorBar);
            Controls.Add(LabelEstiramiento);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(BotonEspalda);
            Controls.Add(BotonMuñeca);
            Controls.Add(botonCuello);
            Controls.Add(label1);
            Name = "OsteoForm";
            Text = "Osteo";
            Load += OsteoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void OsteoForm_Load(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
        private Guna.UI2.WinForms.Guna2Button botonCuello;
        private Guna.UI2.WinForms.Guna2Button BotonMuñeca;
        private Guna.UI2.WinForms.Guna2Button BotonEspalda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelEstiramiento;
        private System.Windows.Forms.ProgressBar TemporizadorBar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button BotonSiguiente;
        private Guna.UI2.WinForms.Guna2Button BotonPausa;
        private Guna.UI2.WinForms.Guna2Button BotonAnterior;
        private System.Windows.Forms.Label label1;
    }
}
