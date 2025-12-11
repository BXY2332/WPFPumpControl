using Motor.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motor.Service
{
    public class DeviceService
    {
        public MotorViewModel Motor { get; } = new();

        public void DeviceConnection()
        {
            Motor.DeviceConnection = true;
        }

        public void DisConnection()
        {
            Motor.DeviceConnection = false;
        }

        public void DeviceState(DeviceState state)
        {
            Motor.DeviceState = state;
        }
    }
}
