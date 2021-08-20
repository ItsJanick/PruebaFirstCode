

using PruebaFisrtCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaFisrtCode.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BankContext context)
        {
            context.Database.EnsureCreated();

            // Look for any clients.
            if (context.Clients.Any())
            {
                return;   // DB has been seeded
            }

            var clients = new Clients[]
            {
            new Clients{Name="Carson",LastName="Alexanders",IdentificationCard="117",Birthdate=DateTime.Parse("2005-09-01")},
            new Clients{Name="Meredith",LastName="Alonso",IdentificationCard="118",Birthdate=DateTime.Parse("2002-09-01")},
            new Clients{Name="Arturo",LastName="Anand",IdentificationCard="119",Birthdate=DateTime.Parse("2003-09-01")},
            new Clients{Name="Gytis",LastName="Barzdukas",IdentificationCard="120",Birthdate=DateTime.Parse("2002-09-01")},
            new Clients{Name="Yan",LastName="Li",IdentificationCard="121",Birthdate=DateTime.Parse("2002-09-01")},
            new Clients{Name="Peggy",LastName="Justice",IdentificationCard="122",Birthdate=DateTime.Parse("2001-09-01")},
            new Clients{Name="Laura",LastName="Norman",IdentificationCard="123",Birthdate=DateTime.Parse("2003-09-01")},
            new Clients{Name="Nino",LastName="Olivetto",IdentificationCard="124",Birthdate=DateTime.Parse("2005-09-01")}
            };
            foreach (Clients s in clients)
            {
                context.Clients.Add(s);
            }
            context.SaveChanges();

            var bills = new Bills[]
            {
            new Bills{Balance=1050,Alias="Chemistry",AccountNumber="31"},
            new Bills{Balance=4022,Alias="Microeconomics",AccountNumber="32"},
            new Bills{Balance=4041,Alias="Macroeconomics",AccountNumber="33"},
            new Bills{Balance=1045,Alias="Calculus",AccountNumber="41"},
            new Bills{Balance=3141,Alias="Trigonometry",AccountNumber="42"},
            new Bills{Balance=2021,Alias="Composition",AccountNumber="34"},
            new Bills{Balance=2042,Alias="Literature",AccountNumber="43"}
            };
            foreach (Bills c in bills)
            {
                context.Bills.Add(c);
            }
            context.SaveChanges();

            var user = new Users[]
            {
            new Users{IdentificationCard="117", Password="ka1212"},
            new Users{IdentificationCard="118", Password="lslsjk"},
            new Users{IdentificationCard="120", Password="aaam12"}
            };
            foreach (Users c in user)
            {
                context.Users.Add(c);
            }
            context.SaveChanges();
        }
    }
}