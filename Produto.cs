using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Modificadores_de_acesso_mais_completo.App_Start
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //POSSO CRIAR UMA SOBRECARGA DE UM CONSTRUTOR SEM VALOR ALGUM, POIS NA APLICAÇÃO AJUDA PARA NÃO DAR ERRO.
        // USADO PARA DEFINIR CASO OUTROS CONSTRUTORES FAÇAM A SOBRECARGA PARCIAL DE ITENS.
        public Produto()
        {


        }

        //      QUANDO USAR THIS É PORQUE ELE EVITA ERROS NA CONSTRUÇÃO, ESSE EXEMPLO PODE SER
        // IGUAL AO EXEMPLO DE BAIXO, DÁ NA MESMA - O PROGRAMA DIFERENCIA MAISCULA DE MINUSCULA.
        //public Produto(string Nome, double Preco, int Quantidade)
        //{

        //     this.Nome = Nome;
        //     this.Preco = Preco;
        //     this.Quantidade = Quantidade;
        //}



        //Construtor que irá receber os valores
        public Produto(string nome, double preco, int quantidade) {

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}