using ProjetoAPIEmDupla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ProjetoAPIEmDupla.Controllers.API
{
    public class ClienteController : ApiController
    {
        private bdDuplaEntities bd = new bdDuplaEntities();

        public IEnumerable<OrdemServico> Get(string id)
        {
            bd.Configuration.ProxyCreationEnabled = false;

            var cliente = bd.OrdemServico.Include("Cliente").Where(m => m.IdCliente == id).ToList();
            bd.OrdemServico.Include("ServicoPorOS").Where(m => m.IdCliente == id).ToList();
            bd.ServicoPorOS.Include("Servico").Where(m => m.IdSPO.ToString() == id).ToList();

            return cliente;
        }

        public string Post(Cliente cliente)
        {
            //teste
            try
            {
                bd.Cliente.Add(cliente);
                bd.SaveChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            

        }
    }
}