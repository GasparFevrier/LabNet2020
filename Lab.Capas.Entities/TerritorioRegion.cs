namespace Lab.Capas.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public class TerritorioRegion
    {
        public string TerritoryDescription { get; set; }
        public string RegionDescription { get; set; }
        
    }
}
