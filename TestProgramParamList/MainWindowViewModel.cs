using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TestProgramParamList
{
    public class MainWindowViewModel: ViewModelBase
    {
        private ProgramParamList _pPL = new ProgramParamList();
        public ProgramParamList PPL { get => _pPL; set { Set(() => PPL, ref _pPL, value); }}


        private ObservableCollection<string> _copedTo = new ObservableCollection<string>(); 
        public ObservableCollection<string>  CopedTo { get => _copedTo; set { Set(() => CopedTo, ref _copedTo, value); }}


        private RelayCommand _copyToRightCmd;
        public RelayCommand CopyToRightCmd => _copyToRightCmd ?? (_copyToRightCmd = new RelayCommand(
            () => copyToRight(),
            () => { return 1 == 1; },
			keepTargetAlive:true
            ));

        private void copyToRight()
        {
            CopedTo.Clear();
            foreach (KeyValuePair<string, ProgramParam> kvp in PPL)
            { 
                CopedTo.Add($"Name: {kvp.Value.ParamName} Desc:{kvp.Value.ParamDesc} Value:{ kvp.Value.ParamVal}");
            }
        }

        public MainWindowViewModel()
        {
            loadSampleData();
        }
        
        private void loadSampleData()
         {   
            PPL.Add("S1", "Uno", 1.1);
            PPL.Add("S2", "Due", 2.2);
        }
    }
}
