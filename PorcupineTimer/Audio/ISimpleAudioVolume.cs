using System;
using System.Runtime.InteropServices;
// ReSharper disable SuspiciousTypeConversion.Global
// ReSharper disable InconsistentNaming

namespace PorcupineTimer.Audio
{

#region Abstracted COM interfaces from Windows CoreAudio API

    [Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ISimpleAudioVolume
    {
        [PreserveSig]
        int SetMasterVolume(float fLevel, ref Guid EventContext);

        [PreserveSig]
        int GetMasterVolume(out float pfLevel);

        [PreserveSig]
        int SetMute(bool bMute, ref Guid EventContext);

        [PreserveSig]
        int GetMute(out bool pbMute);
    }

    #endregion
}