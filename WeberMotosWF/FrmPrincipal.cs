using MaterialSkin;
using MaterialSkin.Controls;

namespace WeberMotosWF
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey800, Primary.BlueGrey500, Accent.Amber100, TextShade.WHITE);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
