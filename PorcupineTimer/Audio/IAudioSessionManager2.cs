using System;
using System.Runtime.InteropServices;
// ReSharper disable SuspiciousTypeConversion.Global
// ReSharper disable InconsistentNaming

namespace PorcupineTimer.Audio
{

#region Abstracted COM interfaces from Windows CoreAudio API

    [Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionManager2
    {
        int NotImpl1();
        int NotImpl2();

        [PreserveSig]
        int GetSessionEnumerator(out IAudioSessionEnumerator SessionEnum);

        // the rest is not implemented
    }

    #endregion
}