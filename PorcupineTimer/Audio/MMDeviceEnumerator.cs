using System;
using System.Runtime.InteropServices;
// ReSharper disable SuspiciousTypeConversion.Global
// ReSharper disable InconsistentNaming

namespace PorcupineTimer.Audio
{

    #region Abstracted COM interfaces from Windows CoreAudio API

    [ComImport]
    [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
    internal class MMDeviceEnumerator
    {
    }

    #endregion
}