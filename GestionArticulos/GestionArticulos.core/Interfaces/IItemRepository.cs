using GestionArticulos.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestionArticulos.core.Interface
{
    public interface IItemRepository
    {
        Task<IEnumerable<Producto>> GetItems();
    } 
}
