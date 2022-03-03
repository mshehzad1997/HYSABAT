﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models.ViewModel
{
    public class DashBoardFeatures
    {
        [Key]
        public int Id { get; set; }
      
        public string Title { get; set; }
       
        public string Description { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string ImageURL { get; set; }
        public DashBoardType dashBoardType { get; set; }
            public enum DashBoardType
            {
                KPI,
                BI,
                Fleet
            }
       
    }
}
