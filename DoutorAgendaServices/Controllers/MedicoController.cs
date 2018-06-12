using DoutorAgendaServices.Contexts;
using DoutorAgendaServices.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoutorAgendaServices.Controllers
{
    [Route("api/[controller]")]
    public class MedicoController : Controller
    {
        private DoutorAgendaContext _context;
        public MedicoController(DoutorAgendaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IList<MedicoModel> Get()
        {
            return _context.MedicoTable.ToList();
        }
    }
}
