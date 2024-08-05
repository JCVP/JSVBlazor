using JSVProject_Common;
using JSVProject_DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSVProject_DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        public DbInitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
                if (!_roleManager.RoleExistsAsync(SD.Role_Admin).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
                    _roleManager.CreateAsync(new IdentityRole(SD.Role_User)).GetAwaiter().GetResult();
                }
                else
                {
                    return;
                }

                IdentityUser user = new()
                {
                    UserName = "juan@jsv.com",
                    Email = "juan@jsv.com",
                    EmailConfirmed = true
                };

                _userManager.CreateAsync(user, "Juan123*").GetAwaiter().GetResult();

                _userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();

                #region Provincias
                // Busco alguna provincia.

                if (_db.Provincias.Any())
                {
                    return;   // DB ya se creo
                }

                var provincias = new Provincia[]
                {

                      new Provincia{Descripcion="Neuquén"},
                      new Provincia{Descripcion="Rio Negro"},
                      new Provincia{Descripcion="Buenos Aires"}

                };
                foreach (Provincia p in provincias)
                {
                    _db.Provincias.Add(p);
                }
                _db.SaveChanges();
                #endregion

                #region Localidades
                var localidades = new Localidad[]
                {
                 new Localidad{Descripcion="ALUMINE", ProvinciaId = 1},
                 new Localidad{Descripcion="ALUMINE fuera de radio", ProvinciaId = 1},
                 new Localidad{Descripcion="ANDACOLLO", ProvinciaId = 1},
                 new Localidad{Descripcion="AÑELO FUERA DE RADIO", ProvinciaId = 1},
                 new Localidad{Descripcion="AÑELO RADIO MUNICIPAL", ProvinciaId = 1},
                 new Localidad{Descripcion="ARROYITOS", ProvinciaId = 1},
                 new Localidad{Descripcion="ARROYO BLANCO", ProvinciaId = 1},
                 new Localidad{Descripcion="ATREUCO", ProvinciaId = 1},
                 new Localidad{Descripcion="AUCAPAN", ProvinciaId = 1},
                 new Localidad{Descripcion="BAJADA DEL AGRIO", ProvinciaId = 1},
                 new Localidad{Descripcion="BARDA NEGRA", ProvinciaId = 1},
                 new Localidad{Descripcion="BARRANCAS", ProvinciaId = 1},
                 new Localidad{Descripcion="BELLA VISTA", ProvinciaId = 1},
                 new Localidad{Descripcion="BUTA RANQUIL", ProvinciaId = 1},
                 new Localidad{Descripcion="BUTACO", ProvinciaId = 1},
                 new Localidad{Descripcion="BUTALON NORTE", ProvinciaId = 1},
                 new Localidad{Descripcion="CAEPE MALAL", ProvinciaId = 1},
                 new Localidad{Descripcion="CAICHIHUE", ProvinciaId = 1},
                 new Localidad{Descripcion="CAJON DE ALMAZA", ProvinciaId = 1},
                 new Localidad{Descripcion="CAJON DE CURILEUVU", ProvinciaId = 1},
                 new Localidad{Descripcion="CANCHA HUINGANCO", ProvinciaId = 1},
                 new Localidad{Descripcion="CARRAN CURA", ProvinciaId = 1},
                 new Localidad{Descripcion="CAVIAHUE", ProvinciaId = 1},
                 new Localidad{Descripcion="CAYANTA", ProvinciaId = 1},
                 new Localidad{Descripcion="CENTENARIO", ProvinciaId = 1},
                 new Localidad{Descripcion="CENTENARIO SUR", ProvinciaId = 1},
                 new Localidad{Descripcion="CERRO LA PARVA", ProvinciaId = 1},
                 new Localidad{Descripcion="CHACAICO SUR", ProvinciaId = 1},
                 new Localidad{Descripcion="CHACAY MELEHUE", ProvinciaId = 1},
                 new Localidad{Descripcion="CHACAYCO", ProvinciaId = 1},
                 new Localidad{Descripcion="CHALLACO", ProvinciaId = 1},
                 new Localidad{Descripcion="CHAPELCO", ProvinciaId = 1},
                 new Localidad{Descripcion="CHAPUA", ProvinciaId = 1},
                 new Localidad{Descripcion="CHIUQUILIHUIN", ProvinciaId = 1},
                 new Localidad{Descripcion="CHORRIACA", ProvinciaId = 1},
                 new Localidad{Descripcion="CHOS MALAL", ProvinciaId = 1},
                 new Localidad{Descripcion="COCHICO", ProvinciaId = 1},
                 new Localidad{Descripcion="CODIHUE", ProvinciaId = 1},
                 new Localidad{Descripcion="COLIPILLE", ProvinciaId = 1},
                 new Localidad{Descripcion="COVUNCO ABAJO", ProvinciaId = 1},
                 new Localidad{Descripcion="COVUNCO ARRIBA", ProvinciaId = 1},
                 new Localidad{Descripcion="COYUCO", ProvinciaId = 1},
                 new Localidad{Descripcion="CUTRAL CO", ProvinciaId = 1},
                 new Localidad{Descripcion="EL CHAÑAR", ProvinciaId = 1},
                 new Localidad{Descripcion="EL CHAÑAR fuera de radio", ProvinciaId = 1},
                 new Localidad{Descripcion="EL CHOCON", ProvinciaId = 1},
                 new Localidad{Descripcion="EL CHOLAR", ProvinciaId = 1},
                 new Localidad{Descripcion="EL CHOLAR fuera de radio", ProvinciaId = 1},
                 new Localidad{Descripcion="EL HUECU", ProvinciaId = 1},
                 new Localidad{Descripcion="EL SALITRAL", ProvinciaId = 1},
                 new Localidad{Descripcion="EL SAUCE", ProvinciaId = 1},
                 new Localidad{Descripcion="ESPINAZO DEL ZORRO", ProvinciaId = 1},
                 new Localidad{Descripcion="FILLIS DEI", ProvinciaId = 1},
                 new Localidad{Descripcion="GUAÑACOS Y REÑILEO", ProvinciaId = 1},
                 new Localidad{Descripcion="HUA HUM", ProvinciaId = 1},
                 new Localidad{Descripcion="HUANTRAICO", ProvinciaId = 1},
                 new Localidad{Descripcion="HUARENCHENQUE", ProvinciaId = 1},
                 new Localidad{Descripcion="HUECHULAFQUEN", ProvinciaId = 1},
                 new Localidad{Descripcion="HUINGANCO", ProvinciaId = 1},
                 new Localidad{Descripcion="HUNCAL", ProvinciaId = 1},
                 new Localidad{Descripcion="INVERNADA VIEJA", ProvinciaId = 1},
                 new Localidad{Descripcion="JUNIN DE LOS ANDES", ProvinciaId = 1},
                 new Localidad{Descripcion="LA BUITRERA", ProvinciaId = 1},
                 new Localidad{Descripcion="LA CIENAGA", ProvinciaId = 1},
                 new Localidad{Descripcion="LA LIPELA", ProvinciaId = 1},
                 new Localidad{Descripcion="LA PICAZA", ProvinciaId = 1},
                 new Localidad{Descripcion="LA PRIMAVERA", ProvinciaId = 1},
                 new Localidad{Descripcion="LA UNION", ProvinciaId = 1},
                 new Localidad{Descripcion="LAGO LOLOG", ProvinciaId = 1},
                 new Localidad{Descripcion="LAGUNA AUQUINCO", ProvinciaId = 1},
                 new Localidad{Descripcion="LAGUNA BLANCA", ProvinciaId = 1},
                 new Localidad{Descripcion="LAGUNA MIRANDA", ProvinciaId = 1},
                 new Localidad{Descripcion="LAS BANDURRIAS Y TROMPUL", ProvinciaId = 1},
                 new Localidad{Descripcion="LAS COLORADAS", ProvinciaId = 1},
                 new Localidad{Descripcion="LAS COLORADAS fuera de radio", ProvinciaId = 1},
                 new Localidad{Descripcion="LAS CORTADERAS", ProvinciaId = 1},
                 new Localidad{Descripcion="LAS LAJAS", ProvinciaId = 1},
                 new Localidad{Descripcion="LAS OVEJAS", ProvinciaId = 1},
                 new Localidad{Descripcion="LAS TAGUAS Y CALEUFU", ProvinciaId = 1},
                 new Localidad{Descripcion="LIMAY CENTRO", ProvinciaId = 1},
                 new Localidad{Descripcion="LONCO LUAN", ProvinciaId = 1},
                 new Localidad{Descripcion="LONCO MULA", ProvinciaId = 1},
                 new Localidad{Descripcion="LONCOPUE", ProvinciaId = 1},
                 new Localidad{Descripcion="LONCOPUE fuera de radio", ProvinciaId = 1},
                 new Localidad{Descripcion="LOS CHIHUIDOS", ProvinciaId = 1},
                 new Localidad{Descripcion="LOS MICHES", ProvinciaId = 1},
                 new Localidad{Descripcion="MALLIN DE LOS CABALLOS", ProvinciaId = 1},
                 new Localidad{Descripcion="MANZANO AMARGO", ProvinciaId = 1},
                 new Localidad{Descripcion="MARIANO MORENO", ProvinciaId = 1},
                 new Localidad{Descripcion="MEDIA LUNA", ProvinciaId = 1},
                 new Localidad{Descripcion="NAUNAUCO", ProvinciaId = 1},
                 new Localidad{Descripcion="NEUQUEN - CAPITAL", ProvinciaId = 1},
                 new Localidad{Descripcion="ÑORQUIN", ProvinciaId = 1},
                 new Localidad{Descripcion="OCTAVIO PICO", ProvinciaId = 1},
                 new Localidad{Descripcion="PAMPA DEL MALLEO", ProvinciaId = 1},
                 new Localidad{Descripcion="PASO AGUERRE", ProvinciaId = 1},
                 new Localidad{Descripcion="PASO de los INDIOS", ProvinciaId = 1},
                 new Localidad{Descripcion="PICUN LEUFU", ProvinciaId = 1},
                 new Localidad{Descripcion="PIEDRA DEL AGUILA", ProvinciaId = 1},
                 new Localidad{Descripcion="Piedra del Agula FUERA DE RADIO", ProvinciaId = 1},
                 new Localidad{Descripcion="PILO LIL", ProvinciaId = 1},
                 new Localidad{Descripcion="Planicie Benderita", ProvinciaId = 1},
                 new Localidad{Descripcion="PLAZA HUINCUL CIUDAD", ProvinciaId = 1},
                 new Localidad{Descripcion="PLAZA HUINCUL YPF", ProvinciaId = 1},
                 new Localidad{Descripcion="PLOTTIER", ProvinciaId = 1},
                 new Localidad{Descripcion="PORTADA COVUNCO", ProvinciaId = 1},
                 new Localidad{Descripcion="puente PUCUN LEUFU", ProvinciaId = 1},
                 new Localidad{Descripcion="PULMARI", ProvinciaId = 1},
                 new Localidad{Descripcion="QUEMQUEMTREU", ProvinciaId = 1},
                 new Localidad{Descripcion="QUILA QUINA", ProvinciaId = 1},
                 new Localidad{Descripcion="QUILCA", ProvinciaId = 1},
                 new Localidad{Descripcion="QUILI MALAL", ProvinciaId = 1},
                 new Localidad{Descripcion="QUILLEN", ProvinciaId = 1},
                 new Localidad{Descripcion="QUINTUCO", ProvinciaId = 1},
                 new Localidad{Descripcion="RAMON CASTRO", ProvinciaId = 1},
                 new Localidad{Descripcion="RANQUILON", ProvinciaId = 1},
                 new Localidad{Descripcion="RDLS", ProvinciaId = 1},
                 new Localidad{Descripcion="RINCON CHICO", ProvinciaId = 1},
                 new Localidad{Descripcion="RUCA CHOROY", ProvinciaId = 1},
                 new Localidad{Descripcion="SAN IGNACIO", ProvinciaId = 1},
                 new Localidad{Descripcion="SAN MARTIN DE LOS ANDES", ProvinciaId = 1},
                 new Localidad{Descripcion="SANTO TOMAS", ProvinciaId = 1},
                 new Localidad{Descripcion="SAÑI CO", ProvinciaId = 1},
                 new Localidad{Descripcion="SAUZAL BONITO", ProvinciaId = 1},
                 new Localidad{Descripcion="SENILLOSA", ProvinciaId = 1},
                 new Localidad{Descripcion="TAQUIMILAN ABAJO", ProvinciaId = 1},
                 new Localidad{Descripcion="TAQUIMILAN ARRIBA", ProvinciaId = 1},
                 new Localidad{Descripcion="TIERRAS BLANCAS", ProvinciaId = 1},
                 new Localidad{Descripcion="TRALAITUE", ProvinciaId = 1},
                 new Localidad{Descripcion="TRES CHORROS", ProvinciaId = 1},
                 new Localidad{Descripcion="TRICAO MALAL", ProvinciaId = 1},
                 new Localidad{Descripcion="V LA ANGOSTURA fuera de radio", ProvinciaId = 1},
                 new Localidad{Descripcion="VACA MUERTA", ProvinciaId = 1},
                 new Localidad{Descripcion="VARVARCO", ProvinciaId = 1},
                 new Localidad{Descripcion="VEGA MAIPU", ProvinciaId = 1},
                 new Localidad{Descripcion="VILLA LA ANGOSTURA", ProvinciaId = 1},
                 new Localidad{Descripcion="VILLA PEHUENIA", ProvinciaId = 1},
                 new Localidad{Descripcion="VILLA TRAFUL", ProvinciaId = 1},
                 new Localidad{Descripcion="VILU MALLIN", ProvinciaId = 1},
                 new Localidad{Descripcion="VISTA ALEGRE", ProvinciaId = 1},
                 new Localidad{Descripcion="ZAINA YEGUA", ProvinciaId = 1},
                 new Localidad{Descripcion="ZAPALA", ProvinciaId = 1}

                };
                foreach (Localidad l in localidades)
                {
                    _db.Localidades.Add(l);
                }
                _db.SaveChanges();
                #endregion

            }
            catch (Exception ex)
            {

            }
        }
    }
}
