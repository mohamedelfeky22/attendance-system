﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Attendance_System.Models
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CauseOfAbsence { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? PermissionDate { get; set; }
        public bool IsApproved { get; set; }
        [ForeignKey("AdminUser")]
        [Column(Order =2)]
        public string Admin { get; set; }
        public DateTime? SendingDate { get; set; }
        public DateTime? ApprovementDate { get; set; }
        [ForeignKey("ApplicationUser")]
        [Column(Order =1)]
        public string UserId { get; set; }
      
        public ApplicationUser ApplicationUser { get; set; }
        public ApplicationUser AdminUser { get; set; }
    }
}