﻿using NetDevPack.Domain;

namespace NSE.Pedidos.Domain.Pedidos
{
    public class PedidoItem : Entity
    {
        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public string ProdutoNome { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public string ProdutoImagem { get; private set; }

        // EF Rel.
        public Pedido Pedido { get; private set; }

        public PedidoItem(Guid pedidoId, Guid produtoId, string produtoNome, int quantidade, 
            decimal valorUnitario, string produtoImagem = null)
        {
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            ProdutoNome = produtoNome;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ProdutoImagem = produtoImagem;
        }

        // EF ctor
        protected PedidoItem()
        {
        }

        internal decimal CalcularValor()
        {
            return Quantidade * ValorUnitario;
        }
    }
}
