using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PlayBox
{
    public class ProgramProperties
    {
        private PropertiesManager pm;

        private ProgramSettings settings;
        private ProgramSetup setup;

        public ProgramSettings Settings
        {
            get { return settings; }
            set { settings = value; }
        }
        public ProgramSetup Setup
        {
            get { return setup; }
            set { setup = value; }
        }

        public ProgramProperties()
        {
            pm = new PropertiesManager();
        }
    }
}
