﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsEF.Models
{
    internal class Planet
    {
        [Required]
        public string Name { get; set; }
        public int RotationPeriod { get; set; }
        public string OrbitalPeriod { get; set; }
        public int Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public List<string> Terrain { get; set; }
        public float SurfaceWater { get; set; }
        public long Population { get; set; }
        public List<string> Residents { get; set; }
        public List<object> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
