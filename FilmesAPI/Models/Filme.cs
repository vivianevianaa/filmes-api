using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; internal set; }
        [Required(ErrorMessage = "O campo título não pode estar em branco.")]
        public String Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor não pode estar em branco.")]
        public String Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero deve ter até 30 caracteres.")]
        public String Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve estar entre 1 e 600 minutos.")]
        public int Duracao { get; set; }
        
    }
}
