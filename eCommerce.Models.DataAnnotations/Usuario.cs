using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace eCommerce.Models
{
    /*
    Schema:
    [Table] = Nome da tabela
    [Column] = Nome da coluna
    [NotMapped] = Não mapear uma propriedade
    [ForeignKey] = Definir que a propriedade é o vinculo da chave estrangeira
    [InverseProperty] = Define a referência para cada FK vinda da mesma tabela.
    [DatabaseGenerated] = Definir se uma propriedade vai ou não ser gerenciada pelo banco.

    DataAnotations:
    [Key]  = Definir que a propriedade é uma PK

    [Indes] = Definir/Criar Indice no banco

     */

    [Table("TB_USUARIOS")]
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Sexo { get; set; }

        [Column("REGISTRO_GERAL")]
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        public string? SituacaoCadastro { get; set; }

        [NotMapped]
        public bool RegistroAtivo { get; set; }
        public DateTimeOffset DataCadastro { get; set; }
        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public ICollection<Departamento>? Departamentos { get; set;}
    }
}
