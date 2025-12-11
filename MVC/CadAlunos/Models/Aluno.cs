
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CadAlunos.Models;

[Table("aluno")]
public partial class Aluno
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    public int Idade { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string Cpf { get; set; } = null!;
}
