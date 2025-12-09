using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.service.factura.infrastructure.ClasesTemp;

[Table("productos", Schema = "poo")]
public partial class Producto
{
    [Key]
    [Column("producto_id")]
    public int ProductoId { get; set; }

    [Column("nombre")]
    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [Column("precio")]
    [Precision(10, 2)]
    public decimal Precio { get; set; }

    [Column("estado")]
    public bool? Estado { get; set; }

    [Column("fecha_insert", TypeName = "timestamp without time zone")]
    public DateTime? FechaInsert { get; set; }

    [Column("fecha_update", TypeName = "timestamp without time zone")]
    public DateTime? FechaUpdate { get; set; }

    [InverseProperty("Producto")]
    public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();
}
