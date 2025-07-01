using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeberMotosWF.Models
{
    public class VendaItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }
        public int VendaId { get; set; }
        public int PecaId { get; set; }
        public int Quantidade { get; set; }
        public double PrecoPeca { get; set; }

        // Relacionamentos
        public virtual Venda Venda { get; set; }
        public virtual Peca Peca { get; set; }
    }

}
