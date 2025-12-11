using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Keyless]
public partial class VwUsuarioPublicacoess
{
    [Column("nome_usuario")]
    [StringLength(50)]
    public string NomeUsuario { get; set; } = null!;

    [Column("descricao")]
    [StringLength(300)]
    public string? Descricao { get; set; }

    [Column("imagem_url")]
    [StringLength(200)]
    public string? ImagemUrl { get; set; }

    [Column("data_publicacao")]
    public DateOnly DataPublicacao { get; set; }
}
