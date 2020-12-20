using System;

namespace ArduinoOBSReceiver
{
    public interface IConnectionMethod : IDisposable
    {
        bool IsConnected { get; }

        ConnectionMethods Method { get; }
        void Initialize(params object[] parameters);
        void Connect();
        void Disconnect();
        string ReceiveData();
    }

    public enum ConnectionMethods
    {
        Serial,
        WiFi
    }
}