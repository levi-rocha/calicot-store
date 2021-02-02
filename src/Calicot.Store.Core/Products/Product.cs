using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Calicot.Store.Products
{
    public class Product : Entity, IHasCreationTime
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB

        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }

        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public long Quantity { get; set; }
        public decimal Price { get; set; }

        public string ImgUrl { get; set; }

        public Product() 
        {
            CreationTime = Clock.Now;
            ImgUrl = "https://png.pngtree.com/png-vector/20190223/ourmid/pngtree-vector-camera-icon-png-image_696326.jpg";
        }

        public Product(string title, string description, decimal price)
        {
            Title = title;
            Description = description;
            Price = price;
            CreationTime = Clock.Now;
        }
    }
}
