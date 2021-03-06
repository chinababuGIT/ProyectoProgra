﻿using System.Collections.Generic;
using Domain.Entities;

namespace Clasificados.Models
{
    public class AdvanzedSearchModel
    {
        public string Search { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public List<Classified> Clasificados { get; set; }
    }
}