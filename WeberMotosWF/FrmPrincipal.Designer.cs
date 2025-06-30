namespace WeberMotosWF
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage3 = new TabPage();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            TabPage1 = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnExcluir = new MaterialSkin.Controls.MaterialButton();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            TabPage2 = new TabPage();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            dateTimePicker1 = new DateTimePicker();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            btnFinalizar = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            TabPage1.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TabPage2.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            materialCard3.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(TabPage1);
            materialTabControl1.Controls.Add(TabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(944, 596);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(materialButton1);
            tabPage3.Controls.Add(materialLabel2);
            tabPage3.Controls.Add(materialLabel1);
            tabPage3.Controls.Add(materialTextBox2);
            tabPage3.Controls.Add(materialTextBox1);
            tabPage3.ImageKey = "iconmonstr-wrench-12-32.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(936, 553);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Add Peça";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Top;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Cursor = Cursors.Hand;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Microsoft YaHei", 8.25F);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(392, 305);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.RightToLeft = RightToLeft.No;
            materialButton1.Size = new Size(106, 36);
            materialButton1.TabIndex = 12;
            materialButton1.Text = "Cadastrar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Top;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(148, 225);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.RightToLeft = RightToLeft.No;
            materialLabel2.Size = new Size(120, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Preço de compra";
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(148, 116);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.RightToLeft = RightToLeft.No;
            materialLabel1.Size = new Size(103, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Nome da peça";
            // 
            // materialTextBox2
            // 
            materialTextBox2.Anchor = AnchorStyles.Top;
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.Hint = "Ex: 50,00";
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(312, 208);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.RightToLeft = RightToLeft.No;
            materialTextBox2.Size = new Size(306, 50);
            materialTextBox2.TabIndex = 8;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            materialTextBox1.Anchor = AnchorStyles.Top;
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "Ex: Pastilha de freio CG 160";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(312, 97);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.RightToLeft = RightToLeft.No;
            materialTextBox1.Size = new Size(306, 50);
            materialTextBox1.TabIndex = 9;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(materialCard1);
            TabPage1.Controls.Add(dataGridView1);
            TabPage1.ImageKey = "iconmonstr-wrench-24-32.png";
            TabPage1.Location = new Point(4, 39);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(936, 553);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Peças";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnExcluir);
            materialCard1.Controls.Add(btnEditar);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Bottom;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 501);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(930, 49);
            materialCard1.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.Location = new Point(120, 8);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(18, 7);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.ScrollBar;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(930, 547);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Codigo";
            Column1.Name = "Column1";
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descrição";
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.HeaderText = "Preço de compra";
            Column3.Name = "Column3";
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "Preço de venda";
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(materialCard5);
            TabPage2.Controls.Add(materialCard4);
            TabPage2.Controls.Add(materialCard3);
            TabPage2.Cursor = Cursors.Hand;
            TabPage2.ImageKey = "iconmonstr-banknote-12-32.png";
            TabPage2.Location = new Point(4, 39);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(936, 553);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Venda";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(dateTimePicker1);
            materialCard5.Controls.Add(materialButton2);
            materialCard5.Controls.Add(materialComboBox1);
            materialCard5.Controls.Add(materialLabel6);
            materialCard5.Controls.Add(materialLabel4);
            materialCard5.Controls.Add(materialLabel8);
            materialCard5.Controls.Add(materialLabel10);
            materialCard5.Controls.Add(materialLabel7);
            materialCard5.Controls.Add(materialLabel9);
            materialCard5.Controls.Add(materialLabel5);
            materialCard5.Controls.Add(materialLabel3);
            materialCard5.Controls.Add(materialTextBox7);
            materialCard5.Controls.Add(materialTextBox6);
            materialCard5.Controls.Add(materialTextBox8);
            materialCard5.Controls.Add(materialTextBox5);
            materialCard5.Controls.Add(materialTextBox3);
            materialCard5.Depth = 0;
            materialCard5.Dock = DockStyle.Fill;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(3, 3);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(930, 328);
            materialCard5.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Location = new Point(192, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // materialButton2
            // 
            materialButton2.Anchor = AnchorStyles.Top;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(489, 272);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 3;
            materialButton2.Text = "+";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialComboBox1
            // 
            materialComboBox1.Anchor = AnchorStyles.Top;
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(192, 262);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(264, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 2;
            // 
            // materialLabel6
            // 
            materialLabel6.Anchor = AnchorStyles.Top;
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(34, 280);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(117, 19);
            materialLabel6.TabIndex = 1;
            materialLabel6.Text = "Peças utilizadas";
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = AnchorStyles.Top;
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(34, 102);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(111, 19);
            materialLabel4.TabIndex = 1;
            materialLabel4.Text = "Data do serviço";
            // 
            // materialLabel8
            // 
            materialLabel8.Anchor = AnchorStyles.Top;
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(503, 102);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(104, 19);
            materialLabel8.TabIndex = 1;
            materialLabel8.Text = "Placa da moto";
            // 
            // materialLabel10
            // 
            materialLabel10.Anchor = AnchorStyles.Top;
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(503, 224);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(96, 19);
            materialLabel10.TabIndex = 1;
            materialLabel10.Text = "Foto da moto";
            // 
            // materialLabel7
            // 
            materialLabel7.Anchor = AnchorStyles.Top;
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(503, 169);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(117, 19);
            materialLabel7.TabIndex = 1;
            materialLabel7.Text = "Modelo da moto";
            // 
            // materialLabel9
            // 
            materialLabel9.Anchor = AnchorStyles.Top;
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(34, 224);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(49, 19);
            materialLabel9.TabIndex = 1;
            materialLabel9.Text = "Cliente";
            // 
            // materialLabel5
            // 
            materialLabel5.Anchor = AnchorStyles.Top;
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(34, 169);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(132, 19);
            materialLabel5.TabIndex = 1;
            materialLabel5.Text = "Horas trabalhadas";
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Top;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(34, 36);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(147, 19);
            materialLabel3.TabIndex = 1;
            materialLabel3.Text = "Descrição do serviço";
            // 
            // materialTextBox7
            // 
            materialTextBox7.Anchor = AnchorStyles.Top;
            materialTextBox7.AnimateReadOnly = false;
            materialTextBox7.BorderStyle = BorderStyle.None;
            materialTextBox7.Depth = 0;
            materialTextBox7.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox7.LeadingIcon = null;
            materialTextBox7.Location = new Point(661, 84);
            materialTextBox7.MaxLength = 50;
            materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox7.Multiline = false;
            materialTextBox7.Name = "materialTextBox7";
            materialTextBox7.Size = new Size(264, 50);
            materialTextBox7.TabIndex = 0;
            materialTextBox7.Text = "";
            materialTextBox7.TrailingIcon = null;
            // 
            // materialTextBox6
            // 
            materialTextBox6.Anchor = AnchorStyles.Top;
            materialTextBox6.AnimateReadOnly = false;
            materialTextBox6.BorderStyle = BorderStyle.None;
            materialTextBox6.Depth = 0;
            materialTextBox6.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox6.LeadingIcon = null;
            materialTextBox6.Location = new Point(661, 151);
            materialTextBox6.MaxLength = 50;
            materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox6.Multiline = false;
            materialTextBox6.Name = "materialTextBox6";
            materialTextBox6.Size = new Size(264, 50);
            materialTextBox6.TabIndex = 0;
            materialTextBox6.Text = "";
            materialTextBox6.TrailingIcon = null;
            // 
            // materialTextBox8
            // 
            materialTextBox8.Anchor = AnchorStyles.Top;
            materialTextBox8.AnimateReadOnly = false;
            materialTextBox8.BorderStyle = BorderStyle.None;
            materialTextBox8.Depth = 0;
            materialTextBox8.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox8.LeadingIcon = null;
            materialTextBox8.Location = new Point(192, 206);
            materialTextBox8.MaxLength = 50;
            materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox8.Multiline = false;
            materialTextBox8.Name = "materialTextBox8";
            materialTextBox8.Size = new Size(264, 50);
            materialTextBox8.TabIndex = 0;
            materialTextBox8.Text = "";
            materialTextBox8.TrailingIcon = null;
            // 
            // materialTextBox5
            // 
            materialTextBox5.Anchor = AnchorStyles.Top;
            materialTextBox5.AnimateReadOnly = false;
            materialTextBox5.BorderStyle = BorderStyle.None;
            materialTextBox5.Depth = 0;
            materialTextBox5.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox5.LeadingIcon = null;
            materialTextBox5.Location = new Point(192, 151);
            materialTextBox5.MaxLength = 50;
            materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox5.Multiline = false;
            materialTextBox5.Name = "materialTextBox5";
            materialTextBox5.Size = new Size(264, 50);
            materialTextBox5.TabIndex = 0;
            materialTextBox5.Text = "";
            materialTextBox5.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            materialTextBox3.Anchor = AnchorStyles.Top;
            materialTextBox3.AnimateReadOnly = false;
            materialTextBox3.BorderStyle = BorderStyle.None;
            materialTextBox3.Depth = 0;
            materialTextBox3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox3.LeadingIcon = null;
            materialTextBox3.Location = new Point(192, 19);
            materialTextBox3.MaxLength = 50;
            materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox3.Multiline = false;
            materialTextBox3.Name = "materialTextBox3";
            materialTextBox3.Size = new Size(733, 50);
            materialTextBox3.TabIndex = 0;
            materialTextBox3.Text = "";
            materialTextBox3.TrailingIcon = null;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(dataGridView2);
            materialCard4.Depth = 0;
            materialCard4.Dock = DockStyle.Bottom;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(3, 331);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(930, 174);
            materialCard4.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6 });
            dataGridView2.Location = new Point(14, 14);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(902, 104);
            dataGridView2.TabIndex = 0;
            // 
            // Column5
            // 
            Column5.HeaderText = "Peça";
            Column5.Name = "Column5";
            Column5.Width = 300;
            // 
            // Column6
            // 
            Column6.HeaderText = "Valor";
            Column6.Name = "Column6";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(btnFinalizar);
            materialCard3.Depth = 0;
            materialCard3.Dock = DockStyle.Bottom;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(3, 505);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(930, 45);
            materialCard3.TabIndex = 1;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Anchor = AnchorStyles.Top;
            btnFinalizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFinalizar.Cursor = Cursors.Hand;
            btnFinalizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFinalizar.Depth = 0;
            btnFinalizar.HighEmphasis = true;
            btnFinalizar.Icon = null;
            btnFinalizar.Location = new Point(408, 3);
            btnFinalizar.Margin = new Padding(4, 6, 4, 6);
            btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER;
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.NoAccentTextColor = Color.Empty;
            btnFinalizar.Size = new Size(145, 36);
            btnFinalizar.TabIndex = 0;
            btnFinalizar.Text = "Finalizar Venda";
            btnFinalizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFinalizar.UseAccentColor = false;
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "iconmonstr-wrench-24-32.png");
            imageList1.Images.SetKeyName(1, "iconmonstr-banknote-12-32.png");
            imageList1.Images.SetKeyName(2, "iconmonstr-wrench-12-32.png");
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(950, 663);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weber Motos";
            WindowState = FormWindowState.Maximized;
            materialTabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            TabPage1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TabPage2.ResumeLayout(false);
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private ImageList imageList1;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnFinalizar;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
