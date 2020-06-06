using GalaSoft.MvvmLight;
using Model;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ProgramParamListHelper
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ProgramParamListView : UserControl
    {
        public ProgramParamList PPL
        {
            get => (ProgramParamList)GetValue(PPLProperty);
            set => SetValue(PPLProperty, value);
        }
        public static readonly DependencyProperty PPLProperty =
            DependencyProperty.Register("PPL", typeof(ProgramParamList), typeof(ProgramParamListView), new FrameworkPropertyMetadata(onPPLPropertyChanged));

        private static void onPPLPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is ProgramParamListView programParamListView) || !(e.NewValue is ProgramParamList programParamList))
            { return; }

            if (programParamListView.PPVMs == null)
            {
                programParamListView.PPVMs = new ObservableCollection<ProgramParamViewModel>();
            }

            programParamListView.PPVMs.Clear();
            if (programParamList?.Values.Count > 0)
            {
                foreach (ProgramParam pp in programParamList.Values)
                {
                    programParamListView.PPVMs.Add(new ProgramParamViewModel(pp));
                }
            }
        }



        public ObservableCollection<ProgramParamViewModel> PPVMs
        {
            get => (ObservableCollection<ProgramParamViewModel>)GetValue(PPVMsProperty);
            set => SetValue(PPVMsProperty, value);
        }
        public static readonly DependencyProperty PPVMsProperty =
            DependencyProperty.Register("PPVMs", typeof(ObservableCollection<ProgramParamViewModel>), typeof(ProgramParamListView), new PropertyMetadata(null));

        public ProgramParamListView()
        {
            PPL = new ProgramParamList();
            PPVMs = new ObservableCollection<ProgramParamViewModel>();

            InitializeComponent();
            if (ViewModelBase.IsInDesignModeStatic)
            {
                loadSampleData();
            }
        }

        private void loadSampleData()
        {
            PPL.Add("S1", "Uno", 1.1);
            PPL.Add("S2", "Due", 2.2);
        }

    }
}
