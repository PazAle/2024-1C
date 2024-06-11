using Microsoft.AspNetCore.Mvc;
using ModeloSegundoParcial.Dominio.Entidades;
using ModeloSegundoParcial.Servicios;

namespace ModeloSegundoParcial.Web.Controllers;

public class EmpleadoController : Controller
{
    private IServicioEmpleado _servicioEmpleado;
    private IServicioSucursal _servicioSucursal;
    public EmpleadoController(IServicioEmpleado servicioEmpleado, IServicioSucursal servicioSucursal)
    {
        _servicioEmpleado = servicioEmpleado;
        _servicioSucursal = servicioSucursal;
    }
    public IActionResult ListadoEmpleados(int? idSucursal)
    {
        ViewBag.Sucursales = _servicioSucursal.ObtenerSucursales();
        ViewBag.IdSucursalElegida = idSucursal;

        if(idSucursal.HasValue)
        {
            return View(_servicioEmpleado.ObtenerEmpleadosPorSucursal(idSucursal.Value));
        }
        else
        {
            return View(_servicioEmpleado.ObtenerEmpleados());
        }
    }

    [HttpPost]
    public IActionResult CrearEmpleado(Empleado empleado)
    {
        ViewBag.Sucursales = _servicioSucursal.ObtenerSucursales();
        if (!ModelState.IsValid)
            return View(empleado);

        _servicioEmpleado.CrearEmpleado(empleado);
        return RedirectToAction("ListadoEmpleados");
    }
    [HttpGet]
    public IActionResult CrearEmpleado()
    {
        ViewBag.Sucursales = _servicioSucursal.ObtenerSucursales();
        return View();
    }

}
