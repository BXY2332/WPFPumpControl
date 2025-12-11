using Motor.Command;
using Motor.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Motor.ViewModel
{
    public class MainWindowViewModel
    {
        public readonly DeviceService _service;
        public MotorViewModel Motor => _service.Motor;

        public ICommand ConnectionCmd { get; }
        public ICommand DisConnectionCmd {  get; }
        public ICommand RunningCmd {  get; }
        public ICommand StandbyCmd { get; }
        public ICommand FaultCmd { get; }

        public MainWindowViewModel()
        {
            _service = new DeviceService();

            ConnectionCmd = new RelayCommand(_ => _service.DeviceConnection());
            DisConnectionCmd = new RelayCommand(_ => _service.DisConnection());

            RunningCmd = new RelayCommand(_ => _service.DeviceState(DeviceState.Running));
            StandbyCmd = new RelayCommand(_ => _service.DeviceState(DeviceState.Standby));
            FaultCmd = new RelayCommand(_ => _service.DeviceState(DeviceState.Fault));
        }
    }
}
