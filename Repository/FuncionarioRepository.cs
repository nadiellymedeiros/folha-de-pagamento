using folha_pagamento.Model;

namespace folha_pagamento.Repository;

public class FuncionarioRepository
{
    private readonly string filepath = @"data/Departamento de Financeiro.csv";

    public List<Funcionario> FindAll()
    {
        List<Funcionario> funcionarios = new();       

        if(!File.Exists(filepath))
        return funcionarios;

        string[] lines = File.ReadAllLines(filepath);

        foreach (string line in lines.Skip(1))
        {
            funcionarios.Add(Funcionario.FromCsv(line));
        }

        return funcionarios;
    }
}