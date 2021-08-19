using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength =3, ErrorMessage = "O titúlo do jogo deve conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome da produtora deve conter entre 1 e 100 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage = "O valor do jogo deve ter entre 0 e 1000 reais")]
        public double Preco { get; set; }
    }
}
