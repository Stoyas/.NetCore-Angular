using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vega.Controllers;
using vega.Models;

namespace vega.Persistence
{
    public class VehicleRepository: IVehicleRepository
    {
        private VegaDbContext _context { get; set; }
        public VehicleRepository(VegaDbContext context)
        {
            this._context = context;
        }
        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true)
        {
            if(!includeRelated)
            {
                return await _context.Vehicles.FindAsync(id);
            }
            return await _context.Vehicles
            .Include(v => v.Features)
            .ThenInclude(vf => vf.Feature)
            .Include(v => v.Model)
            .ThenInclude(vf => vf.Make)
            .SingleOrDefaultAsync(v => v.Id == id);
        }
        public void AddVehicle(Vehicle vehicle)
        {
            _context.Add(vehicle);
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            _context.Remove(vehicle);
        }
    }
}