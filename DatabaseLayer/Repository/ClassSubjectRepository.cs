﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Entity;
using DatabaseLayer.Repository.Interface;
using DatabaseLayer.Context;
namespace DatabaseLayer.Repository
{
    public class ClassSubjectRepository : GenericRepository<ClassSubject>, IClassSubjectRepository
    {
        private readonly DatabaseContext _dbContext;
        // parse dbcontext to base class -> use all method of base class 
        public ClassSubjectRepository(DatabaseContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
       public IQueryable<ClassSubject> GetSubjectInClass(int classId) => _dbContext.ClassSubjects.Where(cs => cs.ClassId == classId);
       public void DeleteSubjectInClass(int classid){
           _dbContext.ClassSubjects.RemoveRange(_dbContext.ClassSubjects.Where(cs => cs.ClassId == classid).ToArray());
       }
    }
}
