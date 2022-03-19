using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PeliculasSW.Model;

namespace PeliculasSW
{
    /// <summary>
    /// Descripción breve de LibrosWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class LibrosWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Welcome()
        {
            return "Bienvenido a Servicio Web Libros :)";
        }
        [WebMethod(Description = "Devuelve la lista de Libros ")]
        public List<Libro> GetLibros()
        {
            LibrosEntities cone = new LibrosEntities();
            var con = (from c in cone.Libroes select c).ToList();
            return con;
        }

        [WebMethod(Description = "Agregando Libros :) ")]
        public bool AgregarLibros(string titulo, string fechalanzamiento, int autor, int categoria, int editorial, string idioma, string descripcion)
        {
            try
            {
                using (var cone = new LibrosEntities())
                {


                    Libro libronuevo = new Libro();
                    libronuevo.Titulo = titulo;
                    libronuevo.FechaLanzamiento = fechalanzamiento;
                    libronuevo.Autor = autor;
                    libronuevo.Categoria = categoria;
                    libronuevo.Editorial = editorial;
                    libronuevo.Idioma = idioma;
                    libronuevo.Descripcion = descripcion;
                    cone.Libroes.Add(libronuevo);
                    cone.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }

            
            
        }

        [WebMethod(Description ="Eliminando Libros :) ")]
        public bool BorrarLibros(int idlibro)
        {
            try
            {
                using(var cone = new LibrosEntities())
                {
                    var consu = (from c in cone.Libroes
                                 where c.IdLibro == idlibro
                                 select c).FirstOrDefault();
                    if (consu != null)
                    {
                        cone.Libroes.Remove(consu);
                        cone.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                                 
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod(Description ="Modificando Libros")]
        public bool ModificandoLibros(int idlibros, string titulo, string fechalanzamiento, int autor, int categoria, int editorial, string idioma, string descripcion)
        {
            try
            {
                using (var cone = new LibrosEntities())
                {
                    var consu = (from c in cone.Libroes
                                 where c.IdLibro == idlibros
                                 select c).FirstOrDefault();
                    if (cone != null)
                    {
                        consu.Titulo = titulo;
                        consu.FechaLanzamiento = fechalanzamiento;
                        consu.Autor = autor;
                        consu.Categoria = categoria;
                        consu.Editorial = editorial;
                        consu.Idioma = idioma;
                        consu.Descripcion = descripcion;
                        cone.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
               
                

            }
            catch(Exception)
            {
                return false;
            }
        }

    }
}
