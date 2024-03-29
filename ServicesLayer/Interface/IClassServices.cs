﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Entity;
using ServicesLayer.ViewModel;

namespace ServicesLayer.Interface
{
    public interface IClassServices
    {
        public List<ClassModel> GetAll();
        public List<ClassModel> GetAllDetail(); // for generate json file
        public int GetCounting();
        public ClassModel Get(int id);
        public Task Delete(int id);
        public Task DeleteRange(int[] id);
        public Task AddClass(ClassAddServicesModel _class);        
        public List<ClassDetailServicesModel> GetClassListDetail(string text, int skip, int take, int min, int max, string properties, out int recordFilterd);
        public List<ClassDetailServicesModel> GetClassMaxBoy();
        public ClassEditServicesModel GetClassEdit(int classId);
        public Task UpdateClass(ClassEditServicesModel servicesModel);
        public List<ClassModel> GetWithIDList(int[] idList);
    }
}
