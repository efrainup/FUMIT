using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exportador_FUMIT
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exportaContactos = false;
            bool agregaObservaciones = false;
            int nivelDeMigracion = 3;

            var context = new FumitContext();


            //if (nivelDeMigracion == 1)
            //{
            //    //Se obtienen de la tabla Activo$
            //    IEnumerable<Activos36> activos36 = context.Activos36.ToArray();
            //    foreach (Activos36 item in activos36)
            //    {
            //        //Exportar clientes
            //        //item.

            //        //Agregar observaciones
            //        if (agregaObservaciones)
            //        {
            //            Cliente cliente = context.Clientes.FirstOrDefault(f => f.Nombre == item.NombreComercial && f.NombreFiscal == item.NombreFiscal);

            //            if (cliente != null)
            //            {
            //                cliente.Observaciones = "";
            //                cliente.Observaciones += !string.IsNullOrEmpty(item.Contenedor3M) ? $"Contenedor 3m: {item.Contenedor3M}\r\n" : "";
            //                cliente.Observaciones += !string.IsNullOrEmpty(item.Contenedor6M) ? $"Contenedor 6m: {item.Contenedor6M}\r\n" : "";
            //                cliente.Observaciones += !string.IsNullOrEmpty(item.DiasDeRevision) ? $"Dias de revision: {item.DiasDeRevision}\r\n" : "";
            //                cliente.Observaciones += !string.IsNullOrEmpty(item.DiasDePago) ? $"Dias de pago: {item.DiasDePago}\r\n" : "";
            //                cliente.Observaciones += !string.IsNullOrEmpty(item.HorarioDePagos) ? $"Horarios depago: {item.HorarioDePagos}\r\n" : "";
            //                cliente.Observaciones += !string.IsNullOrEmpty(item.ModoDePago) ? $"Modos de pago: {item.Columna1} - {item.Columna12} - {item.ModoDePago}" : "";
            //            }

            //            context.SaveChanges();
            //        }


            //        //Exportar contactos
            //        if (exportaContactos)
            //        {
            //            string Contacto = item.Contacto ?? "";
            //            string Telefono = item.Telefono ?? "";
            //            string EMail = item.EMail ?? "";

            //            string[] contactosNombres = Contacto.Split('/').Select(s => s.Trim()).ToArray();
            //            string[] contactosTelefonos = Telefono.Split('/').Select(s => s.Trim()).ToArray();
            //            string[] contactosCorreos = EMail.Split('/', ';').Select(s => s.Trim()).ToArray();

            //            for (int i = 0; i < contactosNombres.Length; i++)
            //            {
            //                Contacto contacto = new Contacto();
            //                contacto.Nombre = contactosNombres.ElementAtOrDefault(i) ?? "";
            //                contacto.Telefono = contactosTelefonos.ElementAtOrDefault(i) ?? "";
            //                contacto.Correo = contactosCorreos.ElementAtOrDefault(i) ?? "";
            //                contacto.Tipo = "Comercial";

            //                //Limpiar correo
            //                if (contacto.Correo.IndexOf('<') >= 0 && contacto.Correo.IndexOf('>') >= 0)
            //                {
            //                    contacto.Correo = contacto.Correo.Substring(contacto.Correo.IndexOf("<") + 1, contacto.Correo.IndexOf(">") - (contacto.Correo.IndexOf("<") + 1));
            //                }

            //                //Obtenemos el cliente en base al nombre
            //                Cliente cliente = context.Clientes.FirstOrDefault(f => f.Nombre == item.NombreComercial && f.NombreFiscal == item.NombreFiscal);

            //                if (cliente != null)
            //                {
            //                    contacto.ClienteId = cliente.ClienteId;
            //                    contacto.Cliente = cliente;
            //                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", contacto.Cliente, contacto.Nombre, contacto.Telefono, contacto.Correo);
            //                    context.Contactoes.Add(contacto);
            //                }

            //                //Si hay contacto de pagos agregar
            //                if (!string.IsNullOrEmpty(item.ContactoDePagos))
            //                {
            //                    var contacto2 = new Contacto();
            //                    contacto2.Nombre = item.ContactoDePagos ?? "";
            //                    contacto2.Correo = item.CorreoDePagos ?? "";
            //                    contacto2.Tipo = "De pago";
            //                    contacto2.ClienteId = cliente.ClienteId;
            //                    contacto2.Cliente = cliente;

            //                    //Console.WriteLine("{0}\t{1}\t{2}\t{3}", contacto.Cliente, contacto.Nombre, contacto.Telefono, contacto.Correo);
            //                    context.Contactoes.Add(contacto2);
            //                }

            //            }

            //            context.SaveChanges();
            //        }
            //    }
            //}

            if (nivelDeMigracion == 2)
            {
                //Se registran los contenedores pasándolos de las observaciones al catálogo de contenedores y luego asignándolos.
                IEnumerable<Cliente> clientes = context.Clientes.ToList();
                foreach(Cliente cliente in clientes)
                {
                    Regex regex = new Regex(@"F\d+-\d+");
                    MatchCollection matches = regex.Matches(cliente.Observaciones ?? "");
                    Console.WriteLine(cliente.Nombre);

                    foreach (Match match in matches)
                    {


                        Console.WriteLine(match.Value);
                        //Console.WriteLine(match.Captures[0].Value);

                        var equipo = context.Equipoes.FirstOrDefault(f => f.NumeroEconomico == match.Value);
                        if(equipo == null)
                        {
                            equipo = new Equipo()
                            {
                                NumeroEconomico = match.Value,
                                Activo = true,
                                EnMantenimiento = false,
                                Borrado = false,
                                Estado = "Bueno",
                                Observaciones = "",
                                RequiereMantenimiento = false,
                                TipoEquipoId = new string[] { "F3", "F03" }.Any(a => match.Value.Contains(a)) ? 1 : 2
                            };

                            equipo = context.Equipoes.Add(equipo);
                            context.SaveChanges();
                            equipo = context.Equipoes.FirstOrDefault(f => f.NumeroEconomico == match.Value);
                        }

                        var asignacion = new AsignacionesEquipos()
                        {
                            Borrado = false,
                            ClienteId = cliente.ClienteId,
                            Cliente = cliente,
                            Equipo = equipo,
                            EquipoId = equipo.EquipoId,
                            FechaAsignación = DateTime.Now,
                            FechaEntrega = DateTime.Now,
                            FechaRegreso = null
                        };
                        context.AsignacionesEquipos.Add(asignacion);
                        context.SaveChanges();

                    }

                }

            }


            if(nivelDeMigracion== 3)
            {

                Cliente[] clientes = context.Clientes.ToArray();
                for(int i=0; i < clientes.Length; i++)
                {
                    if (!string.IsNullOrEmpty(clientes[i].Observaciones))
                    {
                        var contenedors = clientes[i].Observaciones.Split(',', ' ', '/', '\n', '\r').ToArray();

                        for(int k=0;k< contenedors.Length;k++)
                        {
                            string c = contenedors[k];
                            if(c == "F3" || c=="F03" || c=="F6" || c=="F06")
                            {
                                contenedors[k] = contenedors[k] + "-" + contenedors[k + 1];
                            }
                            if(c == "F3-" || c == "F03-" || c == "F6-" || c == "F06-")
                            {
                                contenedors[k] = contenedors[k] +contenedors[k + 1];
                            }
                        }

                        contenedors = contenedors.Where(w => w.Contains("F3") || w.Contains("F03") || w.Contains("F6") || w.Contains("F06")).ToArray();

                        for (int j = 0; j < contenedors.Length; j++)
                        {
                            string ne = contenedors[j];
                            var cont = context.Equipoes.FirstOrDefault(f => f.NumeroEconomico == ne);

                            if(cont == null)
                            {
                                int tipo = contenedors[j].Contains("F03") || contenedors[j].Contains("F3") ? 1 : (contenedors[j].Contains("F6") || contenedors[j].Contains("F06") ? 2 : 3);
                                cont = new Equipo()
                                {
                                    NumeroEconomico = contenedors[j],
                                    Activo = true,
                                    Borrado = false,
                                    EnMantenimiento = false,
                                    Estado = "Bueno",
                                    Observaciones = "",
                                    RequiereMantenimiento = false,
                                    TipoEquipoId = tipo,
                                    TipoEquipos = context.TipoEquipos.First(f => f.TipoEquipoId == tipo),
                                    Asignado = true

                                };

                                cont = context.Equipoes.Add(cont);
                                context.SaveChanges();
                                Console.WriteLine("Se agrego contenedor: " + cont.NumeroEconomico);
                            }
                            int cid = clientes[i].ClienteId;
                            var a1 = context.AsignacionesEquipos.FirstOrDefault(w => w.EquipoId == cont.EquipoId && w.ClienteId == cid);

                            if (a1 == null)
                            {
                                var a = new AsignacionesEquipos()
                                {
                                    Borrado = false,
                                    Equipo = cont,
                                    EquipoId = cont.EquipoId,
                                    Cliente = clientes[i],
                                    ClienteId = clientes[i].ClienteId,
                                    FechaAsignación = DateTime.Now,
                                    FechaEntrega = null,
                                    FechaRegreso = null,
                                    Ubicacion = null
                                };



                                context.AsignacionesEquipos.Add(a);
                                context.SaveChanges();
                                Console.WriteLine("Se asigno contenedor: " + cont.NumeroEconomico+ " a "+ clientes[i].Nombre);
                            }
                        }
                                

                    }
                }

             
            }
            Console.WriteLine("Completado...");
            Console.ReadKey();
        }
    }
}
