namespace PorcupineTimer.Audio
{
    public interface IAudioManager
    {
        bool? GetApplicationMute(int pid);
        float? GetApplicationVolume(int pid);
        float GetMasterVolume();
        bool GetMasterVolumeMute();
        void SetApplicationMute(int pid, bool mute);
        void SetApplicationVolume(int pid, float level);
        void SetMasterVolume(float newLevel);
        void SetMasterVolumeMute(bool isMuted);
        float StepMasterVolume(float stepAmount);
        bool ToggleMasterVolumeMute();
    }
}