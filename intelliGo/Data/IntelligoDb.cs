using intelliGo.Models;
using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intelliGo.Data
{
    public class IntelligoDb : DataConnection
    {
        public IntelligoDb() : base("Intelligo") 
        {
            //DefaultSettings = new MySettings();
        }

        public ITable<Survey> Survey => GetTable<Survey>();
    }
}
