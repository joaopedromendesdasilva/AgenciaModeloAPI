using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agencia.Model 
{


[Table("Destinos")]
public class Destino
{
    [Key]
    [Column("id")]
    public int DestinoId { get; set; }

    [Required]
    [Column("nome")]
    public string Nome { get; set; } = string.Empty;

    [MaxLength]
    [Column("descricao")]
    public string Descricao { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    [Column("DestinoURL")]
    public string DestinoURL { get; set; } = string.Empty;

    [Required]
    [Column("preco")]
    public decimal Preco { get; set; }

}






}