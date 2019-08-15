using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace informaionUDB.Data.Model
{
    public static class ModelBuilderExtensions
    {

        public static  void Seed( this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docktor>().HasData(
                 new Docktor
                 {
                     Id = 10,
                     Name = "Khaled",
                     Lastname = "IBRAHIMO",
                 }

                );
        }
    }
}
