using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDComSqlServer.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [DisplayName("Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [DisplayName("Nome")]
        public string Nome { get; set; }
    }
}
