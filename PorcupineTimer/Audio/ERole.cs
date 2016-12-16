using System;
using System.Runtime.InteropServices;
// ReSharper disable SuspiciousTypeConversion.Global
// ReSharper disable InconsistentNaming

namespace PorcupineTimer.Audio
{

#region Abstracted COM interfaces from Windows CoreAudio API

    internal enum ERole
    {
        eConsole,
        eMultimedia,
        eCommunications,
        ERole_enum_count
    }

    #endregion
}