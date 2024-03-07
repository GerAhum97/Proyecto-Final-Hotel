using HotelTrabajoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Enum = HotelTrabajoFinal.Enumerations.Enum;

namespace HotelTrabajoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var miModelo = new Reservas();

            var ListaDeHabitaciones = new List<SelectListItem>();
            ListaDeHabitaciones.Add( new SelectListItem {Value = "1", Text = "Accesible" } );
            ListaDeHabitaciones.Add( new SelectListItem {Value = "2", Text = "Classic" } );
            ListaDeHabitaciones.Add( new SelectListItem {Value = "3", Text = "City View" } );
            ListaDeHabitaciones.Add( new SelectListItem {Value = "4", Text = "Suite" } );
            ListaDeHabitaciones.Add( new SelectListItem {Value = "5", Text = "Sala de Eventos" } );
            ListaDeHabitaciones.Add( new SelectListItem {Value = "6", Text = "Gimnasio" } );

            var TipoHabitaciones = new SelectList(ListaDeHabitaciones, "Value", "Text");
            ViewBag.ListaDeHabitaciones = TipoHabitaciones;

            return View(miModelo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "La descripción de mi página.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Mi página de contacto.";

            return View();
        }
        public ActionResult Reservas()
        {
            ViewBag.Message = "Mi página de reservas.";

            return View();
        }
        [HttpPost]
        public JsonResult GuardarHabitacion(Reservas modelo)
        {
            var respuesta = new Dictionary<string, string>
            {
               { "msj", "¡La reserva se guardó correctamente!" }
            };

            if (modelo.NombreHabitacion == ((int)Enum.HabitacionTipo.Accesible).ToString())
            {
                modelo.NombreHabitacion = "Accesible";
            }
            if (modelo.NombreHabitacion == ((int)Enum.HabitacionTipo.Classic).ToString())
            {
                modelo.NombreHabitacion = "Classic";
            }
            if (modelo.NombreHabitacion == ((int)Enum.HabitacionTipo.ClassicCityView).ToString())
            {
                modelo.NombreHabitacion = "ClassicCityView";
            }
            if (modelo.NombreHabitacion == ((int)Enum.HabitacionTipo.Suite).ToString())
            {
                modelo.NombreHabitacion = "Suite";
            }
            if (modelo.NombreHabitacion == ((int)Enum.HabitacionTipo.SalaDeEventos).ToString())
            {
                modelo.NombreHabitacion = "SalaDeEventos";
            }
            if (modelo.NombreHabitacion == ((int)Enum.HabitacionTipo.Gimnasio).ToString())
            {
                modelo.NombreHabitacion = "Gimnasio";
            }


            if (modelo.Precio == 0)
            {
                respuesta = new Dictionary<string, string>
                {
                    { "msg", "Se ha producido un error" }
                };

                Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                return Json(respuesta, JsonRequestBehavior.AllowGet);
            }

            return Json(respuesta, JsonRequestBehavior.AllowGet);
        }

    }
}