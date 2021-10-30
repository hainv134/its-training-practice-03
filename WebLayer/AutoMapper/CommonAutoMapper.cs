﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DatabaseLayer.Entity;
using WebLayer.EditModel.Class;
using WebLayer.ViewModel.Subject;
using WebLayer.EditModel.Subject;
using WebLayer.ViewModel.Student;
using WebLayer.EditModel.Student;
using ServicesLayer.ViewModel;

namespace WebLayer.AutoMapper
{
    public class CommonAutoMapper : Profile
    {
        public CommonAutoMapper()
        {
            // ---------------- Class -----------///
            CreateMap<EditModel.Class.AddEditModel, ClassModel>();
            CreateMap<ClassModel, EditModel.Class.AddEditModel>(); // --
            CreateMap<ClassEditServicesModel, EditModel.Class.EditEditModel>();
            CreateMap<EditModel.Class.EditEditModel, ClassEditServicesModel>();
            CreateMap<AddSubjectEditModel, ClassAddSubjectServicesModel>();
            // Subject
            CreateMap<Subject, ViewModel.Subject.IndexViewModel>();
            CreateMap<EditModel.Subject.AddEditModel, Subject>();                        
            // Student //
            CreateMap<EditModel.Student.AddEditModel, StudentAddServicesModel>(); // services
            CreateMap<StudentEditServicesModel, EditModel.Student.EditEditModel>();
            CreateMap<EditModel.Student.EditEditModel, StudentEditServicesModel>();
            CreateMap<StudentDetailServicesModel, ViewModel.Student.DetailViewModel>();
            CreateMap<StudentOldServicesModel, OldViewModel>();
        }
    }
}
