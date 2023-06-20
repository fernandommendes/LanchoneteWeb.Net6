using LanchoneteWeb.Context;
using LanchoneteWeb.Models;

namespace LanchoneteWeb.Areas.Admin.Servicos
{
    public class GraficoVendasService
    {
        private readonly AppDbContext context;

        public GraficoVendasService(AppDbContext context)
        {
            this.context = context;
        }

        public List<LancheGrafico> GetVendasLanches(int dias = 360)
        {
            var data = DateTime.Now.AddDays(-dias);

            var lanches = (from pd in context.PedidoDetalhes
                           join l in context.Lanches on pd.LancheId equals l.LancheId
                           where pd.Pedido.PedidoEnviado >= data
                           group pd by new { pd.LancheId, l.Nome }
                           into g
                           select new
                           {
                               LancheNome = g.Key.Nome,
                               LancheQuantidade = g.Sum(x => x.Quantidade),
                               LancheValorTotal = g.Sum(x => x.Preco * x.Quantidade)
                           });

            var lista = new List<LancheGrafico>();

            foreach (var item in lanches) 
            { 
                var lanche = new LancheGrafico();
                lanche.LancheNome = item.LancheNome;
                lanche.LanchesQuantidade = item.LancheQuantidade;
                lanche.LanchesValorTotal = item.LancheValorTotal;
                lista.Add(lanche);
            }

            return lista;

        }

    }
}
