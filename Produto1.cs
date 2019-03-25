using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Modificadores_de_acesso_mais_completo.App_Start
{
    public class Produto1
    {
        private string _nome; // POR CONVENÇÃO USO O ANDELINE COM NOME EM MINUSCULO QUANDO PRIVADO
        private double _preco;
        private int _quantidade;

        public string Nome // POSSO COLOCAR CONDIÇÕES PARA ACESSAR E GRAVAR OS DADOS DE FORMA CUSTOMIZADA COM A MINHA LOGICA
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }


        public int Quantidade
        {
            get { return _quantidade; }
        }

        // ABAIXO POSSO COLOCAR OS ITENS E DIRETAMENTE COLOCAR SE QUERO QUE EXECUTEM ALGO, OU NÃO.
        // ATALHO PROP + TAB + TAB
        //private string _nome;
        //public double Preco { get; private set; }
        //public double Quantidade { get; set; }
        //public Produto()
        //{
        //}
        //public Produto(string nome, double preco, int quantidade)
        //{
        //    _nome = nome;
        //    Preco = preco;
        //    Quantidade = quantidade;
        //}
        //public string Nome
        //{
        //    get { return _nome; }
        //    set
        //    {
        //        if (value != null && value.Length > 1)
        //        {
        //            _nome = value;
        //        }
        //    }
        //}



        //POSSO CRIAR UMA SOBRECARGA DE UM CONSTRUTOR SEM VALOR ALGUM, POIS NA APLICAÇÃO AJUDA PARA NÃO DAR ERRO.
        // USADO PARA DEFINIR CASO OUTROS CONSTRUTORES FAÇAM A SOBRECARGA PARCIAL DE ITENS.
        public Produto1()
        {


        }


        //Construtor que irá receber os valores
        public Produto1(string nome, double preco, int quantidade)
        {

            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}