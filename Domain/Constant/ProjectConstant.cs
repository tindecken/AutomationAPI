using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutomationAPI.Domain.Constant
{
    public class ProjectConstant
    {
        public static string sProjectFolder = "";
        public static string sProjectName = "AutomationAPI";
        public static string sProjectTestFolder = Path.Combine(sProjectFolder, "Test");
        public static string sTestPlanFolder = Path.Combine(sProjectTestFolder, "TestPlan");
    }
}
