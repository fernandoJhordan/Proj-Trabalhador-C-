using ProjetoTrabalhador.Entities.Enums;
using System.Collections.Generic; // adicionando a biblioteca de lista

namespace ProjetoTrabalhador.Entities
{
    class Worker //Worker = Trabalhador
    {
        //Atributos da classe Worker
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //Atributos das classes que fazem parte da classe worker
        public Department Department { get; set; } //propriedade do tipo Departamento que é outra classe
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//propriedade do tipo lista pq a classe HourContract recebe vário contratos

        //construtor padrão
        public Worker() { }

        //não incluso a classe contracts pq ela é uma referencia para muitos ou seja vai adicionando os contratos aos poucos na lista
        public Worker(string name, WorkerLevel level, double baseSalary, Department department) 
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Método para adicionar um contrato para o trabalhador
        public void AddContract(HourContract contract) 
        {
            Contracts.Add(contract); //chamando a pro Contracts e add na lista o contrato que chegou como argumento 
  
        }
        //Método para remover um contrato do trabalhador
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);//chamando a pro Contracts e removendo na lista o contrato que chegou como argumento 
        }

        public double Income(int year, int month) 
        {
            double sum = BaseSalary; //declarando o salario base pois é um ganho fixo no mês

            //percorres a lista de contrato para pegar o valor do contrato do mês e ano informado no argumento
            //para cada Contrato (HourContract) e apelidando esse contrato de (contract) in na lista de (Contracts)
            foreach (HourContract contract in Contracts) 
            {   
                //se o contract que achou , a data.Dia for igual ao dia informado && o mês for igual ao mês informado
                if (contract.Date.Year == year && contract.Date.Month == month) 
                {
                    sum += contract.TotalValue(); //soma recebe ela mesma + o método que retorna o valor do contrato
                }
            }

            return sum;

        }


    }
}
