using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Processing.Test
{
    public class TestSituation
    {
        private string StatusNormal = "Параметры устройства";

        private string StatusBad = "";

        public List<string> TestSituationList = new List<string>()
        {
            {" в норме"}, {""}, {""}
        };

        public TestSituation(string nameParam, bool status)
        {

        }

        public string GetResponseStatusDevice()
        {
            string result = "";

            return result;
        }

    }
}
