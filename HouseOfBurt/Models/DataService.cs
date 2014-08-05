using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseOfBurt.Models;

namespace HouseOfBurt.Models
{
    public class DataService
    {

        static DataContextContainer contextRef = new DataContextContainer();
        static readonly DataService instance = new DataService();

        DataService()
        {
            // Initialize.
        }

        public DataContextContainer Database
        {
            get
            {
                return contextRef;
            }
        }

        public static DataService Instance
        {
            get
            {
                return instance;
            }
        }

    }
}