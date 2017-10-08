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
            p.Name = "Veli";
            p.Lastname = "Filiz";
            int result = Service.InsertCommand(p);
            Debug.WriteLine(result);
        }

    }
}
