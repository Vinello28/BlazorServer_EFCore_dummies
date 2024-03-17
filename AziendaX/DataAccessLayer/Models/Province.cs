using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

[Table("Province")]
public partial class Province
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string Sigla { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;
}
