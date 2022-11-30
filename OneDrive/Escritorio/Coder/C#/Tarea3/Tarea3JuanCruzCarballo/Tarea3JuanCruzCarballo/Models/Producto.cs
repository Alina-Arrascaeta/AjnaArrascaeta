﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3JuanCruzCarballo.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }

        public decimal Costo { get; set; }

        public decimal PrecioVenta { get; set; }

        public int Stock { get; set; }

        public int IdUsuario { get; set; }
    }
}
