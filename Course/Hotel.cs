using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Hotel
    {
        public string    Nome;
        public string    Email;
        protected int       Quarto;

        public Hotel(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto + ": "
                + Nome
                + ", "
                + Email;
        }
    }
}
