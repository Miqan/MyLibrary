﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLibrary.Models
{
    public class BaseEntity
    {
        public string Id { get; set; }
        [Display (Name="Oluşturulma Tarihi")]
        public DateTime CreateDate { get; set; }
        [Display (Name ="Oluşturan Kullanıcı")]
        public string CreatedBy { get; set; }
        [Display (Name ="Güncelleme Tarihi")]
        public DateTime UpdateDate { get; set; }
        [Display (Name ="Güncelleyen Kullanıcı")]
        public string UpdatedBy { get; set; }

    }
}
