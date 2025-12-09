using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.service.factura.infrastructure.ClasesTemp;

[Table("clientes", Schema = "poo")]
public partial class Cliente
{
    [Key]
    [Column("cliente_id")]
    public int ClienteId { get; set; }

    [Column("nombre")]
    [StringLength(150)]
    public string Nombre { get; set; } = null!;

    [Column("direccion")]
    [StringLength(200)]
    public string? Direccion { get; set; }

    [Column("telefono")]
    [StringLength(20)]
    public string? Telefono { get; set; }

    [Column("estado")]
    public bool? Estado { get; set; }

    [Column("fecha_insert", TypeName = "timestamp without time zone")]
    public DateTime? FechaInsert { get; set; }

    [Column("fecha_update", TypeName = "timestamp without time zone")]
    public DateTime? FechaUpdate { get; set; }

    [InverseProperty("Cliente")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
