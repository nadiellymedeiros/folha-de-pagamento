using folha_pagamento.Repository;

FuncionarioRepository funcionarioRepository = new();


funcionarioRepository
.FindAll()
.ForEach(funcionario => Console.WriteLine(funcionario));
