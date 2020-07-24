using System.Runtime.InteropServices;
using static Nvd.SubProcess.Native.Libraries;

namespace Nvd.SubProcess.Native
{
    internal static unsafe partial class Libc
    {
        [DllImport(libc, SetLastError = true)]
        internal extern static int ioctl(int fd, long request, ref winsize WinSz);

        [DllImport(libc, SetLastError = true)]
        internal extern static int ioctl(int fd, long request, ref long size);

        [DllImport(libc, SetLastError = true)]
        internal static extern int ioctl(int fd, long request);

        [DllImport(libc, SetLastError = true)]
        internal static extern int ioctl(int fd, long request, long arg);

        [DllImport(libc, SetLastError = true)]
        internal static extern int ioctl(int fd, long request, void* arg);
    }
}
