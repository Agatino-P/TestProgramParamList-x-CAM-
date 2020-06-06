using GalaSoft.MvvmLight;
using Model;

namespace ProgramParamListHelper
{
    public class ProgramParamViewModel : ViewModelBase
    {
        private ProgramParam _programParam;
        public ProgramParamViewModel(ProgramParam programParam)
        {
            _programParam = programParam;
        }

        public string ParamName
        {
            get => _programParam.ParamName;
            set
            {
                if (_programParam.ParamName != value)
                {
                    _programParam.ParamName = value;
                    RaisePropertyChanged(nameof(ParamName));
                }
            }
        }

        
        public string ParamDesc
        {
            get => _programParam.ParamDesc;
            set
            {
                if (_programParam.ParamDesc != value)
                {
                    _programParam.ParamDesc = value;
                    RaisePropertyChanged(nameof(ParamDesc));
                }
            }
        }
        
        
        public double ParamVal
        {
            get => _programParam.ParamVal;
            set
            {
                if (_programParam.ParamVal != value)
                {
                    _programParam.ParamVal = value;
                    RaisePropertyChanged(nameof(ParamVal));
                }
            }
        }

    }
}
