namespace Solid_Kirillov;

public class SmartHouseController
{
    private List<ISoundMaker> _soundMakers;

    public SmartHouseController()
    {
        _soundMakers = new List<ISoundMaker>();
    }
    
    public SmartHouseController(IEnumerable<IDevice> devices)
    {
        _soundMakers = new List<ISoundMaker>();

        foreach (var device in devices)
        {
            AddDevice(device);
        }
    }
    
    public void AddDevice(IDevice device)
    {
        if(device is ISoundMaker soundMaker)
            _soundMakers.Add(soundMaker);
    }
    
    public void MuteAllSounds(bool mute)
    {
        foreach (var soundMaker in _soundMakers)
        {
            soundMaker.MuteSound(mute);
        }
    }
}

public interface IDevice
{
    public bool IsOn { get; }
    public void TurnOn(bool enabled);
}

public interface ISoundMaker: IDevice
{
    public void ChangeVolume(float volume);
    public void MuteSound(bool muted);
}

public interface ISecurityDevice: IDevice
{
    public bool SecurityProtocolIsActive { get; }
    public void ActivateSecurityProtocol();
    public void StopSecurityProtocol();
}

public class SteelSlidingPanels: ISecurityDevice
{
    private bool _isEnabled;
    private bool _securityProtocolIsActive;
    
    public bool IsOn => _isEnabled;
    public bool SecurityProtocolIsActive => _securityProtocolIsActive;
    
    public void TurnOn(bool enabled)
    {
        _isEnabled = enabled;
        Console.WriteLine("Система стальных панелей: " + (enabled?"включение":"выключение"));
    }

    public void ActivateSecurityProtocol()
    {
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

public class YandexStation: ISoundMaker
{
    private float _volume;
    private bool _isMuted;
    private bool _isEnabled;

    public bool IsOn => _isEnabled;
    
    public void TurnOn(bool enabled)
    {
        _isEnabled = enabled;
        Console.WriteLine("Яндекс станция: " + (enabled?"включение":"выключение"));
    }
    
    public void ChangeVolume(float volume)
    {
        _volume = volume;
        Console.WriteLine($"Яндекс станция: громкость изменена на {volume}");
    }

    public void MuteSound(bool muted)
    {
        _isMuted = muted;
        Console.WriteLine("Яндекс станция: звук" + (muted?"включен":"выключен"));
    }
}

public class TV: ISoundMaker
{
    private float _volume;
    private bool _isMuted;
    private bool _isEnabled;
    
    public bool IsOn => _isEnabled;
    
    public void TurnOn(bool enabled)
    {
        _isEnabled = enabled;
        Console.WriteLine("TV: " + (enabled?"включение":"выключение"));
    }

    public void ChangeVolume(float volume)
    {
        _volume = volume;
        Console.WriteLine($"TV: громкость изменена на {volume}");
    }
    public void MuteSound(bool muted)
    {
        _isMuted = muted;
        Console.WriteLine("TV: звук" + (muted?"включен":"выключен"));
    }
}