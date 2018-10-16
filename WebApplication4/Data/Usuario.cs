using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Data
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required(ErrorMessage= "Nome é Obrigatorio")]
        [MaxLength(30, ErrorMessage = "Nome pode conter no maximo 30 caracteres")]
        public string Nome { get; set; }
        public string Senha { get; set; }
        [Required(ErrorMessage = "Email é Obrigatorio")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email deve estar em formato Regular")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
        [Required(ErrorMessage = "CEP é Obrigatorio")]
        [RegularExpression(@"\d{5}-d{3}", ErrorMessage = "Cep deve estar no formato 0000-000")]
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

    }
}
