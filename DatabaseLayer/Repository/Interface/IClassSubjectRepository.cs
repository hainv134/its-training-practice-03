﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Entity;
namespace DatabaseLayer.Repository.Interface
{
    public interface IClassSubjectRepository
    {
        public void DeleteSubjectInClass(int classid);
    }
}
