using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Produto
    {
        private string   _nome;
        public double _preco { get; private set; }
        public int _quantidade { get; private set; }

        public Produto()
        {
            _quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        public Produto(string Nome, double Preco) : this()
        {
            this._nome = Nome;
            this._preco = Preco;
        }

        public double ValorTotalEmEstoque
        {
            get { return _preco * _quantidade; }
        }

        public void AdicionarProdutos(int qtdProduto)
        {
            _quantidade += qtdProduto;
        }

        public void RemoverProdutos(int qtdProduto)
        {
            _quantidade -= qtdProduto;
        }

        public override string ToString()
        {
            return _nome
                + " $ "
                + _preco.ToString("F2")
                + ", "
                + _quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque.ToString("F2");
        }

        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
    }
}
