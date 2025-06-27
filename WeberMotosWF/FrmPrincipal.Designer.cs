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
            TabPage1 = new TabPage();
            TabPage2 = new TabPage();
            imageList1 = new ImageList(components);
            tabPage3 = new TabPage();
            materialTabControl1.SuspendLayout();
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
            materialTabControl1.Size = new Size(794, 383);
            materialTabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            TabPage1.ImageKey = "iconmonstr-wrench-24-32.png";
            TabPage1.Location = new Point(4, 39);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(786, 340);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Peças";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            TabPage2.Cursor = Cursors.Hand;
            TabPage2.ImageKey = "iconmonstr-banknote-12-32.png";
            TabPage2.Location = new Point(4, 39);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(786, 340);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Venda";
            TabPage2.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            tabPage3.ImageKey = "iconmonstr-wrench-12-32.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(786, 340);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Add Peça";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weber Motos";
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private ImageList imageList1;
        private TabPage tabPage3;
    }
}
