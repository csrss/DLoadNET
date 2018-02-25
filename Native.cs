
namespace NativeHelperFunctions {
    using System;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using System.IO;
    [
    System.Runtime.InteropServices.ComVisible(false),
    System.Security.SuppressUnmanagedCodeSecurityAttribute()
    ]

    #pragma warning disable 0169 // disable this stupid warning that 'value never used'

    public class Native { // Native functions wrapped into single class

        public const int NtCurrentProcess = -1;
        public const int NtCurrentThread = -2;
        public const long NT_SUCCESS = 0x00000000L;
        public const int STATUS_SUCCESS = 0;
        public const long STATUS_FAILURE = 0x00000001L;
        public const long STATUS_PRIVILEGES_NOT_SET = 0x00000002L;
        public const long STATUS_INITUNISTRING_FAILURE = 0x00000003L;
        public const int SystemLoadAndCallImage = 38;
        public const long STATUS_INFO_LENGTH_MISMATCH = 0xC0000004L;
        public const int PROCESS_PARAMETERS_NORMALIZED = 1;
        public readonly static IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
        public const int STANDARD_RIGHTS_REQUIRED = 0x000F0000;
        public const int SC_MANAGER_CONNECT = 0x0001;
        public const int SC_MANAGER_CREATE_SERVICE = 0x0002;
        public const int SC_MANAGER_ENUMERATE_SERVICE = 0x0004;
        public const int SC_MANAGER_LOCK = 0x0008;
        public const int SC_MANAGER_QUERY_LOCK_STATUS = 0x0010;
        public const int SC_MANAGER_MODIFY_BOOT_CONFIG = 0x0020;
        public const int SC_MANAGER_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED |
                                                  SC_MANAGER_CONNECT |
                                                  SC_MANAGER_CREATE_SERVICE |
                                                  SC_MANAGER_ENUMERATE_SERVICE |
                                                  SC_MANAGER_LOCK |
                                                  SC_MANAGER_QUERY_LOCK_STATUS |
                                                  SC_MANAGER_MODIFY_BOOT_CONFIG;

        public const int SERVICE_QUERY_CONFIG = 0x0001;
        public const int SERVICE_CHANGE_CONFIG = 0x0002;
        public const int SERVICE_QUERY_STATUS = 0x0004;
        public const int SERVICE_ENUMERATE_DEPENDENTS = 0x0008;
        public const int SERVICE_START = 0x0010;
        public const int SERVICE_STOP = 0x0020;
        public const int SERVICE_PAUSE_CONTINUE = 0x0040;
        public const int SERVICE_INTERROGATE = 0x0080;
        public const int SERVICE_USER_DEFINED_CONTROL = 0x0100;
        public const int SERVICE_CONTROL_STOP = 0x00000001;


        public const int SERVICE_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED |
                                               SERVICE_QUERY_CONFIG |
                                               SERVICE_CHANGE_CONFIG |
                                               SERVICE_QUERY_STATUS |
                                               SERVICE_ENUMERATE_DEPENDENTS |
                                               SERVICE_START |
                                               SERVICE_STOP |
                                               SERVICE_PAUSE_CONTINUE |
                                               SERVICE_INTERROGATE |
                                               SERVICE_USER_DEFINED_CONTROL;


        public const int SERVICE_DEMAND_START = 0x00000003;
        public const int SERVICE_KERNEL_DRIVER = 0x00000001;
        public const int SERVICE_ERROR_NORMAL = 0x00000001;
        public const int SERVICE_ERROR_IGNORE = 0x00000000;
        public const int TH32CS_SNAPPROCESS = 0x00000002;
        public const uint PROCESS_ALL_ACCESS = 0x000F0000 | 0x00100000 | 0xFFF;
        public const int MEM_COMMIT = 0x1000; 
        public const int MEM_RESERVE = 0x2000;
        public const int PAGE_EXECUTE_READWRITE = 0x40;

        public const int ZWLOADMODE = 10;
        public const int NTLOADMODE = 20;
        public const int SMLOADMODE = 30;
        public const int RTL_MODE = 555;
        public const int CRT_MODE = 666;
        public const int NT_MODE = 777;

        public const int NO_PROC = 111;
        public const int NO_DLLS = 112;
        public const int MAIN_FUNCTIONS_FAILED = 113;
        public const int ZW_SET_SYSTEM_INFO_FAILED = 114;
        public const int FOR_NT_FUNCTIONS_FAILED = 115;
        public const int FOR_SCM_FUNCTIONS_FAILED = 116;

        public const int GENERIC_WRITE = 0x40000000;
        public const int CREATE_ALWAYS = 2;
        public const int FILE_ATTRIBUTE_NORMAL = 128;
        public const uint GENERIC_READ = 0x80000000;
        public const int GENERIC_ALL = 0x10000000;
        public const int CREATE_NEW = 1;
        public const int OPEN_EXISTING = 3;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct CLIENT_ID
        {
            int UniqueProcess;
            int UniqueThread;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct UNICODE_STRING
        {
            public ushort Length;
            public ushort MaximumLength;
            public string Buffer;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public  struct SYSTEM_LOAD_AND_CALL_IMAGE
        {
            public UNICODE_STRING ModuleName;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct IO_STATUS_BLOCK
        {
	        long	Status;
	        ulong	uInformation;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct CURDIR
        {
            UNICODE_STRING	DosPath;
            int			    Handle;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct RTL_DRIVE_LETTER_CURDIR
        {
	        ushort	Flags;
	        ushort	Length;
	        ulong	TimeStamp;
	        String	DosPath;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct PROCESS_PARAMETERS
        {
            ulong					MaximumLength;
            ulong					Length;
            ulong					Flags;				// PROCESS_PARAMETERS_NORMALIZED
            ulong					DebugFlags;
            int					    ConsoleHandle;
            ulong					ConsoleFlags;
            int					    StandardInput;
            int					    StandardOutput;
            int					    StandardError;
            CURDIR					CurrentDirectory;
            UNICODE_STRING			DllPath;
            UNICODE_STRING			ImagePathName;
            UNICODE_STRING			CommandLine;
            String					Environment;
            ulong					StartingX;
            ulong					StartingY;
            ulong					CountX;
            ulong					CountY;
            ulong					CountCharsX;
            ulong					CountCharsY;
            ulong					FillAttribute;
            ulong					WindowFlags;
            ulong					ShowWindowFlags;
            UNICODE_STRING			WindowTitle;
            UNICODE_STRING			Desktop;
            UNICODE_STRING			ShellInfo;
            UNICODE_STRING			RuntimeInfo;
	        RTL_DRIVE_LETTER_CURDIR	CurrentDirectores;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SYSTEM_MODULE
        {
            ulong	Reserved;
            ulong	Base;
            ulong	Size;
            ulong	Flags;
            ushort	Index;
            ushort	Unknown;
            ushort	LoadCount;
            ushort	ModuleNameOffset;
            String	ImageName;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SYSTEM_MODULE_INFORMATION
        {
            ulong           uCount;
	        SYSTEM_MODULE	aSM;
        }

        public enum SYSTEM_INFORMATION_CLASS
        {
            SystemBasicInformation,
            SystemProcessorInformation,
            SystemPerformanceInformation,
            SystemTimeOfDayInformation,
            SystemPathInformation,
            SystemProcessInformation,
            SystemCallCountInformation,
            SystemDeviceInformation,
            SystemProcessorPerformanceInformation,
            SystemFlagsInformation,
            SystemCallTimeInformation,
            SystemModuleInformation, 
            SystemLocksInformation,
            SystemStackTraceInformation,
            SystemPagedPoolInformation,
            SystemNonPagedPoolInformation,
            SystemHandleInformation,
            SystemObjectInformation,
            SystemPageFileInformation,
            SystemVdmInstemulInformation,
            SystemVdmBopInformation,
            SystemFileCacheInformation,
            SystemPoolTagInformation,
            SystemInterruptInformation,
            SystemDpcBehaviorInformation,
            SystemFullMemoryInformation,
            SystemLoadGdiDriverInformation,
            SystemUnloadGdiDriverInformation,
            SystemTimeAdjustmentInformation,
            SystemSummaryMemoryInformation,
            SystemNextEventIdInformation,
            SystemEventIdsInformation,
            SystemCrashDumpInformation,
            SystemExceptionInformation,
            SystemCrashDumpStateInformation,
            SystemKernelDebuggerInformation,
            SystemContextSwitchInformation,
            SystemRegistryQuotaInformation,
            SystemExtendServiceTableInformation,
            SystemPrioritySeperation,
            SystemPlugPlayBusInformation,
            SystemDockInformation,
            SystemPowerInformation, 
            SystemProcessorSpeedInformation,
            SystemCurrentTimeZoneInformation,
            SystemLookasideInformation
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct OBJECT_ATTRIBUTES 
        {
            ulong Length;
            int RootDirectory;
            UNICODE_STRING ObjectName;
            ulong Attributes;
            IntPtr SecurityDescriptor;        // Points to type SECURITY_DESCRIPTOR
            IntPtr SecurityQualityOfService;  // Points to type SECURITY_QUALITY_OF_SERVICE
        }

        public enum ADJUST_PRIVILEGE_TYPE
        {
            AdjustCurrentProcess,
            AdjustCurrentThread
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SERVICE_STATUS 
        {
            int dwServiceType;
            int dwCurrentState;
            int dwControlsAccepted;
            int dwWin32ExitCode;
            int dwServiceSpecificExitCode;
            int dwCheckPoint;
            int dwWaitHint;
        }

        public enum SnapshotFlags : uint
        {
            HeapList = 0x00000001,
            Process = 0x00000002,
            Thread = 0x00000004,
            Module = 0x00000008,
            Module32 = 0x00000010,
            Inherit = 0x80000000,
            All = 0x0000001F
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct PROCESSENTRY32
        {
            const int MAX_PATH = 260;
            internal UInt32 dwSize;
            internal UInt32 cntUsage;
            internal UInt32 th32ProcessID;
            internal IntPtr th32DefaultHeapID;
            internal UInt32 th32ModuleID;
            internal UInt32 cntThreads;
            internal UInt32 th32ParentProcessID;
            internal Int32 pcPriClassBase;
            internal UInt32 dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            internal string szExeFile;
        }

        public enum SHUTDOWN_ACTION
        {
            ShutdownNoReboot,
            ShutdownReboot,
            ShutdownPowerOff
        }

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError=true)]
        public static extern UInt32 NtTerminateProcess(
            int ProcessHandle, 
            long ExitStatus
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int NtLoadDriver(
            ref UNICODE_STRING DriverServiceName
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int NtUnloadDriver(
            ref UNICODE_STRING DriverServiceName
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int RtlAdjustPrivilege(
            int Privilege,
            bool Enable,
            ADJUST_PRIVILEGE_TYPE CurrentThread,
            out bool Enabled
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int RtlInitUnicodeString(
            out UNICODE_STRING DestinationString,
            String SourceString
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        unsafe public static extern int ZwSetSystemInformation(
            int Value1,
            IntPtr Value2, 
            int Value3
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int NtClose(
            int ObjectHandle
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int RtlAllocateHeap(
            IntPtr HeapHandle,
            ulong Flags,
            ulong Size
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int NtQuerySystemInformation(
            SYSTEM_INFORMATION_CLASS SystemInformationClass,
            IntPtr SystemInformation,
            int SystemInformationLength, 
            out int ReturnLength
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int RtlFreeHeap(
            IntPtr HeapHandle, 
            ulong Flags,
            IntPtr MemoryPointer
            );

        [DllImport("advapi32.dll", CharSet = CharSet.Ansi)]
        public static extern int RegCloseKey(
            int hKey
            );

        [DllImport("advapi32.dll", CharSet = CharSet.Ansi)]
        public static extern int RegCreateKey(
            int hKey,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey,
            ref int phkResult
            );

        [DllImport("advapi32.dll", CharSet = CharSet.Ansi)]
        public static extern int RegSetValueEx(
            int hKey,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName,
            int Reserved,
            int dwType,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpData,
            int cbData
            );

        [DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern int SHDeleteKey(
            int hkey,
            String pszSubKey
            );

        [DllImport("Advapi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr OpenSCManager(
            String lpMachineName,
            String lpDatabaseName,
            uint dwDesiredAccess
            );

        [DllImport("Advapi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateService(
             IntPtr hSCManager,
             String lpServiceName,
             String lpDisplayName,
             uint dwDesiredAccess,
             uint dwServiceType,
             uint dwStartType,
             uint dwErrorControl,
             String lpBinaryPathName,
             String lpLoadOrderGroup,
             String lpdwTagId,
             String lpDependencies,
             String lpServiceStartName,
             String lpPassword
            );

        [DllImport("Advapi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr OpenService(
            IntPtr hSCManager,
            String lpServiceName,
            uint dwDesiredAccess
            );

        [DllImport("Advapi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr StartService(
            IntPtr hService,
            uint dwNumServiceArgs,
            String lpServiceArgVectors
            );

        [DllImport("Advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool CloseServiceHandle(
            IntPtr hSCObject
            );

        [DllImport("Advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool ControlService(
            IntPtr hService,
            uint dwControl,
            out SERVICE_STATUS lpServiceStatus
            );

        [DllImport("Advapi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr DeleteService(
            IntPtr hService
            );

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern  int NtShutdownSystem(
            SHUTDOWN_ACTION Action
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateToolhelp32Snapshot(
            int dwFlags,
            int th32ProcessID
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Boolean Process32First(
            IntPtr hSnapshot,
            ref PROCESSENTRY32 lppe
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Boolean Process32Next(
            IntPtr hSnapshot,
            ref PROCESSENTRY32 lppe
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Boolean CloseHandle(
            IntPtr hObject
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int lstrcmpi(
            String lpString1,
            String lpString2
            );

        public static uint GetPidByName(String Proc) {
            IntPtr m_Snap = new IntPtr();
            PROCESSENTRY32 procEntry = new PROCESSENTRY32();
            procEntry.dwSize = (UInt32)Marshal.SizeOf(typeof(PROCESSENTRY32));
            m_Snap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
            if (m_Snap == INVALID_HANDLE_VALUE) return 0;
            if (!Process32First(m_Snap, ref procEntry))return 0;

            do
            {
                if (lstrcmpi(procEntry.szExeFile, Proc) == 0)
                {
                    return procEntry.th32ProcessID;
                }
            } while (Process32Next(m_Snap, ref procEntry));

            CloseHandle(m_Snap);
            return 0;
        }

        [DllImport("DLoadDLL.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LoadDriverWithInjection(
                              uint TargProc,
                              byte[] DriverPath,
                              int LoadMode,
                              Boolean UnloadDriverMode,
                              Boolean DeleteDriverMode,
                              Boolean DelDrvRegMode,
                              int Mode,
                              byte[] DriverName,
                              Boolean UN_LOAD
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateFile(
            String lpFileName,
            int dwDesiredAccess,
            int dwShareMode,
            IntPtr lpSecurityAttributes,
            int dwCreationDisposition,
            int dwFlagsAndAttributes,
            IntPtr hTemplateFile
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool WriteFile(
            IntPtr hFile,
            byte[] lpBuffer,
            uint nNumberOfBytesToWrite,
            out int lpNumberOfBytesWritten,
            IntPtr lpOverlapped
            );

        public static Boolean UnpackDLL(byte[] Buffer, uint Size) {
            int dwWritten = 0;
            String WinDir = Environment.GetEnvironmentVariable("SystemRoot");
            String DLLName = WinDir + "\\" + "DLoadDLL.dll";
            IntPtr hFile = CreateFile(DLLName, GENERIC_WRITE, 0, IntPtr.Zero, CREATE_ALWAYS, FILE_ATTRIBUTE_NORMAL, IntPtr.Zero);
            if (hFile == INVALID_HANDLE_VALUE) return false;
            WriteFile(hFile, Buffer, Size, out dwWritten, IntPtr.Zero);
            CloseHandle(hFile);
            return true;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr LoadLibrary(
            String lpFileName
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetProcAddress(
            IntPtr hModule, 
            String lpProcName
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FreeLibrary(
            IntPtr hModule
            );
    }
}