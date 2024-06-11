using ModeloSegundoParcial.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloSegundoParcial.Servicios;

public interface IServicioEmpleado
{
    void CrearEmpleado(Empleado empleado);
    List<Empleado> ObtenerEmpleados();
    void EliminarEmpleado(int idEmpleado);
    List<Empleado> ObtenerEmpleadosPorSucursal(int idSucursal);
}
public class ServicioEmpleado : IServicioEmpleado
{
    private GestionDeEmpleadosContext _context;
    public ServicioEmpleado(GestionDeEmpleadosContext context)
    {
        _context = context;
    }

    public void CrearEmpleado(Empleado empleado)
    {
        _context.Empleados.Add(empleado);
        _context.SaveChanges();
    }

    public List<Empleado> ObtenerEmpleados()
    {
        return _context.Empleados.Where(e => !e.IdSucursalNavigation.Eliminada)
            .ToList();
    }

    public void EliminarEmpleado(int idEmpleado)
    {
        var empleado = _context.Empleados.Find(idEmpleado);
        _context.Empleados.Remove(empleado);
        _context.SaveChanges();
    }
    public List<Empleado> ObtenerEmpleadosPorSucursal(int idSucursal)
    {
        return _context.Empleados.Where(e => e.IdSucursal == idSucursal && !e.IdSucursalNavigation.Eliminada).ToList();
    }
}


