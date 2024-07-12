using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace iks_satınalım_service.Entities
{
	public class User
	{
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
		public int UserId { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(1000)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(1000)")]
        public string Lastname { get; set; }

	}

}

