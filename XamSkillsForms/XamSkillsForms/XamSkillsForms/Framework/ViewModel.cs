using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamSkillsForms.Framework
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        protected virtual void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return;
            }

            field = value;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}