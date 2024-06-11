using ModeloSegundoParcial.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloSegundoParcial.Servicios;
public interface IServicioSucursal
{
    List<Sucursal> ObtenerSucursales();
}
public class ServicioSucursal : IServicioSucursal
{
    private GestionDeEmpleadosContext _context;
    public ServicioSucursal(GestionDeEmpleadosContext context)
    {
        _context = context;
    }

    public List<Sucursal> ObtenerSucursales()
    {
        return _context.Sucursals
            .Where(s => !s.Eliminada)
            .OrderBy(s => s.Direccion)
            .ToList();
    }

}

