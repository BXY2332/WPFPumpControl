using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Motor.ViewModel
{
    public enum DeviceState
    {
        Running,
        Standby,
        Fault
    }
    public class MotorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void Raise([CallerMemberName] string? p = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));

        private string _deviceName = "水泵";
        public string DeviceName
        {
            get => _deviceName;
            set{ _deviceName = value;Raise(); }
        }

        private bool _deviceConnection;
        public bool DeviceConnection
        {
            get => _deviceConnection;
            set { _deviceConnection = value; Raise(); }
        }

        private DeviceState _deviceState = DeviceState.Standby;
        public DeviceState DeviceState
        {
            get => _deviceState;
            set { _deviceState = value; Raise(); }
        }
    }
}
