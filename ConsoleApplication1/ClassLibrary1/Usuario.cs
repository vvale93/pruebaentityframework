using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Usuario
    {
        public string Login { get; set; }
        public DateTime FechaUltimoLogin { get; set; }
        public int IntentosInvalidos { get; set; }
        public Perfil Perfil { get; set; }

    }
}
