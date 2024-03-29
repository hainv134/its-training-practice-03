﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Entity;

namespace DatabaseLayer.Repository.Interface
{
    public interface ISubjectRepository
    {
        public IQueryable<Subject> GetAllDetails();
        public IQueryable<Subject> GetSubjectInClass(int classid);
    }
}
