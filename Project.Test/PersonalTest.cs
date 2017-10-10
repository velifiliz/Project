using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain = Project.Domain;

namespace Project.Test
{
    [TestClass]
    public class PersonalTest
    {
        Domain.PersonalDataService Service = new Domain.PersonalDataService();

        [TestMethod]
        public void Insert()
        {
            Domain.Personal p = new Domain.Personal();
            p.Name = "Deneme";
            p.Lastname = "Test";
            int result = Service.InsertCommand(p);
            Debug.WriteLine(result);
        }

        [TestMethod]
        public void InsertScalar()
        {
            Domain.Personal p = new Domain.Personal();
            p.Name = "Scalarxx";
            p.Lastname = "Denemexx";
            int result = Service.InsertCommandScalar(p);
            Debug.WriteLine(result);
        }

        [TestMethod]
        public void GetData()
        { 
            var result = Service.PersonalGetData();
            Debug.WriteLine(result.Name);
        }

        [TestMethod]
        public void GetDataList()
        {
            var result = Service.PersonalGetDataList();
            foreach (var item in result)
            {
                Debug.WriteLine(item.Name);
            }
        }

        [TestMethod]
        public void FastInsert()
        {
            Domain.Personal p = new Domain.Personal();
            p.Name = "Test";
            p.Lastname = "FastCrud";
            var result = Service.FastInsert(p);
            Debug.WriteLine(result);
        }
    }
}
