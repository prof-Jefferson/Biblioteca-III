using System;

namespace Biblioteca_III.Classe;

public abstract class Pessoa : IPessoa
{
	public string Nome { get; private set; }
	public DateTime DataNascimento { get; private set; }
	
	public Pessoa (string nome, DateTime dataNascimento)	
	{
		if (string.IsNullOrEmpty (nome))
			throw new ArgumentNullException ("O nome não pode ser nulo",
			nameof(nome));
			
		Nome = nome;
		DataNascimento = dataNascimento;	
	}
	
	public virtual void ExibirInformacoes()
	{
		Console.WriteLine ("Base Exibiu");
	}
}