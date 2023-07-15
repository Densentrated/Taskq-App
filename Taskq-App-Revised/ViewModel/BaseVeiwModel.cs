using System.ComponentModel;

namespace Taskq_App_Revised.ViewModel;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
}