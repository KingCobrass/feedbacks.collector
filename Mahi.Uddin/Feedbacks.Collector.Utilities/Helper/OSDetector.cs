using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Feedbacks.Collector.Utilities.Helper
{
    public class OSDetector
    {
        public static bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public static bool IsMacOS() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        public static bool IsLinux() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    }
}
