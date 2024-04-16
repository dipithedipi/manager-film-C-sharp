namespace manager_film
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new ReaLTaiizor.Controls.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infoGroupBox = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.cmb_genere = new ReaLTaiizor.Controls.ComboBoxEdit();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.input_mDurata = new ReaLTaiizor.Controls.DungeonNumeric();
            this.input_hDurata = new ReaLTaiizor.Controls.DungeonNumeric();
            this.date_dataUscita = new ReaLTaiizor.Controls.PoisonDateTime();
            this.input_trama = new ReaLTaiizor.Controls.AloneTextBox();
            this.input_nome = new ReaLTaiizor.Controls.AloneTextBox();
            this.input_id = new ReaLTaiizor.Controls.AloneTextBox();
            this.btn_annulla = new ReaLTaiizor.Controls.AirButton();
            this.btn_salva = new ReaLTaiizor.Controls.AirButton();
            this.headerLabel6 = new ReaLTaiizor.Controls.HeaderLabel();
            this.headerLabel5 = new ReaLTaiizor.Controls.HeaderLabel();
            this.headerLabel4 = new ReaLTaiizor.Controls.HeaderLabel();
            this.headerLabel3 = new ReaLTaiizor.Controls.HeaderLabel();
            this.headerLabel2 = new ReaLTaiizor.Controls.HeaderLabel();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.thunderGroupBox1 = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.btn_esci = new ReaLTaiizor.Controls.AirButton();
            this.btn_nuovoFilm = new ReaLTaiizor.Controls.AirButton();
            this.btn_elimina = new ReaLTaiizor.Controls.AirButton();
            this.btn_modifica = new ReaLTaiizor.Controls.AirButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.infoGroupBox.SuspendLayout();
            this.thunderGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.ActiveLineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.tabPage1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.tabPage1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabPage1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.tabPage1.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.tabPage1.ControlBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.tabPage2);
            this.tabPage1.Controls.Add(this.tabPage3);
            this.tabPage1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabPage1.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.tabPage1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.tabPage1.ItemSize = new System.Drawing.Size(44, 135);
            this.tabPage1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.tabPage1.LineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.tabPage1.Location = new System.Drawing.Point(12, 12);
            this.tabPage1.Multiline = true;
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.tabPage1.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.tabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.tabPage1.SelectedIndex = 0;
            this.tabPage1.Size = new System.Drawing.Size(913, 541);
            this.tabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.tabPage1.StringType = System.Drawing.StringAlignment.Near;
            this.tabPage1.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.tabPage1.TabIndex = 0;
            this.tabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.infoGroupBox);
            this.tabPage2.Controls.Add(this.thunderGroupBox1);
            this.tabPage2.Location = new System.Drawing.Point(139, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(770, 533);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Home";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(728, 172);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.infoGroupBox.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.infoGroupBox.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.infoGroupBox.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.infoGroupBox.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.infoGroupBox.Controls.Add(this.cmb_genere);
            this.infoGroupBox.Controls.Add(this.foxLabel2);
            this.infoGroupBox.Controls.Add(this.foxLabel1);
            this.infoGroupBox.Controls.Add(this.input_mDurata);
            this.infoGroupBox.Controls.Add(this.input_hDurata);
            this.infoGroupBox.Controls.Add(this.date_dataUscita);
            this.infoGroupBox.Controls.Add(this.input_trama);
            this.infoGroupBox.Controls.Add(this.input_nome);
            this.infoGroupBox.Controls.Add(this.input_id);
            this.infoGroupBox.Controls.Add(this.btn_annulla);
            this.infoGroupBox.Controls.Add(this.btn_salva);
            this.infoGroupBox.Controls.Add(this.headerLabel6);
            this.infoGroupBox.Controls.Add(this.headerLabel5);
            this.infoGroupBox.Controls.Add(this.headerLabel4);
            this.infoGroupBox.Controls.Add(this.headerLabel3);
            this.infoGroupBox.Controls.Add(this.headerLabel2);
            this.infoGroupBox.Controls.Add(this.headerLabel1);
            this.infoGroupBox.Enabled = false;
            this.infoGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.infoGroupBox.Location = new System.Drawing.Point(343, 203);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(413, 320);
            this.infoGroupBox.TabIndex = 1;
            this.infoGroupBox.Text = "Info";
            this.infoGroupBox.Click += new System.EventHandler(this.thunderGroupBox2_Click);
            // 
            // cmb_genere
            // 
            this.cmb_genere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmb_genere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_genere.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_genere.DropDownHeight = 100;
            this.cmb_genere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_genere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_genere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cmb_genere.FormattingEnabled = true;
            this.cmb_genere.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmb_genere.IntegralHeight = false;
            this.cmb_genere.ItemHeight = 20;
            this.cmb_genere.Location = new System.Drawing.Point(132, 232);
            this.cmb_genere.Name = "cmb_genere";
            this.cmb_genere.Size = new System.Drawing.Size(255, 26);
            this.cmb_genere.StartIndex = 0;
            this.cmb_genere.TabIndex = 16;
            this.cmb_genere.SelectedIndexChanged += new System.EventHandler(this.cmb_genere_SelectedIndexChanged);
            // 
            // foxLabel2
            // 
            this.foxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.foxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel2.Location = new System.Drawing.Point(258, 142);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(32, 34);
            this.foxLabel2.TabIndex = 15;
            this.foxLabel2.Text = "m";
            this.foxLabel2.Click += new System.EventHandler(this.foxLabel2_Click);
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(132, 142);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(19, 34);
            this.foxLabel1.TabIndex = 14;
            this.foxLabel1.Text = "h";
            this.foxLabel1.Click += new System.EventHandler(this.foxLabel1_Click);
            // 
            // input_mDurata
            // 
            this.input_mDurata.BackColor = System.Drawing.Color.Transparent;
            this.input_mDurata.BackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.input_mDurata.BackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.input_mDurata.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.input_mDurata.ButtonForeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.input_mDurata.ButtonForeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.input_mDurata.Font = new System.Drawing.Font("Tahoma", 11F);
            this.input_mDurata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.input_mDurata.Location = new System.Drawing.Point(294, 145);
            this.input_mDurata.Maximum = ((long)(100));
            this.input_mDurata.Minimum = ((long)(0));
            this.input_mDurata.MinimumSize = new System.Drawing.Size(70, 23);
            this.input_mDurata.Name = "input_mDurata";
            this.input_mDurata.Size = new System.Drawing.Size(93, 28);
            this.input_mDurata.TabIndex = 13;
            this.input_mDurata.Text = "dungeonNumeric2";
            this.input_mDurata.TextAlignment = ReaLTaiizor.Controls.DungeonNumeric._TextAlignment.Near;
            this.input_mDurata.Value = ((long)(0));
            this.input_mDurata.Click += new System.EventHandler(this.input_mDurata_Click);
            // 
            // input_hDurata
            // 
            this.input_hDurata.BackColor = System.Drawing.Color.Transparent;
            this.input_hDurata.BackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.input_hDurata.BackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.input_hDurata.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.input_hDurata.ButtonForeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.input_hDurata.ButtonForeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.input_hDurata.Font = new System.Drawing.Font("Tahoma", 11F);
            this.input_hDurata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.input_hDurata.Location = new System.Drawing.Point(157, 145);
            this.input_hDurata.Maximum = ((long)(100));
            this.input_hDurata.Minimum = ((long)(0));
            this.input_hDurata.MinimumSize = new System.Drawing.Size(70, 23);
            this.input_hDurata.Name = "input_hDurata";
            this.input_hDurata.Size = new System.Drawing.Size(93, 28);
            this.input_hDurata.TabIndex = 12;
            this.input_hDurata.Text = "dungeonNumeric1";
            this.input_hDurata.TextAlignment = ReaLTaiizor.Controls.DungeonNumeric._TextAlignment.Near;
            this.input_hDurata.Value = ((long)(0));
            this.input_hDurata.Click += new System.EventHandler(this.input_hDurata_Click);
            // 
            // date_dataUscita
            // 
            this.date_dataUscita.Location = new System.Drawing.Point(132, 187);
            this.date_dataUscita.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_dataUscita.Name = "date_dataUscita";
            this.date_dataUscita.Size = new System.Drawing.Size(255, 30);
            this.date_dataUscita.TabIndex = 10;
            this.date_dataUscita.ValueChanged += new System.EventHandler(this.date_dataUscita_ValueChanged);
            // 
            // input_trama
            // 
            this.input_trama.BackColor = System.Drawing.Color.Transparent;
            this.input_trama.EnabledCalc = true;
            this.input_trama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.input_trama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.input_trama.Location = new System.Drawing.Point(132, 103);
            this.input_trama.MaxLength = 32767;
            this.input_trama.MultiLine = false;
            this.input_trama.Name = "input_trama";
            this.input_trama.ReadOnly = false;
            this.input_trama.Size = new System.Drawing.Size(255, 29);
            this.input_trama.TabIndex = 9;
            this.input_trama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.input_trama.UseSystemPasswordChar = false;
            this.input_trama.TextChanged += new System.EventHandler(this.input_trama_TextChanged);
            // 
            // input_nome
            // 
            this.input_nome.BackColor = System.Drawing.Color.Transparent;
            this.input_nome.EnabledCalc = true;
            this.input_nome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.input_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.input_nome.Location = new System.Drawing.Point(132, 71);
            this.input_nome.MaxLength = 32767;
            this.input_nome.MultiLine = false;
            this.input_nome.Name = "input_nome";
            this.input_nome.ReadOnly = false;
            this.input_nome.Size = new System.Drawing.Size(255, 29);
            this.input_nome.TabIndex = 8;
            this.input_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.input_nome.UseSystemPasswordChar = false;
            this.input_nome.TextChanged += new System.EventHandler(this.input_nome_TextChanged);
            // 
            // input_id
            // 
            this.input_id.BackColor = System.Drawing.Color.Transparent;
            this.input_id.EnabledCalc = false;
            this.input_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.input_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.input_id.Location = new System.Drawing.Point(132, 36);
            this.input_id.MaxLength = 32767;
            this.input_id.MultiLine = false;
            this.input_id.Name = "input_id";
            this.input_id.ReadOnly = false;
            this.input_id.Size = new System.Drawing.Size(255, 29);
            this.input_id.TabIndex = 7;
            this.input_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.input_id.UseSystemPasswordChar = false;
            this.input_id.TextChanged += new System.EventHandler(this.input_id_TextChanged);
            // 
            // btn_annulla
            // 
            this.btn_annulla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_annulla.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btn_annulla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_annulla.Image = null;
            this.btn_annulla.Location = new System.Drawing.Point(132, 280);
            this.btn_annulla.Name = "btn_annulla";
            this.btn_annulla.NoRounding = false;
            this.btn_annulla.Size = new System.Drawing.Size(126, 26);
            this.btn_annulla.TabIndex = 6;
            this.btn_annulla.Text = "Annulla";
            this.btn_annulla.Transparent = false;
            this.btn_annulla.Click += new System.EventHandler(this.btn_annulla_Click);
            // 
            // btn_salva
            // 
            this.btn_salva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salva.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btn_salva.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_salva.Image = null;
            this.btn_salva.Location = new System.Drawing.Point(268, 280);
            this.btn_salva.Name = "btn_salva";
            this.btn_salva.NoRounding = false;
            this.btn_salva.Size = new System.Drawing.Size(119, 26);
            this.btn_salva.TabIndex = 4;
            this.btn_salva.Text = "Salva";
            this.btn_salva.Transparent = false;
            this.btn_salva.Click += new System.EventHandler(this.btn_salva_Click);
            // 
            // headerLabel6
            // 
            this.headerLabel6.AutoSize = true;
            this.headerLabel6.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel6.Location = new System.Drawing.Point(27, 234);
            this.headerLabel6.Name = "headerLabel6";
            this.headerLabel6.Size = new System.Drawing.Size(63, 18);
            this.headerLabel6.TabIndex = 5;
            this.headerLabel6.Text = "Genere";
            this.headerLabel6.Click += new System.EventHandler(this.headerLabel6_Click);
            // 
            // headerLabel5
            // 
            this.headerLabel5.AutoSize = true;
            this.headerLabel5.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel5.Location = new System.Drawing.Point(27, 192);
            this.headerLabel5.Name = "headerLabel5";
            this.headerLabel5.Size = new System.Drawing.Size(93, 18);
            this.headerLabel5.TabIndex = 4;
            this.headerLabel5.Text = "Data uscita";
            this.headerLabel5.Click += new System.EventHandler(this.headerLabel5_Click);
            // 
            // headerLabel4
            // 
            this.headerLabel4.AutoSize = true;
            this.headerLabel4.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel4.Location = new System.Drawing.Point(26, 148);
            this.headerLabel4.Name = "headerLabel4";
            this.headerLabel4.Size = new System.Drawing.Size(58, 18);
            this.headerLabel4.TabIndex = 3;
            this.headerLabel4.Text = "Durata";
            this.headerLabel4.Click += new System.EventHandler(this.headerLabel4_Click);
            // 
            // headerLabel3
            // 
            this.headerLabel3.AutoSize = true;
            this.headerLabel3.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel3.Location = new System.Drawing.Point(26, 108);
            this.headerLabel3.Name = "headerLabel3";
            this.headerLabel3.Size = new System.Drawing.Size(56, 18);
            this.headerLabel3.TabIndex = 2;
            this.headerLabel3.Text = "Trama";
            this.headerLabel3.Click += new System.EventHandler(this.headerLabel3_Click);
            // 
            // headerLabel2
            // 
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel2.Location = new System.Drawing.Point(26, 74);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(53, 18);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "Nome";
            this.headerLabel2.Click += new System.EventHandler(this.headerLabel2_Click);
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel1.Location = new System.Drawing.Point(26, 39);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(21, 18);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "Id";
            this.headerLabel1.Click += new System.EventHandler(this.headerLabel1_Click);
            // 
            // thunderGroupBox1
            // 
            this.thunderGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.thunderGroupBox1.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.thunderGroupBox1.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.thunderGroupBox1.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.thunderGroupBox1.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.thunderGroupBox1.Controls.Add(this.btn_esci);
            this.thunderGroupBox1.Controls.Add(this.btn_nuovoFilm);
            this.thunderGroupBox1.Controls.Add(this.btn_elimina);
            this.thunderGroupBox1.Controls.Add(this.btn_modifica);
            this.thunderGroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thunderGroupBox1.Location = new System.Drawing.Point(28, 203);
            this.thunderGroupBox1.Name = "thunderGroupBox1";
            this.thunderGroupBox1.Size = new System.Drawing.Size(287, 320);
            this.thunderGroupBox1.TabIndex = 0;
            this.thunderGroupBox1.Text = "Controlli";
            // 
            // btn_esci
            // 
            this.btn_esci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_esci.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btn_esci.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_esci.Image = null;
            this.btn_esci.Location = new System.Drawing.Point(26, 207);
            this.btn_esci.Name = "btn_esci";
            this.btn_esci.NoRounding = false;
            this.btn_esci.Size = new System.Drawing.Size(229, 45);
            this.btn_esci.TabIndex = 3;
            this.btn_esci.Text = "Esci";
            this.btn_esci.Transparent = false;
            this.btn_esci.Click += new System.EventHandler(this.btn_esci_Click);
            // 
            // btn_nuovoFilm
            // 
            this.btn_nuovoFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuovoFilm.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btn_nuovoFilm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_nuovoFilm.Image = null;
            this.btn_nuovoFilm.Location = new System.Drawing.Point(26, 145);
            this.btn_nuovoFilm.Name = "btn_nuovoFilm";
            this.btn_nuovoFilm.NoRounding = false;
            this.btn_nuovoFilm.Size = new System.Drawing.Size(229, 45);
            this.btn_nuovoFilm.TabIndex = 2;
            this.btn_nuovoFilm.Text = "Nuovo film";
            this.btn_nuovoFilm.Transparent = false;
            this.btn_nuovoFilm.Click += new System.EventHandler(this.btn_nuovoFilm_Click);
            // 
            // btn_elimina
            // 
            this.btn_elimina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_elimina.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btn_elimina.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_elimina.Image = null;
            this.btn_elimina.Location = new System.Drawing.Point(155, 83);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.NoRounding = false;
            this.btn_elimina.Size = new System.Drawing.Size(100, 45);
            this.btn_elimina.TabIndex = 1;
            this.btn_elimina.Text = "Elimina";
            this.btn_elimina.Transparent = false;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // btn_modifica
            // 
            this.btn_modifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifica.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btn_modifica.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_modifica.Image = null;
            this.btn_modifica.Location = new System.Drawing.Point(26, 83);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.NoRounding = false;
            this.btn_modifica.Size = new System.Drawing.Size(100, 45);
            this.btn_modifica.TabIndex = 0;
            this.btn_modifica.Text = "Modifica";
            this.btn_modifica.Transparent = false;
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.tabPage3.Location = new System.Drawing.Point(139, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(770, 533);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Attori";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 565);
            this.Controls.Add(this.tabPage1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.thunderGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.Controls.ThunderGroupBox infoGroupBox;
        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox1;
        private ReaLTaiizor.Controls.AirButton btn_esci;
        private ReaLTaiizor.Controls.AirButton btn_nuovoFilm;
        private ReaLTaiizor.Controls.AirButton btn_elimina;
        private ReaLTaiizor.Controls.AirButton btn_modifica;
        private System.Windows.Forms.TabPage tabPage3;
        private ReaLTaiizor.Controls.AloneTextBox input_trama;
        private ReaLTaiizor.Controls.AloneTextBox input_nome;
        private ReaLTaiizor.Controls.AloneTextBox input_id;
        private ReaLTaiizor.Controls.AirButton btn_annulla;
        private ReaLTaiizor.Controls.AirButton btn_salva;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel6;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel5;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel4;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel3;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel2;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.PoisonDateTime date_dataUscita;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.DungeonNumeric input_mDurata;
        private ReaLTaiizor.Controls.DungeonNumeric input_hDurata;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.ComboBoxEdit cmb_genere;
    }
}

