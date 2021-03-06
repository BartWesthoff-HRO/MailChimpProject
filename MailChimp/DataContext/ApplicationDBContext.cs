﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MailChimp.Models;

namespace MailChimp.DataContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(): base(nameOrConnectionString:"Myconnection")
        {

        }

        public virtual DbSet<Employee> Empobj { get; set; }

        public System.Data.Entity.DbSet<MailChimp.Models.ContactPerson> ContactPersons { get; set; }

        public System.Data.Entity.DbSet<MailChimp.Models.labels> labels { get; set; }

        public System.Data.Entity.DbSet<MailChimp.Models.klant> klants { get; set; }
    }
}