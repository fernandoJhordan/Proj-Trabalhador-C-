namespace ProjetoTrabalhador.Entities
{
    class Department
    {   
        //Atributo
        public string Name { get; set; }


        //Construtor Padrão
        public Department() {}

        //Construtor com o Atributo
        public Department(string name)
        {
            Name = name;
        }
    }
}
