namespace Solid_Kirillov;

public class SmartHouseController
{
    public void TurnOffAllSounds(float volume)
    {
        
    }
}

public interface ISoundMaker
{
    
    public void ChangeVolume(float volume);
    public void MuteSound(bool muted);
}

public class YandexStation: ISoundMaker
{
    private float _volume;
    private bool _isMuted;
    
    public void ChangeVolume(float volume)
    {
        _volume = volume;
    }

    public void MuteSound(bool muted)
    {
        _isMuted = muted;
    }
}

public class TV: ISoundMaker
{
    private float _volume;
    private bool _isMuted;
    
    public void ChangeVolume(float volume)
    {
        _volume = volume;
    }
    public void MuteSound(bool muted)
    {
        _isMuted = muted;
    }
}