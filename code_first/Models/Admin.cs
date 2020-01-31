using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace code_first.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AdminId { get; set; }
        public string AdminCode { get; set; }
        public string AdminUsername { get; set; }
        public string AdminEmail { get; set; }
        public DateTime Timestamp { get; set; }
    }
}