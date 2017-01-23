using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAPIEmDupla.Models;
using System.Web.Http;

namespace ProjetoAPIEmDupla.Controllers.API
{
    public class OSController : ApiController
    {
        private bdDuplaEntities bd = new bdDuplaEntities();

        /// <summary>
        /// Busca ordem de servico com base no id
        /// </summary>
        public OrdemServico Get(int id)
        {
            bd.Configuration.ProxyCreationEnabled = false;

            var os = bd.OrdemServico.Include("ServicoPorOS").Where(m => m.IdOS == id).SingleOrDefault();
            bd.ServicoPorOS.Include("Servico").Where(m => m.IdOS == id).ToList();
            bd.OrdemServico.Include("Cliente").Where(m => m.IdOS == id).SingleOrDefault();

            //if (os == null)
            //    throw new HttpResponseException(HttpStatusCode.NotFound);

            return os;
        }
        
        public string Post(OrdemServico os)
        {
            try
            {
                bd.OrdemServico.Add(os);
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