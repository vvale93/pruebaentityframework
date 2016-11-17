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
            Perfil p = ctx.Perfiles.FirstOrDefault();
            Console.WriteLine($"{p.Descripcion}");
            Console.ReadLine();
        }
    }
}
