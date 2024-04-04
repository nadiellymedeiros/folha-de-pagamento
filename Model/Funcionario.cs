namespace folha_pagamento.Model;

public class Funcionario
{
    public int Codigo { get; set; }

    public string Nome { get; set; }

    public double ValorHora {get; set;}

    public DateOnly Data {get; set;}

    public DateTime HoraEntrada {get; set;}

    public DateTime HoraSaida {get; set;}

    public string HoraAlmoco {get; set;}

    // public decimal ValorAReceber { get; set; } = 0;

    // public double HorasExtras { get; set; } = 0;

    // public  double HorasDebito { get; set; } = 0;

    // public  int Faltas { get; set; } = 0;

    // public int DiasTrabalhados { get; set; } = 0;

    public Funcionario(){
    }


    public  static Funcionario FromCsv(string csvLine)
    {
        string[] funcionarioData = csvLine.Split(';');

        return new Funcionario(){
        Codigo = int.Parse(funcionarioData[0]),
        Nome = funcionarioData[1],
        ValorHora = double.Parse(funcionarioData[2].Replace("R$ ", "").Replace(",", ".")),
        Data = DateOnly.Parse(funcionarioData[3]),
        HoraEntrada= DateTime.Parse(funcionarioData[4]),
        HoraSaida = DateTime.Parse(funcionarioData[5]),
        HoraAlmoco = funcionarioData[6]

        };   
    }

    public override string ToString()
    {
        return $"Codigo: {Codigo}, Nome: {Nome}, Valor da hora: R${ValorHora}, Data: {Data}, Hora Entrada: {HoraEntrada}, HoraSaida: {HoraSaida}, Almoço: {HoraAlmoco}";
    }


    // public void CalculoValorAReceber(decimal valor)
    // {
    //     ValorAReceber += Math.Round(valor,2);
    // }

    // public void CalculoHorasExtras (double horasExtras)
    // {
    //     HorasExtras += horasExtras;
    // }

    //  public void CalculoHorasDebito (double horasDebito)
    // {
    //     HorasDebito += horasDebito;
    // }

    // public void CalculoFaltas (int diasFalta)
    // {
    //     Faltas += diasFalta;
    // }

    // public void CalculoDiasTrabalhados (int diasExtras)
    // {
    //     DiasTrabalhados ++;
    // }

}


