//Classe base para Aluno herdar de Pessoa.
public class Pessoa
{
    protected string nome;
    protected int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }
}

//Aluno
public class Aluno : Pessoa
{
    private int matriculaAluno;

    public Aluno(int matriculaAluno, string nome, int idade)
        : base(nome, idade)
    {
        this.matriculaAluno = matriculaAluno;
    }

    public int GetMatriculaAluno()
    {
        return matriculaAluno;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
}

//Disciplina
public class Disciplina
{
    private int codigoDisciplina;
    private string nome;
    private double notaMinima;

    public Disciplina(int codigoDisciplina, string nome, double notaMinima)
    {
        this.codigoDisciplina = codigoDisciplina;
        this.nome = nome;
        this.notaMinima = notaMinima;
    }

    public int GetCodigoDisciplina()
    {
        return codigoDisciplina;
    }

    public string GetNome()
    {
        return nome;
    }

    public double GetNotaMinima()
    {
        return notaMinima;
    }
}

//Matricula
public class Matricula
{
    private int matriculaAluno;
    private int codigoDisciplina;
    private double nota1;
    private double nota2;

    public Matricula(int matriculaAluno, int codigoDisciplina, double nota1, double nota2)
    {
        this.matriculaAluno = matriculaAluno;
        this.codigoDisciplina = codigoDisciplina;
        this.nota1 = nota1;
        this.nota2 = nota2;
    }

    public double CalcularMedia()
    {
        return (nota1 + nota2) / 2;
    }

    public int GetMatriculaAluno()
    {
        return matriculaAluno;
    }

    public int GetCodigoDisciplina()
    {
        return codigoDisciplina;
    }
}

//Programa principal (mínimo para rodar)/ Auxílio de I.A
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno(1, "Maria", 19);
        Disciplina disciplina = new Disciplina(101, "Matemática", 6.0);
        Matricula matricula = new Matricula(
            aluno.GetMatriculaAluno(),
            disciplina.GetCodigoDisciplina(),
            7.0,
            8.0
        );

        Console.WriteLine("Aluno: " + aluno.GetNome());
        Console.WriteLine("Média: " + matricula.CalcularMedia());
    }
}