using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class ApplicationLanguage
    {
        private static ApplicationLanguage instance = null;

        private string key;
        private string value;

        private ApplicationLanguage() { }

        public static ApplicationLanguage Instance
        {
            get

            {
                if(instance == null)
                {
                    instance = new ApplicationLanguage();
                }
                return instance;
            }
        }

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public string Value
        {
            get { return value; }
            set
            {
                value = value.Trim();
            }
        }



    }
}
