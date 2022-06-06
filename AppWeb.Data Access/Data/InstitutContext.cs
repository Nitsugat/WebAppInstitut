using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppWeb.Data_Access.Model;

namespace AppWeb.Data_Access.Data
{
    internal class InstitutContext: DbContext
    {
        public InstitutContext(DbContextOptions<InstitutContext> options) 
            :base(options)
        {



        }

        //DbSet establece la relacion entre la tabla de la DB y el modelo utilizado en mi programa
        public DbSet<Student>? Students { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Location>? Locations { get; set; }
        public DbSet<Province>? Provinces { get; set; }
        public DbSet<Professor>? Professors { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
        public DbSet<ProfessorBySubject>? ProfessorBySubject  { get; set; }
        public DbSet<StudentsBySubject>? StudentsBySubject { get; set; }
        public DbSet<Resolution>? Resolution { get; set; }
        public DbSet<TypeSubject>? TypeSubject { get; set; }
        public DbSet<Cursado>? Cursado { get; set; }
        public DbSet<Course>? Course { get; set; }









    }
}
