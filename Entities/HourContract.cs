using System;

namespace ProjetoTrabalhador.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; } //Data
        public double ValuePerHour { get; set; } //Valor por hora
        public int Hours { get; set; } //Duração desse contrato em horas

        public HourContract() { } //Construtor Padrão

        public HourContract(DateTime date, double valuePerHour, int houers) //Construtor com argumentos
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = houers;
        }

        public double TotalValue() //Método que retorna o valor total do contrato
        {
            return Hours * ValuePerHour;
        }
    }
}
