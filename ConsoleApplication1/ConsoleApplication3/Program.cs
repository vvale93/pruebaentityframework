using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data;

namespace TestEF
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextoOMB ctx = new ContextoOMB ();

            if (ctx.Database.Exists())
                Console.WriteLine("La base esta...");
            Console.ReadLine();

            //Perfil p = ctx.Perfiles.FirstOrDefault();

            //Console.WriteLine($"{p.Descripcion}");

            Usuario usr = ctx.Usuarios.Where(u => u.Login == "Pitusas").FirstOrDefault();

             Console.WriteLine($"{usr.Login}  {usr.Perfil.Descripcion}");
            Perfil p = usr.Perfil;
            foreach (var pp in p.Usuarios)
            {
                Console.WriteLine($"{pp.Login}");
            }

            //Perfil p = ctx.Perfiles.Where(per => per.Descripcion.ToLower() == "avanzado").FirstOrDefault() ; // si existe el perfil lo usa

            //if(p == null) //Y sino lo crea
            //{
            //    p = new Perfil();
            //    p.Descripcion = "Avanzado";
            //}

            //Usuario usr = new Usuario();
            //usr.Login = "Carlos3";
            //usr.Perfil = p;

            //ctx.Usuarios.Add(usr);

            //ctx.SaveChanges();

            Console.ReadLine();
        }
    }
}
