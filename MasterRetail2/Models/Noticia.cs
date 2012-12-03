using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
    }
}