using GestionArticulos.core.Entities;
using GestionArticulos.core.Interface;
using GestionArticulos.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionArticulos.Infraestructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        //inyeccion de dependencia
        private readonly DB_ARTICULOSContext _context;

        //método constructor para la inyección de dependencia
        public ItemRepository(DB_ARTICULOSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> GetItems()
        {
            var items = await _context.Producto.ToListAsync();
            return items;
        }
    }
}
