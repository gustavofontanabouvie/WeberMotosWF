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
            cbxPecasUtilizadas.DataSource = ListarPecas();
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
            cbxPecasUtilizadas.DataSource = ListarPecas();
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

        private void btnAdicionaPeca_Click(object sender, EventArgs e)
        {
            dataGridViewPecasUtilizadas.DefaultCellStyle.ForeColor = Color.Black;


            using (var context = new OficinaDbContext())
            {
                var pecaSelecionada = context.pecas.First(pe => pe.Descricao.Equals(cbxPecasUtilizadas.Text));

                bool pecaJaAdicionado = false;

                foreach (DataGridViewRow row in dataGridViewPecasUtilizadas.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(pecaSelecionada.Descricao))
                    {
                        int quantidadeAtual = Convert.ToInt32(row.Cells[2].Value);
                        row.Cells[2].Value = quantidadeAtual + 1;

                        pecaJaAdicionado = true;
                        break;
                    }
                }
                if (!pecaJaAdicionado)
                {
                    dataGridViewPecasUtilizadas.Rows.Add(pecaSelecionada.Descricao, pecaSelecionada.PrecoVenda, 1);
                }
            }
        }
        private List<String> ListarPecas()
        {
            using (var context = new OficinaDbContext())
            {
                return context.pecas.ToList().Select(pe => pe.Descricao).ToList();

            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            VendaItem vendaItem = new VendaItem();

            if (double.TryParse(txtHorasTrabalhadas.Text, out double horaTrabalhada))
            {
                venda.HorasTrabalhadas = horaTrabalhada;
            }
            else
            {
                MessageBox.Show("A hora deve ser um numero");
                txtHorasTrabalhadas.Clear();
                return;
            }

            venda.Descricao = txtDescricaoVenda.Text;
            venda.DataManutencao = datePickerDataVenda.Value.ToUniversalTime();
            venda.PlacaMoto = txtPlacaMoto.Text;
            venda.ModeloMoto = txtModeloMoto.Text;
            venda.ClienteNome = txtCliente.Text;
            venda.FotoMoto = "Foto da moto";

            double valorTotalVenda = 0;

            foreach (DataGridViewRow row in dataGridViewPecasUtilizadas.Rows)
            {
                double preco = Convert.ToDouble(row.Cells[1].Value);
                double quantidade = Convert.ToDouble(row.Cells[2].Value);
                double totalItem = quantidade * preco;
                valorTotalVenda += totalItem;
            }

            valorTotalVenda += venda.HorasTrabalhadas * 50;

            venda.TotalVenda = valorTotalVenda;

            using (var context = new OficinaDbContext())
            {
                context.vendas.Add(venda);
                context.SaveChanges();
            }
            LimparCamposVenda();
        }

        private void LimparCamposVenda()
        {
            txtDescricaoVenda.Clear();
            txtHorasTrabalhadas.Clear();
            txtModeloMoto.Clear();
            txtPlacaMoto.Clear();
            txtCliente.Clear();

            dataGridViewPecasUtilizadas.Rows.Clear();
        }
    }

}
