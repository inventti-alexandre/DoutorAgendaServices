using DoutorAgendaServices.Contexts;
using DoutorAgendaServices.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DoutorAgendaServices.Controllers
{
    [Route("api/[controller]")]
    public class AgendamentoController : Controller
    {
        private DoutorAgendaContext _context;
        public AgendamentoController(DoutorAgendaContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IList<AgendamentoModel> ListarAgendamentosPorPaciente(int pacienteId)
        {
            return _context.AgendamentoTable.Where(a => a.Paciente.Id == pacienteId).ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]AgendamentoModel model)
        {
            _context.AgendamentoTable.Add(model);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]AgendamentoModel model)
        {
            var agendamentoAnterior = _context.AgendamentoTable.SingleOrDefault(a => a.Id == id);
            agendamentoAnterior.Medico = model.Medico;
            agendamentoAnterior.DataHoraConsulta = model.DataHoraConsulta;
            _context.AgendamentoTable.Update(agendamentoAnterior);
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var agendamento = _context.AgendamentoTable.SingleOrDefault(a => a.Id == id);
            _context.AgendamentoTable.Remove(agendamento);
            _context.SaveChanges();
        }
    }
}
