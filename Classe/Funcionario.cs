using Biblioteca_III.Classe;

public class Funcionario : Pessoa
{
	// Atributos
	private int Id { get; set; }
	private string? Cargo { get; set; }
	private DateTime DataAdmissao { get; set; }
	
	// Construtor objeto funcionario
	public Funcionario(int id, string cargo, DateTime dataAdmissao, string nome, DateTime dataNascimento)
	 : base (nome, dataNascimento)
	{
		if (string.IsNullOrEmpty (cargo))
			throw new ArgumentNullException ("O cargo não pode ser nulo",
			nameof(cargo));
		
		if (dataAdmissao < DateTime.Now)
			throw new ArgumentNullException ("O cargo não pode ser nulo",
			nameof(dataAdmissao));
			
		Id = id;	
		Cargo = cargo;
		DataAdmissao = dataAdmissao; 
	}

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Data de Admissão: {DataAdmissao}");	
    }
}