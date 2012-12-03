using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Video
    {
        public int VideoId { get; set; }
        public System.Guid Guid { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Url { get; set; }
        public string Imagem { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
    }
}