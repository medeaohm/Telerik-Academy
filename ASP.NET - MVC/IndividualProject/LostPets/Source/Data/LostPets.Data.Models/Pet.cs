namespace LostPets.Data.Models
{
    using Common.Models;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public abstract class Pet : BaseModel<int>
    {
        [StringLength(100)]
        public string Name { get; set; }

        public int? Age { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Color { get; set; }
    }
}
