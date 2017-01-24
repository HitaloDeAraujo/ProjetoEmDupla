using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ProjetoAPIEmDupla.Models;

namespace ProjetoAPIEmDupla.Controllers.API
{
    public class ServicoController : ApiController
    {
        private bdDuplaEntities bd = new bdDuplaEntities();

        /// <summary>
        /// Busca ordem de servico com base no id
        /// </summary>
        public Servico Get(int id)
        {
            bd.Configuration.ProxyCreationEnabled = false;

            var servico = bd.Servico.Where(m => m.IdServico == id).SingleOrDefault();

            return servico;
        }

        /// <summary>
        /// Busca ordem de servico com base no id
        /// </summary>
        public IEnumerable<Servico> Get()
        {
            bd.Configuration.ProxyCreationEnabled = false;

            var servico = bd.Servico.ToList();

            return servico;
        }

        public string Post(Servico servico)
        {
            try
            {
                bd.Servico.Add(servico);
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