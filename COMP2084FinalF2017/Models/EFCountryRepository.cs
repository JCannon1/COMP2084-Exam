using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//namespace COMP2084FinalF2017.Models
//{



//    public class EFCountryRepository : ICountryRepository
//    {
//        // Repository for CRUD with Teams in SQL Server db

//        // db connection
//        OlympicModel db = new OlympicModel();

//        public IQueryable<OlympicModel> Country { get { return db.OlympicModel;  } }

//        public IQueryable<OlympicModel> Gold { get { return db.OlympicModel; } }

//        public IQueryable<OlympicModel> Silver { get { return db.OlympicModel; } }

//        public IQueryable<OlympicModel> Bronze { get { return db.OlympicModel; } }

//        public IQueryable<OlympicModel> TotalMedals { get { return db.OlympicModel; } }
        
//        public IQueryable<OlympicModel> Flag { get { return db.OlympicModel; } }

//            public void Delete(OlympicModel Country)
//            {
//            db.OlympicModel.Remove(Country);
//            db.SaveChanges();
//            }

//            public OlympicModel Save(OlympicModel Counrty)
//            {
//            if (Country.countryId == "0")
//            {
//            db.OlympicModel.Add(Country);
//            }
//            else
//            {
//            db.Entry(Country).State = System.Data.Entity.EntityState.Modified;
//            }

//            db.SaveChanges();
//            return Counrty;
//            }
//     }

