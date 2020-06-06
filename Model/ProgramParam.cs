namespace Model
{
    public class ProgramParam
    {
        public string ParamName;
        public string ParamDesc;
        public double ParamVal;

        public ProgramParam()
        { }
        public ProgramParam(string ParamName, string ParamDesc, double ParamVal)
        {
            this.ParamName = ParamName;
            this.ParamDesc = ParamDesc;
            this.ParamVal = ParamVal;
        }
    }
}
