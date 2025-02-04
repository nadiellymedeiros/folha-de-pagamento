namespace folha_pagamento.Model;

public class DiasUteis
    {
        
        static List<string> meses = new List<string>()
        {
            "null",
            "Janeiro",
            "Fevereiro",
            "Marco",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"
        };

        public static int DiasUteisNoMes(int ano, string mes)
        {
            int indexMes = meses.FindIndex(m => m.Equals(mes));
            int diasTotais = DateTime.DaysInMonth(ano, indexMes);
            int diasUteis = 0;

            Parallel.For (1, diasTotais+1, (dia, state) =>
            {
                DateTime dataAtual = new DateTime(ano, indexMes, dia);
                if (dataAtual.DayOfWeek != DayOfWeek.Saturday && dataAtual.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasUteis++;
                }
            });

            return diasUteis;
        }
    }