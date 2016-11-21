using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Entidades;

namespace Data
{
    public class ContextoOMB : DbContext //TestEFContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Perfil> Perfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) //modelBuilder inspecciona las clases que yo referencie en propiedades del contexto.
        {
            modelBuilder.Configurations.Add(new ConfiguraPerfil());
            modelBuilder.Configurations.Add(new ConfiguraUsuario());
        }
    }



    public class ConfiguraPerfil : EntityTypeConfiguration<Perfil>
    {
        public ConfiguraPerfil()
        {
            HasKey(p => p.IDPerfil);

            this.Property(p => p.IDPerfil).HasColumnName("ID_Perfil");

            this.ToTable("Perfiles");
        }
    }
    
    public class ConfiguraUsuario : EntityTypeConfiguration<Usuario>
    {
        public ConfiguraUsuario ()
        {
            HasKey(usr => usr.Login);

            //this.HasRequired(usr => usr.Perfil).WithMany().Map(cfg => cfg.MapKey("ID_Perfil"));       // mapea la clave primary key
            this.HasRequired(usr => usr.Perfil)
                .WithMany(p => p.Usuarios)
                .Map(cfg => cfg.MapKey("ID_Perfil"));       // mapea la clave primary key 
        }
    }

}
