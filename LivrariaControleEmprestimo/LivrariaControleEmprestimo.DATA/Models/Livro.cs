﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LivrariaControleEmprestimo.DATA.Models
{
    public partial class Livro
    {
        public Livro()
        {
            LivroClienteEmprestimo = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("nome")]
        [StringLength(50)]
        [Unicode(false)]
        public string Nome { get; set; }
        [Required]
        [Column("autor")]
        [StringLength(50)]
        [Unicode(false)]
        public string Autor { get; set; }
        [Required]
        [Column("editora")]
        [StringLength(50)]
        [Unicode(false)]
        public string Editora { get; set; }

        [InverseProperty("IdLivroNavigation")]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
    }
}