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
            btnCadastrarPeca = new MaterialSkin.Controls.MaterialButton();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtQuantidadeInicial = new MaterialSkin.Controls.MaterialTextBox();
            txtPecaPrecoVenda = new MaterialSkin.Controls.MaterialTextBox();
            txtPecaPreco = new MaterialSkin.Controls.MaterialTextBox();
            txtPecaDescricao = new MaterialSkin.Controls.MaterialTextBox();
            TabPage1 = new TabPage();
            materialCardEditar = new MaterialSkin.Controls.MaterialCard();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            txtQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            txtPrecoVendaEdit = new MaterialSkin.Controls.MaterialTextBox();
            txtPrecoCompraEdit = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            txtDescricaoEdit = new MaterialSkin.Controls.MaterialTextBox();
            btnSalvar = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnExcluir = new MaterialSkin.Controls.MaterialButton();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            dataGridViewPecas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            TabPage2 = new TabPage();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            datePickerDataVenda = new DateTimePicker();
            btnAdicionarPeca = new MaterialSkin.Controls.MaterialButton();
            cbxPecasUtilizadas = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txtPlacaMoto = new MaterialSkin.Controls.MaterialTextBox();
            txtModeloMoto = new MaterialSkin.Controls.MaterialTextBox();
            txtCliente = new MaterialSkin.Controls.MaterialTextBox();
            txtHorasTrabalhadas = new MaterialSkin.Controls.MaterialTextBox();
            txtDescricaoVenda = new MaterialSkin.Controls.MaterialTextBox();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            dataGridViewPecasUtilizadas = new DataGridView();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            btnFinalizar = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            PecaId = new DataGridViewTextBoxColumn();
            materialTabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            TabPage1.SuspendLayout();
            materialCardEditar.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPecas).BeginInit();
            TabPage2.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPecasUtilizadas).BeginInit();
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
            tabPage3.Controls.Add(btnCadastrarPeca);
            tabPage3.Controls.Add(materialLabel16);
            tabPage3.Controls.Add(materialLabel14);
            tabPage3.Controls.Add(materialLabel2);
            tabPage3.Controls.Add(materialLabel1);
            tabPage3.Controls.Add(txtQuantidadeInicial);
            tabPage3.Controls.Add(txtPecaPrecoVenda);
            tabPage3.Controls.Add(txtPecaPreco);
            tabPage3.Controls.Add(txtPecaDescricao);
            tabPage3.ImageKey = "iconmonstr-wrench-12-32.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(936, 553);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cadastrar Peça";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPeca
            // 
            btnCadastrarPeca.Anchor = AnchorStyles.Top;
            btnCadastrarPeca.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrarPeca.Cursor = Cursors.Hand;
            btnCadastrarPeca.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrarPeca.Depth = 0;
            btnCadastrarPeca.Font = new Font("Microsoft YaHei", 8.25F);
            btnCadastrarPeca.HighEmphasis = true;
            btnCadastrarPeca.Icon = null;
            btnCadastrarPeca.Location = new Point(394, 460);
            btnCadastrarPeca.Margin = new Padding(4, 6, 4, 6);
            btnCadastrarPeca.MouseState = MaterialSkin.MouseState.HOVER;
            btnCadastrarPeca.Name = "btnCadastrarPeca";
            btnCadastrarPeca.NoAccentTextColor = Color.Empty;
            btnCadastrarPeca.RightToLeft = RightToLeft.No;
            btnCadastrarPeca.Size = new Size(106, 36);
            btnCadastrarPeca.TabIndex = 12;
            btnCadastrarPeca.Text = "Cadastrar";
            btnCadastrarPeca.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrarPeca.UseAccentColor = false;
            btnCadastrarPeca.UseVisualStyleBackColor = true;
            btnCadastrarPeca.Click += btnCadastrarPeca_Click;
            // 
            // materialLabel16
            // 
            materialLabel16.Anchor = AnchorStyles.Top;
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(148, 366);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.RightToLeft = RightToLeft.No;
            materialLabel16.Size = new Size(83, 19);
            materialLabel16.TabIndex = 10;
            materialLabel16.Text = "Quantidade";
            // 
            // materialLabel14
            // 
            materialLabel14.Anchor = AnchorStyles.Top;
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(148, 283);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.RightToLeft = RightToLeft.No;
            materialLabel14.Size = new Size(111, 19);
            materialLabel14.TabIndex = 10;
            materialLabel14.Text = "Preço de Venda";
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Top;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(148, 197);
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
            materialLabel1.Location = new Point(148, 115);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.RightToLeft = RightToLeft.No;
            materialLabel1.Size = new Size(103, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Nome da peça";
            // 
            // txtQuantidadeInicial
            // 
            txtQuantidadeInicial.Anchor = AnchorStyles.Top;
            txtQuantidadeInicial.AnimateReadOnly = false;
            txtQuantidadeInicial.BorderStyle = BorderStyle.None;
            txtQuantidadeInicial.Depth = 0;
            txtQuantidadeInicial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidadeInicial.Hint = "Ex: 20";
            txtQuantidadeInicial.LeadingIcon = null;
            txtQuantidadeInicial.Location = new Point(312, 350);
            txtQuantidadeInicial.MaxLength = 50;
            txtQuantidadeInicial.MouseState = MaterialSkin.MouseState.OUT;
            txtQuantidadeInicial.Multiline = false;
            txtQuantidadeInicial.Name = "txtQuantidadeInicial";
            txtQuantidadeInicial.RightToLeft = RightToLeft.No;
            txtQuantidadeInicial.Size = new Size(306, 50);
            txtQuantidadeInicial.TabIndex = 8;
            txtQuantidadeInicial.Text = "";
            txtQuantidadeInicial.TrailingIcon = null;
            // 
            // txtPecaPrecoVenda
            // 
            txtPecaPrecoVenda.Anchor = AnchorStyles.Top;
            txtPecaPrecoVenda.AnimateReadOnly = false;
            txtPecaPrecoVenda.BorderStyle = BorderStyle.None;
            txtPecaPrecoVenda.Depth = 0;
            txtPecaPrecoVenda.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPecaPrecoVenda.Hint = "Ex: 50,00";
            txtPecaPrecoVenda.LeadingIcon = null;
            txtPecaPrecoVenda.Location = new Point(312, 267);
            txtPecaPrecoVenda.MaxLength = 50;
            txtPecaPrecoVenda.MouseState = MaterialSkin.MouseState.OUT;
            txtPecaPrecoVenda.Multiline = false;
            txtPecaPrecoVenda.Name = "txtPecaPrecoVenda";
            txtPecaPrecoVenda.RightToLeft = RightToLeft.No;
            txtPecaPrecoVenda.Size = new Size(306, 50);
            txtPecaPrecoVenda.TabIndex = 8;
            txtPecaPrecoVenda.Text = "";
            txtPecaPrecoVenda.TrailingIcon = null;
            // 
            // txtPecaPreco
            // 
            txtPecaPreco.Anchor = AnchorStyles.Top;
            txtPecaPreco.AnimateReadOnly = false;
            txtPecaPreco.BorderStyle = BorderStyle.None;
            txtPecaPreco.Depth = 0;
            txtPecaPreco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPecaPreco.Hint = "Ex: 50,00";
            txtPecaPreco.LeadingIcon = null;
            txtPecaPreco.Location = new Point(312, 180);
            txtPecaPreco.MaxLength = 50;
            txtPecaPreco.MouseState = MaterialSkin.MouseState.OUT;
            txtPecaPreco.Multiline = false;
            txtPecaPreco.Name = "txtPecaPreco";
            txtPecaPreco.RightToLeft = RightToLeft.No;
            txtPecaPreco.Size = new Size(306, 50);
            txtPecaPreco.TabIndex = 8;
            txtPecaPreco.Text = "";
            txtPecaPreco.TrailingIcon = null;
            // 
            // txtPecaDescricao
            // 
            txtPecaDescricao.Anchor = AnchorStyles.Top;
            txtPecaDescricao.AnimateReadOnly = false;
            txtPecaDescricao.BorderStyle = BorderStyle.None;
            txtPecaDescricao.Depth = 0;
            txtPecaDescricao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPecaDescricao.Hint = "Ex: Pastilha de freio CG 160";
            txtPecaDescricao.LeadingIcon = null;
            txtPecaDescricao.Location = new Point(312, 95);
            txtPecaDescricao.MaxLength = 50;
            txtPecaDescricao.MouseState = MaterialSkin.MouseState.OUT;
            txtPecaDescricao.Multiline = false;
            txtPecaDescricao.Name = "txtPecaDescricao";
            txtPecaDescricao.RightToLeft = RightToLeft.No;
            txtPecaDescricao.Size = new Size(306, 50);
            txtPecaDescricao.TabIndex = 9;
            txtPecaDescricao.Text = "";
            txtPecaDescricao.TrailingIcon = null;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(materialCardEditar);
            TabPage1.Controls.Add(materialCard1);
            TabPage1.Controls.Add(dataGridViewPecas);
            TabPage1.ImageKey = "iconmonstr-wrench-24-32.png";
            TabPage1.Location = new Point(4, 39);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(936, 553);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Listar Peças";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCardEditar
            // 
            materialCardEditar.BackColor = Color.FromArgb(255, 255, 255);
            materialCardEditar.Controls.Add(materialLabel15);
            materialCardEditar.Controls.Add(txtQuantidade);
            materialCardEditar.Controls.Add(txtPrecoVendaEdit);
            materialCardEditar.Controls.Add(txtPrecoCompraEdit);
            materialCardEditar.Controls.Add(materialLabel13);
            materialCardEditar.Controls.Add(materialLabel11);
            materialCardEditar.Controls.Add(materialLabel12);
            materialCardEditar.Controls.Add(txtDescricaoEdit);
            materialCardEditar.Controls.Add(btnSalvar);
            materialCardEditar.Controls.Add(btnCancelar);
            materialCardEditar.Depth = 0;
            materialCardEditar.Dock = DockStyle.Bottom;
            materialCardEditar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardEditar.Location = new Point(3, 204);
            materialCardEditar.Margin = new Padding(14);
            materialCardEditar.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardEditar.Name = "materialCardEditar";
            materialCardEditar.Padding = new Padding(14);
            materialCardEditar.Size = new Size(930, 297);
            materialCardEditar.TabIndex = 2;
            materialCardEditar.Visible = false;
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(470, 35);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(83, 19);
            materialLabel15.TabIndex = 6;
            materialLabel15.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.BorderStyle = BorderStyle.None;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(594, 23);
            txtQuantidade.MaxLength = 50;
            txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            txtQuantidade.Multiline = false;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(295, 50);
            txtQuantidade.TabIndex = 5;
            txtQuantidade.Text = "";
            txtQuantidade.TrailingIcon = null;
            // 
            // txtPrecoVendaEdit
            // 
            txtPrecoVendaEdit.AnimateReadOnly = false;
            txtPrecoVendaEdit.BorderStyle = BorderStyle.None;
            txtPrecoVendaEdit.Depth = 0;
            txtPrecoVendaEdit.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecoVendaEdit.LeadingIcon = null;
            txtPrecoVendaEdit.Location = new Point(594, 87);
            txtPrecoVendaEdit.MaxLength = 50;
            txtPrecoVendaEdit.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecoVendaEdit.Multiline = false;
            txtPrecoVendaEdit.Name = "txtPrecoVendaEdit";
            txtPrecoVendaEdit.Size = new Size(295, 50);
            txtPrecoVendaEdit.TabIndex = 5;
            txtPrecoVendaEdit.Text = "";
            txtPrecoVendaEdit.TrailingIcon = null;
            // 
            // txtPrecoCompraEdit
            // 
            txtPrecoCompraEdit.AnimateReadOnly = false;
            txtPrecoCompraEdit.BorderStyle = BorderStyle.None;
            txtPrecoCompraEdit.Depth = 0;
            txtPrecoCompraEdit.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecoCompraEdit.LeadingIcon = null;
            txtPrecoCompraEdit.Location = new Point(152, 87);
            txtPrecoCompraEdit.MaxLength = 50;
            txtPrecoCompraEdit.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecoCompraEdit.Multiline = false;
            txtPrecoCompraEdit.Name = "txtPrecoCompraEdit";
            txtPrecoCompraEdit.Size = new Size(295, 50);
            txtPrecoCompraEdit.TabIndex = 4;
            txtPrecoCompraEdit.Text = "";
            txtPrecoCompraEdit.TrailingIcon = null;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(56, 25);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(71, 19);
            materialLabel13.TabIndex = 3;
            materialLabel13.Text = "Descrição";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(468, 104);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(109, 19);
            materialLabel11.TabIndex = 3;
            materialLabel11.Text = "Preço de venda";
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(21, 102);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(120, 19);
            materialLabel12.TabIndex = 3;
            materialLabel12.Text = "Preço de compra";
            // 
            // txtDescricaoEdit
            // 
            txtDescricaoEdit.AnimateReadOnly = false;
            txtDescricaoEdit.BorderStyle = BorderStyle.None;
            txtDescricaoEdit.Depth = 0;
            txtDescricaoEdit.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricaoEdit.LeadingIcon = null;
            txtDescricaoEdit.Location = new Point(152, 23);
            txtDescricaoEdit.MaxLength = 50;
            txtDescricaoEdit.MouseState = MaterialSkin.MouseState.OUT;
            txtDescricaoEdit.Multiline = false;
            txtDescricaoEdit.Name = "txtDescricaoEdit";
            txtDescricaoEdit.Size = new Size(295, 50);
            txtDescricaoEdit.TabIndex = 2;
            txtDescricaoEdit.Text = "";
            txtDescricaoEdit.TrailingIcon = null;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.Location = new Point(371, 241);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(455, 241);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            btnExcluir.Click += btnExcluir_Click;
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
            btnEditar.Click += btnEditar_Click;
            // 
            // dataGridViewPecas
            // 
            dataGridViewPecas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPecas.BackgroundColor = Color.SlateGray;
            dataGridViewPecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPecas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Quantidade });
            dataGridViewPecas.Dock = DockStyle.Top;
            dataGridViewPecas.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewPecas.Location = new Point(3, 3);
            dataGridViewPecas.Name = "dataGridViewPecas";
            dataGridViewPecas.Size = new Size(930, 547);
            dataGridViewPecas.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Codigo";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Descrição";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Preço de compra";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Preço de venda";
            Column4.Name = "Column4";
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
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
            materialCard5.Controls.Add(datePickerDataVenda);
            materialCard5.Controls.Add(btnAdicionarPeca);
            materialCard5.Controls.Add(cbxPecasUtilizadas);
            materialCard5.Controls.Add(materialLabel6);
            materialCard5.Controls.Add(materialLabel4);
            materialCard5.Controls.Add(materialLabel8);
            materialCard5.Controls.Add(materialLabel10);
            materialCard5.Controls.Add(materialLabel7);
            materialCard5.Controls.Add(materialLabel9);
            materialCard5.Controls.Add(materialLabel5);
            materialCard5.Controls.Add(materialLabel3);
            materialCard5.Controls.Add(txtPlacaMoto);
            materialCard5.Controls.Add(txtModeloMoto);
            materialCard5.Controls.Add(txtCliente);
            materialCard5.Controls.Add(txtHorasTrabalhadas);
            materialCard5.Controls.Add(txtDescricaoVenda);
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
            // datePickerDataVenda
            // 
            datePickerDataVenda.Anchor = AnchorStyles.Top;
            datePickerDataVenda.Location = new Point(192, 102);
            datePickerDataVenda.Name = "datePickerDataVenda";
            datePickerDataVenda.Size = new Size(264, 23);
            datePickerDataVenda.TabIndex = 4;
            // 
            // btnAdicionarPeca
            // 
            btnAdicionarPeca.Anchor = AnchorStyles.Top;
            btnAdicionarPeca.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionarPeca.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionarPeca.Depth = 0;
            btnAdicionarPeca.HighEmphasis = true;
            btnAdicionarPeca.Icon = null;
            btnAdicionarPeca.Location = new Point(489, 272);
            btnAdicionarPeca.Margin = new Padding(4, 6, 4, 6);
            btnAdicionarPeca.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdicionarPeca.Name = "btnAdicionarPeca";
            btnAdicionarPeca.NoAccentTextColor = Color.Empty;
            btnAdicionarPeca.Size = new Size(64, 36);
            btnAdicionarPeca.TabIndex = 3;
            btnAdicionarPeca.Text = "+";
            btnAdicionarPeca.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionarPeca.UseAccentColor = false;
            btnAdicionarPeca.UseVisualStyleBackColor = true;
            btnAdicionarPeca.Click += btnAdicionaPeca_Click;
            // 
            // cbxPecasUtilizadas
            // 
            cbxPecasUtilizadas.Anchor = AnchorStyles.Top;
            cbxPecasUtilizadas.AutoResize = false;
            cbxPecasUtilizadas.BackColor = Color.FromArgb(255, 255, 255);
            cbxPecasUtilizadas.Depth = 0;
            cbxPecasUtilizadas.DrawMode = DrawMode.OwnerDrawVariable;
            cbxPecasUtilizadas.DropDownHeight = 174;
            cbxPecasUtilizadas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPecasUtilizadas.DropDownWidth = 121;
            cbxPecasUtilizadas.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxPecasUtilizadas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxPecasUtilizadas.FormattingEnabled = true;
            cbxPecasUtilizadas.IntegralHeight = false;
            cbxPecasUtilizadas.ItemHeight = 43;
            cbxPecasUtilizadas.Location = new Point(192, 262);
            cbxPecasUtilizadas.MaxDropDownItems = 4;
            cbxPecasUtilizadas.MouseState = MaterialSkin.MouseState.OUT;
            cbxPecasUtilizadas.Name = "cbxPecasUtilizadas";
            cbxPecasUtilizadas.Size = new Size(264, 49);
            cbxPecasUtilizadas.StartIndex = 0;
            cbxPecasUtilizadas.TabIndex = 2;
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
            // txtPlacaMoto
            // 
            txtPlacaMoto.Anchor = AnchorStyles.Top;
            txtPlacaMoto.AnimateReadOnly = false;
            txtPlacaMoto.BorderStyle = BorderStyle.None;
            txtPlacaMoto.Depth = 0;
            txtPlacaMoto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlacaMoto.LeadingIcon = null;
            txtPlacaMoto.Location = new Point(661, 84);
            txtPlacaMoto.MaxLength = 50;
            txtPlacaMoto.MouseState = MaterialSkin.MouseState.OUT;
            txtPlacaMoto.Multiline = false;
            txtPlacaMoto.Name = "txtPlacaMoto";
            txtPlacaMoto.Size = new Size(264, 50);
            txtPlacaMoto.TabIndex = 0;
            txtPlacaMoto.Text = "";
            txtPlacaMoto.TrailingIcon = null;
            // 
            // txtModeloMoto
            // 
            txtModeloMoto.Anchor = AnchorStyles.Top;
            txtModeloMoto.AnimateReadOnly = false;
            txtModeloMoto.BorderStyle = BorderStyle.None;
            txtModeloMoto.Depth = 0;
            txtModeloMoto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModeloMoto.LeadingIcon = null;
            txtModeloMoto.Location = new Point(661, 151);
            txtModeloMoto.MaxLength = 50;
            txtModeloMoto.MouseState = MaterialSkin.MouseState.OUT;
            txtModeloMoto.Multiline = false;
            txtModeloMoto.Name = "txtModeloMoto";
            txtModeloMoto.Size = new Size(264, 50);
            txtModeloMoto.TabIndex = 0;
            txtModeloMoto.Text = "";
            txtModeloMoto.TrailingIcon = null;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.Top;
            txtCliente.AnimateReadOnly = false;
            txtCliente.BorderStyle = BorderStyle.None;
            txtCliente.Depth = 0;
            txtCliente.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCliente.LeadingIcon = null;
            txtCliente.Location = new Point(192, 206);
            txtCliente.MaxLength = 50;
            txtCliente.MouseState = MaterialSkin.MouseState.OUT;
            txtCliente.Multiline = false;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(264, 50);
            txtCliente.TabIndex = 0;
            txtCliente.Text = "";
            txtCliente.TrailingIcon = null;
            // 
            // txtHorasTrabalhadas
            // 
            txtHorasTrabalhadas.Anchor = AnchorStyles.Top;
            txtHorasTrabalhadas.AnimateReadOnly = false;
            txtHorasTrabalhadas.BorderStyle = BorderStyle.None;
            txtHorasTrabalhadas.Depth = 0;
            txtHorasTrabalhadas.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHorasTrabalhadas.LeadingIcon = null;
            txtHorasTrabalhadas.Location = new Point(192, 151);
            txtHorasTrabalhadas.MaxLength = 50;
            txtHorasTrabalhadas.MouseState = MaterialSkin.MouseState.OUT;
            txtHorasTrabalhadas.Multiline = false;
            txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            txtHorasTrabalhadas.Size = new Size(264, 50);
            txtHorasTrabalhadas.TabIndex = 0;
            txtHorasTrabalhadas.Text = "";
            txtHorasTrabalhadas.TrailingIcon = null;
            // 
            // txtDescricaoVenda
            // 
            txtDescricaoVenda.Anchor = AnchorStyles.Top;
            txtDescricaoVenda.AnimateReadOnly = false;
            txtDescricaoVenda.BorderStyle = BorderStyle.None;
            txtDescricaoVenda.Depth = 0;
            txtDescricaoVenda.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricaoVenda.LeadingIcon = null;
            txtDescricaoVenda.Location = new Point(192, 19);
            txtDescricaoVenda.MaxLength = 50;
            txtDescricaoVenda.MouseState = MaterialSkin.MouseState.OUT;
            txtDescricaoVenda.Multiline = false;
            txtDescricaoVenda.Name = "txtDescricaoVenda";
            txtDescricaoVenda.Size = new Size(733, 50);
            txtDescricaoVenda.TabIndex = 0;
            txtDescricaoVenda.Text = "";
            txtDescricaoVenda.TrailingIcon = null;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(dataGridViewPecasUtilizadas);
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
            // dataGridViewPecasUtilizadas
            // 
            dataGridViewPecasUtilizadas.Anchor = AnchorStyles.Top;
            dataGridViewPecasUtilizadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPecasUtilizadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPecasUtilizadas.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, PecaId });
            dataGridViewPecasUtilizadas.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewPecasUtilizadas.Location = new Point(14, 14);
            dataGridViewPecasUtilizadas.Name = "dataGridViewPecasUtilizadas";
            dataGridViewPecasUtilizadas.Size = new Size(902, 104);
            dataGridViewPecasUtilizadas.TabIndex = 0;
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
            btnFinalizar.Click += btnFinalizar_Click;
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
            // Column5
            // 
            Column5.HeaderText = "Peça";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Valor";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Quantidade";
            Column7.Name = "Column7";
            // 
            // PecaId
            // 
            PecaId.HeaderText = "Peça Id";
            PecaId.Name = "PecaId";
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
            materialCardEditar.ResumeLayout(false);
            materialCardEditar.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPecas).EndInit();
            TabPage2.ResumeLayout(false);
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPecasUtilizadas).EndInit();
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
        private DataGridView dataGridViewPecas;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnFinalizar;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private DataGridView dataGridViewPecasUtilizadas;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtDescricaoVenda;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtHorasTrabalhadas;
        private MaterialSkin.Controls.MaterialButton btnAdicionarPeca;
        private MaterialSkin.Controls.MaterialComboBox cbxPecasUtilizadas;
        private DateTimePicker datePickerDataVenda;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtPlacaMoto;
        private MaterialSkin.Controls.MaterialTextBox txtModeloMoto;
        private MaterialSkin.Controls.MaterialTextBox txtCliente;
        private MaterialSkin.Controls.MaterialButton btnCadastrarPeca;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtPecaPreco;
        private MaterialSkin.Controls.MaterialTextBox txtPecaDescricao;
        private MaterialSkin.Controls.MaterialCard materialCardEditar;
        private MaterialSkin.Controls.MaterialButton btnSalvar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox txtDescricaoEdit;
        private MaterialSkin.Controls.MaterialTextBox txtPrecoVendaEdit;
        private MaterialSkin.Controls.MaterialTextBox txtPrecoCompraEdit;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialTextBox txtPecaPrecoVenda;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidadeInicial;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn PecaId;
    }
}
