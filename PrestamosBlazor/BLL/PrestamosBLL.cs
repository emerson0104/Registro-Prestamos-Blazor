using Microsoft.EntityFrameworkCore;
using PrestamosBlazor.DAL;
using PrestamosBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PrestamosBlazor.BLL
{
    public class PrestamosBLL
    {
        public static Prestamos Buscar(int id)

        {

            Contexto contexto = new Contexto();

            Prestamos prestamo;



            try

            {

                prestamo = contexto.Prestamos.Find(id);

            }

            catch (Exception)

            {



                throw;

            }

            finally

            {

                contexto.Dispose();

            }

            return prestamo;



        }
        public static bool Guardar(Prestamos prestamo)

        {

            if (!Existe(prestamo.PrestamoId))

                return Insertar(prestamo);

            else

                return Modificar(prestamo);



        }



        private static bool Insertar(Prestamos prestamo)

                {

            bool paso = false;

            Contexto contexto = new Contexto();



            try

            {

                contexto.Prestamos.Add(prestamo);
                
               
                
                contexto.Personas.Find(prestamo.PersonaId).Balance += prestamo.Balance;
                
                paso = contexto.SaveChanges() > 0;

            }

            catch (Exception)

            {



                        throw;



            }

            finally

            {

                contexto.Dispose();

            }

            return paso;

        }





        private static bool Modificar(Prestamos prestamo)

        {

            bool paso = false;

            decimal balances = Buscar(prestamo.PrestamoId).Balance;

            int ID = Buscar(prestamo.PrestamoId).PersonaId;

            Contexto contexto = new Contexto();



            try

            {

                if (ID != prestamo.PersonaId)

                {

                    contexto.Personas.Find(ID).Balance -= balances;

                    contexto.Personas.Find(prestamo.PersonaId).Balance += prestamo.Balance;

                }

                else

                {

                    contexto.Personas.Find(prestamo.PersonaId).Balance -= balances;

                    contexto.Personas.Find(prestamo.PersonaId).Balance += prestamo.Balance;

                }



                contexto.Entry(prestamo).State = EntityState.Modified;

                paso = contexto.SaveChanges() > 0;



            }

            catch (Exception)

            {

                throw;

            }

            finally

            {

                contexto.Dispose();

            }

            return paso;

        }



        public static bool Eliminar(int id)

        {

            bool paso = false;

            Contexto contexto = new Contexto();



            try

            {

                var Prestamo = contexto.Prestamos.Find(id);

                if (Prestamo != null)

                {

                    contexto.Personas.Find(Prestamo.PersonaId).Balance -= Prestamo.Balance; 

                    contexto.Prestamos.Remove(Prestamo);//remueve la entidad

                    paso = contexto.SaveChanges() > 0;



                }

            }

            catch (Exception)

            {

                throw;

            }

            finally

            {

                contexto.Dispose();

            }

            return paso;

        }
        public static List<Prestamos> GetList(Expression<Func<Prestamos, bool>> prestamo)

        {

            List<Prestamos> lista = new List<Prestamos>();

            Contexto db = new Contexto();



            try

            {

                lista = db.Prestamos.Where(prestamo).ToList();

            }

            catch (Exception)

            {



                throw;

            }

            finally

            {

                db.Dispose();

            }



            return lista;

        }



        public static bool Existe(int id)

        {

            Contexto contexto = new Contexto();

            bool encontrado = false;



            try

            {

                encontrado = contexto.Prestamos.Any(p => p.PrestamoId == id);



            }

            catch (Exception)

            {

                throw;

            }

            finally

            {

                contexto.Dispose();

            }



            return encontrado;



        }

    }
}
