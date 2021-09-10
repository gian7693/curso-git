using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public float Salario { get; private set; }

        public Funcionario(int id, string nome, float salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(float porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", R$"
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
