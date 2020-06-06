using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ProgramParamList : Dictionary<string, ProgramParam>
    {
        public ProgramParamList()
        { }

        public void Add(string ParamName, string ParamDesc, double ParamVal)
        {
            Add(ParamName, new ProgramParam(ParamName, ParamDesc, ParamVal));
        }
          
        public void Add(ProgramParam pp)
        {
            Add(pp.ParamName, pp);
        }
    }
}
