using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WeberMotosWF.DataBase;
using WeberMotosWF.Models;

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
            CarregarPecasDatagrid();
        }

        private void btnCadastrarPeca_Click(object sender, EventArgs e)
        {
            Peca novaPeca = new Peca();

            novaPeca.Descricao = txtPecaDescricao.Text;

            if (double.TryParse(txtPecaPreco.Text, out double precoCompra))
            {
                novaPeca.UltimoPrecoCompra = precoCompra;
            }
            else
            {
                MessageBox.Show("O preço deve ser um numero");
                txtPecaPreco.Clear();
                return;
            }

            if (double.TryParse(txtPecaPrecoVenda.Text, out double precoVenda))
            {
                novaPeca.PrecoVenda = precoVenda;
            }
            else
            {
                MessageBox.Show("O preço deve ser um numero");
                txtPecaPreco.Clear();
                return;
            }

            using (var context = new OficinaDbContext())
            {
                context.Add(novaPeca);
                context.SaveChanges();
            }
            LimparCamposCadastroPeca();
            CarregarPecasDatagrid();
        }

        private void LimparCamposCadastroPeca()
        {
            txtPecaDescricao.Clear();
            txtPecaPreco.Clear();
            txtPecaPrecoVenda.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            materialCardEditar.Visible = true;
            PreencherCamposEdicaoPeca();
        }

        public void CarregarPecasDatagrid()
        {
            dataGridViewPecas.Rows.Clear();
            dataGridViewPecas.DefaultCellStyle.ForeColor = Color.Black;

            using (var context = new OficinaDbContext())
            {
                foreach (var peca in context.pecas)
                {
                    dataGridViewPecas.Rows.Add(peca.Id, peca.Descricao, peca.UltimoPrecoCompra, peca.PrecoVenda);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewPecas.CurrentCell.RowIndex;
            int idPeca = Convert.ToInt32(dataGridViewPecas.Rows[rowIndex].Cells[0].Value);

            using (var context = new OficinaDbContext())
            {
                var peca = context.pecas.FirstOrDefault(pe => pe.Id == idPeca);
                context.pecas.Remove(peca!);
                context.SaveChanges();
            }
            CarregarPecasDatagrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            materialCardEditar.Visible = false;
        }
        public void PreencherCamposEdicaoPeca()
        {
            txtDescricaoEdit.Text = dataGridViewPecas.CurrentRow.Cells[1].Value.ToString();
            txtPrecoCompraEdit.Text = dataGridViewPecas.CurrentRow.Cells[2].Value.ToString();
            txtPrecoVendaEdit.Text = dataGridViewPecas.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewPecas.CurrentCell.RowIndex;
            int idPeca = Convert.ToInt32(dataGridViewPecas.Rows[rowIndex].Cells[0].Value);

            if (!double.TryParse(txtPrecoCompraEdit.Text, out double precoCompraEdit))
            {
                MessageBox.Show("O preço deve ser um numero");
                txtPecaPreco.Clear();
                return;
            }

            if (!double.TryParse(txtPrecoVendaEdit.Text, out double precoVendaEdit))
            {
                MessageBox.Show("O preço deve ser um numero");
                txtPecaPreco.Clear();
                return;
            }

            using (var context = new OficinaDbContext())
            {
                var peca = context.pecas.First(pe => pe.Id == idPeca);
                peca.Descricao = txtDescricaoEdit.Text;
                peca.UltimoPrecoCompra = precoCompraEdit;
                peca.PrecoVenda = precoVendaEdit;

                context.SaveChanges();
            }

            CarregarPecasDatagrid();
            materialCardEditar.Visible = false;
        }
    }
}
