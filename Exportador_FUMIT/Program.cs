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
            bool agregaObservaciones = true;



            
            //Se obtienen de la tabla Activo$
            var context = new FumitContext();
            IEnumerable<Activos36> activos36 = context.Activos36.ToArray();
            foreach (Activos36 item in activos36)
            {
                //Exportar clientes
                //item.

                //Agregar observaciones
                if (agregaObservaciones)
                {
                    Cliente cliente = context.Clientes.FirstOrDefault(f => f.Nombre == item.NombreComercial && f.NombreFiscal == item.NombreFiscal);

                    if (cliente != null)
                    {
                        cliente.Observaciones = "";
                        cliente.Observaciones += !string.IsNullOrEmpty(item.Contenedor3M) ? $"Contenedor 3m: {item.Contenedor3M}\r\n" : "";
                        cliente.Observaciones += !string.IsNullOrEmpty(item.Contenedor6M) ? $"Contenedor 6m: {item.Contenedor6M}\r\n" : "";
                        cliente.Observaciones += !string.IsNullOrEmpty(item.DiasDeRevision) ? $"Dias de revision: {item.DiasDeRevision}\r\n" : "";
                        cliente.Observaciones += !string.IsNullOrEmpty(item.DiasDePago) ? $"Dias de pago: {item.DiasDePago}\r\n" : "";
                        cliente.Observaciones += !string.IsNullOrEmpty(item.HorarioDePagos) ? $"Horarios depago: {item.HorarioDePagos}\r\n" : "";
                        cliente.Observaciones += !string.IsNullOrEmpty(item.ModoDePago) ? $"Modos de pago: {item.Columna1} - {item.Columna12} - {item.ModoDePago}" : "";
                    }

                    context.SaveChanges();
                }


                //Exportar contactos
                if (exportaContactos)
                {
                    string Contacto = item.Contacto ?? "";
                    string Telefono = item.Telefono ?? "";
                    string EMail = item.EMail ?? "";

                    string[] contactosNombres = Contacto.Split('/').Select(s => s.Trim()).ToArray();
                    string[] contactosTelefonos = Telefono.Split('/').Select(s => s.Trim()).ToArray();
                    string[] contactosCorreos = EMail.Split('/',';').Select(s => s.Trim()).ToArray();

                    for (int i = 0; i < contactosNombres.Length; i++)
                    {
                        Contacto contacto = new Contacto();
                        contacto.Nombre = contactosNombres.ElementAtOrDefault(i) ?? "";
                        contacto.Telefono = contactosTelefonos.ElementAtOrDefault(i) ?? "";
                        contacto.Correo = contactosCorreos.ElementAtOrDefault(i) ?? "";
                        contacto.Tipo = "Comercial";

                        //Limpiar correo
                        if (contacto.Correo.IndexOf('<') >= 0 && contacto.Correo.IndexOf('>') >= 0) {
                            contacto.Correo = contacto.Correo.Substring(contacto.Correo.IndexOf("<")+1,  contacto.Correo.IndexOf(">") - (contacto.Correo.IndexOf("<") + 1));
                                }

                        //Obtenemos el cliente en base al nombre
                        Cliente cliente = context.Clientes.FirstOrDefault(f => f.Nombre == item.NombreComercial && f.NombreFiscal == item.NombreFiscal);

                        if (cliente != null)
                        {
                            contacto.ClienteId = cliente.ClienteId;
                            contacto.Cliente = cliente;
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", contacto.Cliente, contacto.Nombre, contacto.Telefono, contacto.Correo);
                            context.Contactoes.Add(contacto);
                        }

                        //Si hay contacto de pagos agregar
                        if (!string.IsNullOrEmpty(item.ContactoDePagos))
                        {
                            var contacto2 = new Contacto();
                            contacto2.Nombre = item.ContactoDePagos ?? "";
                            contacto2.Correo = item.CorreoDePagos ?? "";
                            contacto2.Tipo = "De pago";
                            contacto2.ClienteId = cliente.ClienteId;
                            contacto2.Cliente = cliente;

                            //Console.WriteLine("{0}\t{1}\t{2}\t{3}", contacto.Cliente, contacto.Nombre, contacto.Telefono, contacto.Correo);
                            context.Contactoes.Add(contacto2);
                        }

                    }

                    context.SaveChanges();
                }
            }

        }
    }
}
