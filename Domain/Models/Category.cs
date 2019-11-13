using AutomationAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutomationAPI.Domain.Models
{
    public class Category
    {
        public Category(string catFolder) {
            List<TestSuite> lstTestSuite = new List<TestSuite>();
            DirectoryInfo d = new DirectoryInfo(catFolder);//Assuming Test is your Folder
            FileInfo[] FileTestSuites = d.GetFiles("*.xml"); //Getting Text files
            foreach (FileInfo ts in FileTestSuites)
            {
                TestSuite tempTS = new TestSuite(ts.Name);
                lstTestSuite.Add(tempTS);
            }

            Name = d.Name;
            TestSuites = lstTestSuite;
            //List<TestSuite> lstTestSuite = new List<TestSuite>();
            //foreach (string tsFile in Directory.GetFiles(catFolder))
            //{
            //    var tsFilenName = n;
            //    //TestSuite tempTS = new TestSuite(ts);
            //    //TestSuites.Add(tempTS);
            //}
        }
        public List<TestSuite> TestSuites { get; set; }
        public string Name { get; set; }
    }
}
