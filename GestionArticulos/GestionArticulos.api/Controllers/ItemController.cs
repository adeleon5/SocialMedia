using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionArticulos.core.Interface;
using GestionArticulos.Infraestructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionArticulos.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        //inyeccion de dependencia
        private readonly IItemRepository _ItemRepository;

        //método constructor para la inyección de dependencia
        public ItemController(IItemRepository ItemRepository)
        {
            _ItemRepository = ItemRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _ItemRepository.GetItems();
            return Ok(items);
        }
    }
}
