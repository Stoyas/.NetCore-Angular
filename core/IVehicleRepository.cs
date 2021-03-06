using System.Threading.Tasks;
using vega.Models;

namespace vega.core
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
         void AddVehicle(Vehicle vehicle);
         void RemoveVehicle(Vehicle vehicle);
    }
}