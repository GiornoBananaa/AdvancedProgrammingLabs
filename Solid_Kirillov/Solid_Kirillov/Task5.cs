namespace Solid_Kirillov;

public class SmartHouseController
{
    public void ChangeVolume(ISoundMaker soundMaker, float volume)
    {
        soundMaker.ChangeVolume(volume);
    }
}

public interface ISoundMaker
{
    public void ChangeVolume(float volume);
}