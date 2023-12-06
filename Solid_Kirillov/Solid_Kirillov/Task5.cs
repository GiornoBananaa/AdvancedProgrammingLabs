namespace Solid_Kirillov;

public class SmartHouseController
{
    private List<IDevice> _devices;

    public SmartHouseController()
    {
        _devices = new List<IDevice>();
    }
    
    public SmartHouseController(List<IDevice> devices)
    {
        _devices = devices;
    }
    
    public void AddDevice(IDevice device)
    {
        _devices.Add(device);
    }

    public void TurnAllDevices(bool on)
    {
        foreach (var device in _devices)
        {
            device.TurnDeviceOn(on);
        }
    }
    
    public void MuteAllSounds(bool mute)
    {
        foreach (var device in _devices)
        {
            if(device is ISoundDevice soundDevice)
                soundDevice.MuteSound(mute);
        }
    }
    
    public void ChangeLightsBrightness(float brightness)
    {
        foreach (var device in _devices)
        {
            if(device is ILightDevice lightDevice)
                lightDevice.ChangeLightBrightness(brightness);
        }
    }
    
    public void ChangeLightsColor(string color)
    {
        foreach (var device in _devices)
        {
            if(device is ILightDevice lightDevice)
                lightDevice.ChangeLightColor(color);
        }
    }
    
    public void ActivateSecurityProtocol()
    {
        foreach (var device in _devices)
        {
            if(device is ISecurityDevice securityDevice)
                securityDevice.ActivateSecurityProtocol();
        }
    }
    
    public void StopSecurityProtocol()
    {
        foreach (var device in _devices)
        {
            if(device is ISecurityDevice securityDevice)
                securityDevice.StopSecurityProtocol();
        }
    }
}

public interface IDevice
{
    public void TurnDeviceOn(bool enabled);
}

public interface ISoundDevice: IDevice
{
    public void ChangeVolume(float volume);
    public void MuteSound(bool muted);
}

public interface ISecurityDevice: IDevice
{
    public void ActivateSecurityProtocol();
    public void StopSecurityProtocol();
}

public interface ILightDevice: IDevice
{
    public void ChangeLightBrightness(float brightness);
    public void ChangeLightColor(string color);
}

public class Lamp : ILightDevice
{
    private bool _isEnabled;
    private float _lightBrightness;
    private string _color;

    public Lamp(string color, float lightBrightness)
    {
        _color = color;
        _lightBrightness = lightBrightness;
    }

    public void TurnDeviceOn(bool enabled)
    {
        if (_isEnabled == enabled) return;
        
        _isEnabled = enabled;
        Console.WriteLine("Лампа: " + (enabled?"включение":"выключение"));
    }

    public void ChangeLightBrightness(float brightness)
    {
        if (_lightBrightness == brightness) return;
        
        _lightBrightness = brightness;
        Console.WriteLine($"Лампа: яркость света изменена на {brightness}");
    }

    public void ChangeLightColor(string color)
    {
        if (_color == color) return;
        
        _color = color;
        Console.WriteLine($"Лампа: цвет света изменен на {color}");
    }
}

public class SteelSlidingPanels: ISecurityDevice
{
    private bool _isEnabled;
    private bool _securityProtocolIsActive;
    
    
    public void TurnDeviceOn(bool enabled)
    {
        if (_isEnabled == enabled) return;
        
        _isEnabled = enabled;
        Console.WriteLine("Система стальных панелей: " + (enabled?"включение":"выключение"));
    }

    public void ActivateSecurityProtocol()
    {
        if (_securityProtocolIsActive) return;
        _securityProtocolIsActive = true;
        
        Console.WriteLine("Система стальных панелей: окна и двери закрыты панелями");
    }

    public void StopSecurityProtocol()
    {
        if (!_securityProtocolIsActive) return;
        
        _securityProtocolIsActive = false;
        Console.WriteLine("Система стальных панелей: панели убраны");
    }
}

public class YandexStation: ISoundDevice
{
    private float _volume;
    private bool _isMuted;
    private bool _isEnabled;
    
    
    public void TurnDeviceOn(bool enabled)
    {
        if (_isEnabled == enabled) return;
        
        _isEnabled = enabled;
        Console.WriteLine("Яндекс станция: " + (enabled?"включение":"выключение"));
    }
    
    public void ChangeVolume(float volume)
    {
        if (_volume == volume) return;
        
        _volume = volume;
        Console.WriteLine($"Яндекс станция: громкость изменена на {volume}");
    }

    public void MuteSound(bool muted)
    {
        if (_isMuted == muted) return;
        
        _isMuted = muted;
        Console.WriteLine("Яндекс станция: звук" + (muted?"включен":"выключен"));
    }
}

public class TV: ISoundDevice
{
    private float _volume;
    private bool _isMuted;
    private bool _isEnabled;
    
    
    public void TurnDeviceOn(bool enabled)
    {
        if (_isEnabled == enabled) return;
        
        _isEnabled = enabled;
        Console.WriteLine("TV: " + (enabled?"включение":"выключение"));
    }

    public void ChangeVolume(float volume)
    {
        if (_volume == volume) return;
        
        _volume = volume;
        Console.WriteLine($"TV: громкость изменена на {volume}");
    }
    public void MuteSound(bool muted)
    {
        if (_isMuted == muted) return;
        
        _isMuted = muted;
        Console.WriteLine("TV: звук" + (muted?"включен":"выключен"));
    }
}