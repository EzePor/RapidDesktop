using Microsoft.EntityFrameworkCore;
using RapidDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RapidDesktop.Data
{
    public class RapidDesktopContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Provincia> Provincias { get; set; }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Rubro> Rubros { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }



        public RapidDesktopContext()
        {

        }

        public RapidDesktopContext(DbContextOptions<RapidDesktopContext> options) : base(options)
        {

        }
        // método donde hacemos la conexión a la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=.\\SQLEXPRESS; User Id=sa ; Password=123 ; Database=RapidDesktopContext; MultipleActiveResultSets=True ; Encrypt=False ";
            optionsBuilder.UseSqlServer(connectionString);
        }

        // método donde creamos los datos semillas para clientes
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Id = 1,
                    ApellidoNombre = "Mamadera Roberto",
                    Dirección = "Maipú 2255",
                    Teléfono = "1563554",
                    Email = "robertomam@gmail.com"
                },
                new Cliente()
                {
                    Id = 2,
                    ApellidoNombre = "Catrasca Dalmiro",
                    Dirección = "Corrientes 1698",
                    Teléfono = "15569753",
                    Email = "catradalmiro@gmail.com"
                },
                new Cliente()
                {
                    Id = 3,
                    ApellidoNombre = "Tandarika José Luis",
                    Dirección = "3 de Febrero 986",
                    Teléfono = "1541122",
                    Email = "tandajoseluis@gmail.com"
                }
                );

            // datos semillas localidades
            modelBuilder.Entity<Localidad>().HasData(
            new Localidad()
            {
                Id = 1,
                Nombre = "San Justo",
                CodigoPostal = "3040"
            },
            new Localidad()
            {
                Id = 2,
                Nombre = "Videla",
                CodigoPostal = "3042"
            },
            new Localidad()
            {
                Id = 3,
                Nombre = "Soledad",
                CodigoPostal = "3048"
            });

            // datos semillas provincia
            modelBuilder.Entity<Provincia>().HasData(
            new Provincia()
            {
                Id = 1,
                Nombre = "Santa Fe"
            },
            new Provincia()
            {
                Id = 2,
                Nombre = "Entre Ríos"
            },
            new Provincia()
            {
                Id = 3,
                Nombre = "Córdoba"
            });


            // datos semillas Producto
            modelBuilder.Entity<Producto>().HasData(
            new Producto()
            {
                Id = 1,
                Nombre = "Reloj SmartWatch W26",
                Precio = 15000.00m,
                GarantiaFabricante = "1 año"
            
            },
            new Producto()
            {
                Id = 2,
                Nombre = "Foto 13x18",
                Precio = 300.00m,
                GarantiaFabricante = "100 años"
            },
            new Producto()
            {
                Id = 3,
                Nombre = "Funda Motorola G22",
                Precio = 3000.00m,
                GarantiaFabricante = "6 meses"
            },
            new Producto()
            {
                Id = 4,
                Nombre = "Combo mouse y teclado gamer",
                Precio = 11900.00m,
                GarantiaFabricante = "1 año"
            }
            );

            // datos semillas Rubro
            modelBuilder.Entity<Rubro>().HasData(
            new Rubro()
            {
                Id = 1,
                Nombre = "Fotografía"
            },
            new Rubro()
            {
                Id = 2,
                Nombre = "Accesorios para celulares"
            },
            new Rubro()
            {
                Id = 3,
                Nombre = "Relojería"
            },
            new Rubro()
            {
                Id = 4,
                Nombre = "Informática"
            },
            new Rubro()
            {
                Id = 5,
                Nombre = "Electrónica"
            });

            // datos semillas Proveedores
            modelBuilder.Entity<Proveedor>().HasData(
            new Proveedor()
            {
                Id = 1,
                Nombre = "Dipromas SRL",
                Email = "dipromas@dipromas.com",
                Teléfono = "035148445566"
            },
            new Proveedor()
            {
                Id = 2,
                Nombre = "ShoppCell",
                Email = "shoppcell@gmail.com",
                Teléfono = "01145553322"

            },
            new Proveedor()
            {
                Id = 3,
                Nombre = "Hunistor SA",
                Email = "hunistorsa@yahoo.com",
                Teléfono = "01155443322"

            });

            modelBuilder.Entity<Fabricante>().HasData(
                new Fabricante()
                {
                    Id = 1,
                    Nombre = "FujiFilm",
                    Nacionalidad = "Japón",
                    Email = "fujifilm@fujifilm.com",

                },
                new Fabricante()
                {
                    Id = 2,
                    Nombre = "NewTalent SA",
                    Nacionalidad = "EE.UU.",
                    Email = "newtalent@newtalent.com"
                },
                new Fabricante()
                {
                    Id = 3,
                    Nombre = "General Electric",
                    Nacionalidad = "España",
                    Email = "generalelectric@generalelectric.com"
                },
                new Fabricante()
                {
                    Id = 4,
                    Nombre = "Marand SA",
                    Nacionalidad = " Argentina",
                    Email = "marandsa@gmail.com",
                },
                new Fabricante()
                {
                    Id = 5,
                    Nombre = "D-kota SA",
                    Nacionalidad = "China",
                    Email = "dkotasa@dakotasa.com",
                });
        }
    }
}
