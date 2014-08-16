using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseOfBurt.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace HouseOfBurt.Models
{
    public class DataService
    {
        static readonly DataService instance = new DataService();
        static DataContext database = new DataContext();

        DataService()
        {
            // Initialize.
        }

        public static DataService Instance
        {
            get
            {
                return instance;
            }
        }

        public DataContext Database
        {
            get
            {
                return database;
            }
        }
    }
}