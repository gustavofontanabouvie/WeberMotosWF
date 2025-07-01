using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeberMotosWF.Models
{
        public class Venda
        {

            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string Descricao { get; set; }
            public DateTime DataManutencao { get; set; }
            public double HorasTrabalhadas { get; set; }
            public string FotoMoto { get; set; }
            public string ModeloMoto { get; set; }
            public string PlacaMoto { get; set; }
            public string ClienteNome { get; set; }
            public double TotalVenda { get; set; }

            // Relacionamento com VendaItem
            public virtual List<VendaItem> Itens { get; set; } = new List<VendaItem>();
        }

    }

