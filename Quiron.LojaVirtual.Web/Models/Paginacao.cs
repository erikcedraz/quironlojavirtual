using System;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        //quanto itens eu tenho no banco
        public int ItensTotal { get; set; }

        //quanto itens eu quero por pagina
        public int ItensPorPagina { get; set; }

        //qual pagina exibida no momento
        public int PaginaAtual { get; set; }

        //quantos paginas eu vou ter
        public int TotalPagina 
        {
            get 
            {
                return (int)Math.Ceiling((decimal)ItensTotal/ItensPorPagina);
            } 
        }
    }
}