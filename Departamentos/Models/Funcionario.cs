namespace Departamentos.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public decimal RG { get; set; }
        public Departamento Departamento { get; set; }
        

    }
}
