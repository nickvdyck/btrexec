using System.Runtime.InteropServices;
using static BtrExec.Native.Libraries;

namespace BtrExec.Native
{
    internal static unsafe partial class Libc
    {
        internal static int STDIN_FILENO => 0;
        internal static int STDOUT_FILENO => 1;
        internal static int STDERR_FILENO => 2;

        [DllImport(libc, SetLastError = true)]
        internal static extern int fork();

        [DllImport(libc, SetLastError = true)]
        internal static extern unsafe int execve(string filename, byte** argv, byte** envp);


        internal static int SEEK_SET => 0;
        internal static int SEEK_CUR => 1;
        internal static int SEEK_END => 2;

        [DllImport(libc, SetLastError = true)]
        internal static extern off_t lseek(int fd, off_t offset, int whence);
        [DllImport(libc, SetLastError = true)]
        internal static extern int ftruncate(int fd, off_t length);


        [DllImport(libc, SetLastError = true)]
        internal static extern int pipe(int[] pipefd);
        [DllImport(libc, SetLastError = true)]
        internal static extern int pipe2(int[] pipefd, int flags);
        [DllImport(libc, SetLastError = true)]
        internal static extern int close(int fd);
        [DllImport(libc, SetLastError = true)]
        internal static extern int dup(int oldfd);
        [DllImport(libc, SetLastError = true)]
        internal static extern int dup2(int oldfd, int newfd);
        [DllImport(libc, SetLastError = true)]
        internal static extern int dup3(int oldfd, int newfd, int flags);

        [DllImport(libc, SetLastError = true)]
        internal static extern long read(int fd, void* buf, uint count);
        [DllImport(libc, SetLastError = true)]
        internal static extern long write(int fd, void* buf, uint count);

        [DllImport(libc, SetLastError = true)]
        internal static extern int chdir(string path);

        internal const int F_OK = 0;
        internal const int R_OK = 4;
        internal const int W_OK = 2;
        internal const int X_OK = 1;

        [DllImport(libc, SetLastError = true)]
        internal static extern int access(string pathname, int mode);

        [DllImport(libc)]
        internal static extern uid_t getuid();
        [DllImport(libc)]
        internal static extern uid_t geteuid();
        [DllImport(libc)]
        internal static extern gid_t getgid();


        [DllImport(libc)]
        public static extern pid_t getpgrp();
        [DllImport(libc, SetLastError = true)]
        public static extern pid_t getpgid(pid_t pid);


        [DllImport(libc, SetLastError = true)]
        internal static extern pid_t setsid();

        [DllImport(libc, SetLastError = true)]
        internal static extern pid_t setpgrp();

        [DllImport(libc, SetLastError = true)]
        internal static extern int setpgid(pid_t pid, pid_t pgid);

        [DllImport(libc)]
        public static extern void _exit(int status);
    }
}
