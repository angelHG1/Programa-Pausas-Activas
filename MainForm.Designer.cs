namespace PausasActivas
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnTemporizadores;
        private System.Windows.Forms.Button btnOsteo;
        private System.Windows.Forms.Button btnSaludMental;
        private System.Windows.Forms.Button btnSedentarismo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            this.Text            = "PausasActivas";
            this.Size            = new System.Drawing.Size(420, 520);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.BackColor       = System.Drawing.Color.FromArgb(235, 245, 255);
            this.Font            = new System.Drawing.Font("Segoe UI", 10f);

            tableMain = new System.Windows.Forms.TableLayoutPanel();
            tableMain.Dock        = System.Windows.Forms.DockStyle.Fill;
            tableMain.ColumnCount = 1;
            tableMain.RowCount    = 6;
            tableMain.Padding     = new System.Windows.Forms.Padding(30, 20, 30, 20);
            tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60));  // título
            tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));  // subtítulo
            tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,  25));  // btn 1
            tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,  25));  // btn 2
            tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,  25));  // btn 3
            tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,  25));  // btn 4

            lblTitulo = new System.Windows.Forms.Label();
            lblTitulo.Text      = "🧘 PausasActivas";
            lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);
            lblTitulo.Dock      = System.Windows.Forms.DockStyle.Fill;
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            lblSubtitulo = new System.Windows.Forms.Label();
            lblSubtitulo.Text      = "Software de bienestar laboral";
            lblSubtitulo.Font      = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Italic);
            lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(90, 90, 110);
            lblSubtitulo.Dock      = System.Windows.Forms.DockStyle.Fill;
            lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            btnTemporizadores = CrearBoton("Temporizadores y Alertas",
                                           System.Drawing.Color.FromArgb(41, 128, 215));
            btnTemporizadores.Click += btnTemporizadores_Click;

            btnOsteo = CrearBoton("Prevención Osteomuscular",
                                   System.Drawing.Color.FromArgb(39, 174, 96));
            btnOsteo.Click += btnOsteo_Click;

            btnSaludMental = CrearBoton("Salud Mental",
                                         System.Drawing.Color.FromArgb(142, 68, 173));
            btnSaludMental.Click += btnSaludMental_Click;

            btnSedentarismo = CrearBoton("Anti-Sedentarismo",
                                          System.Drawing.Color.FromArgb(211, 84, 0));
            btnSedentarismo.Click += btnSedentarismo_Click;

            // ── Ensamblar ─────────────────────────────────────
            tableMain.Controls.Add(lblTitulo,         0, 0);
            tableMain.Controls.Add(lblSubtitulo,      0, 1);
            tableMain.Controls.Add(btnTemporizadores, 0, 2);
            tableMain.Controls.Add(btnOsteo,          0, 3);
            tableMain.Controls.Add(btnSaludMental,    0, 4);
            tableMain.Controls.Add(btnSedentarismo,   0, 5);

            this.Controls.Add(tableMain);
        }

        // ── Helper: fábrica de botones ────────────────────────
        private System.Windows.Forms.Button CrearBoton(string texto,
                                                        System.Drawing.Color color)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Text      = texto;
            btn.Font      = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.BackColor = color;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Dock      = System.Windows.Forms.DockStyle.Fill;
            btn.Margin    = new System.Windows.Forms.Padding(0, 6, 0, 6);
            btn.Cursor    = System.Windows.Forms.Cursors.Hand;
            return btn;
        }
    }
}
