using System;
using NativeHelperFunctions;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;


namespace DLoad {

    public class DriverLoader {

        public static long ZwStyleLoader(
            String DriverPath
            ) 
        { // Load driver with 'ZwSetSystemInformation'
            bool en; // some shit we dont actually give a fuck about
            int Status; // status
            String FullDriverPath = "\\??\\" + DriverPath + '\0'; // driver path
            Native.SYSTEM_LOAD_AND_CALL_IMAGE img; // structure initialization

            Status = Native.RtlInitUnicodeString( // initialization of unicode string
                out (img.ModuleName), // pointer to UNICODE_STRING
                FullDriverPath // PCWSTR
                );
            if (Status != Native.STATUS_SUCCESS) return Native.STATUS_INITUNISTRING_FAILURE; // unicode string is not initialized

            Status = Native.RtlAdjustPrivilege( // setting privileges
                10, // int
                true, // BOOL
                Native.ADJUST_PRIVILEGE_TYPE.AdjustCurrentProcess, // BOOL
                out en //BOOL *
                );
            if (Status != Native.STATUS_SUCCESS) return Native.STATUS_PRIVILEGES_NOT_SET; // privileges not sat

            IntPtr buffer = Marshal.AllocCoTaskMem(Marshal.SizeOf(img)); // this will point to our structure like 'PVOID'
            Marshal.StructureToPtr(img, buffer, false); // structure to pointer
            // ^ that is the working example how PVOID stuff is converted to C# style
            // we are passing a pointer to structure to IntPtr which is actually a handle
            // previously allocating some memory, then we passing 'buffer' as IN parameter
  
                Status = Native.ZwSetSystemInformation(
                    Native.SystemLoadAndCallImage, // dword
                    buffer, // pvoid
                    Marshal.SizeOf(img) // ulong
                    );
  
            return Status; // just get status code to know what to do next
        }

/***************************************************************************************/

        public static long NtStyleLoader(
            String DriverPath, // driver path
            Boolean UnloadDriver, // unload driver?
            Boolean DeleteDriver, // delete driver file?
            Boolean DeleteRegEntry, // delete driver registry entries?
            Boolean UnloadMode // mode?
            )
        {
            int Status = 0;
            int HKEY_LOCAL_MACHINE = -2147483646;
            const string hKeyLoMachine = "HKEY_LOCAL_MACHINE";
            int hk = 0;
            bool en; // who the hell cares 'bout diz? still it is to be there
            String DriverFile = Path.GetFileName(DriverPath); // get file name from path
            String RegUniPath = "\\Registry\\Machine\\SYSTEM\\CurrentControlSet\\Services\\" + DriverFile;
            String RegPath = "SYSTEM\\CurrentControlSet\\Services\\" + DriverFile;
            String ImgPath = "ImagePath";
            String Tp = "Type";
            Native.UNICODE_STRING UDriverPath;
            String Pathie = "\\??\\" + DriverPath + '\0';
            int SERVICE_KERNEL_DRIVER = (int)0x00000001;
            string subkey = "SYSTEM\\CurrentControlSet\\Services\\" + DriverFile;
            string keyName = hKeyLoMachine + "\\" + subkey;

            if (UnloadMode == true) UnloadDriver = true;

            if (UnloadMode == false)
            {
                Status = Native.RegCreateKey(HKEY_LOCAL_MACHINE, ref RegPath, ref hk);
                Status = Native.RegSetValueEx(hk, ref ImgPath, 0, 1, ref Pathie, Pathie.Length);
                Status = Native.RegCloseKey(hk);
                Registry.SetValue(keyName, Tp, SERVICE_KERNEL_DRIVER, RegistryValueKind.DWord);
            }

            Status = Native.RtlAdjustPrivilege(
                10, 
                true, 
                Native.ADJUST_PRIVILEGE_TYPE.AdjustCurrentProcess, 
                out en
                );
            if (Status != Native.STATUS_SUCCESS)
            {
                Native.SHDeleteKey(HKEY_LOCAL_MACHINE, subkey);
                return Native.STATUS_PRIVILEGES_NOT_SET;
            }

            Status = Native.RtlInitUnicodeString(
                out UDriverPath, 
                RegUniPath
                );
            if (Status != Native.STATUS_SUCCESS)
            {
                Native.SHDeleteKey(HKEY_LOCAL_MACHINE, subkey);
                return Native.STATUS_INITUNISTRING_FAILURE;
            }

            if (UnloadMode == false)
            {
                Status = Native.NtLoadDriver(ref UDriverPath);
                if (Status != Native.STATUS_SUCCESS)
                {
                    Native.SHDeleteKey(HKEY_LOCAL_MACHINE, subkey);
                    return Status;
                }
            }

                if (UnloadDriver == true) 
                {
                    Status = Native.NtUnloadDriver(ref UDriverPath);
                    if (Status != Native.STATUS_SUCCESS)
                    {
                        return Status;
                    }
                }

                if (DeleteDriver == true) 
                {
                    File.Delete(DriverPath);
                }

                if (DeleteRegEntry == true) 
                {
                    Status = Native.SHDeleteKey(HKEY_LOCAL_MACHINE, subkey);
                    if (Status != Native.STATUS_SUCCESS)
                    {
                        return Status;
                    }
                }

            return Native.STATUS_SUCCESS;
        }

        public static bool ScmStyleLoader(
            String DriverPath,
            Boolean UnloadDriver,
            Boolean DeleteDriver,
            Boolean DeleteRegEntry,
            Boolean UnloadMode
            )
        {
            Boolean Status = false;
            int HKEY_LOCAL_MACHINE = -2147483646;
            IntPtr hService = new IntPtr();
            Native.SERVICE_STATUS Service_Status;
            String ServiceName = Path.GetFileName(DriverPath);
            String RegPath = "SYSTEM\\CurrentControlSet\\Services\\" + ServiceName;

            IntPtr scHandle = Native.OpenSCManager(
                              null, 
                              null, 
                              Native.SC_MANAGER_ALL_ACCESS
                              );

            if (scHandle != IntPtr.Zero)
            {
                if (UnloadMode == false)
                {
                    hService = Native.CreateService(
                                      scHandle,
                                      ServiceName,
                                      ServiceName,
                                      Native.SERVICE_ALL_ACCESS,
                                      Native.SERVICE_KERNEL_DRIVER,
                                      Native.SERVICE_DEMAND_START,
                                      Native.SERVICE_ERROR_NORMAL,
                                      DriverPath,
                                      null,
                                      null,
                                      null,
                                      null,
                                      null
                                      );

                    if (hService == null) {
                        hService = Native.OpenService(scHandle, ServiceName, Native.SERVICE_ALL_ACCESS);
                    }
                    IntPtr stAtus = Native.StartService(hService, 0, null);
                    if (stAtus == IntPtr.Zero)
                    {
                        return Status;
                    }
                    else
                    {
                        Status = true;
                    }
                }
                else UnloadDriver = true;
                if (UnloadDriver == true) 
                {
                    IntPtr ServHandle = Native.OpenService(scHandle, ServiceName, Native.SERVICE_ALL_ACCESS);
                    Native.ControlService(ServHandle, Native.SERVICE_CONTROL_STOP, out Service_Status);
                    IntPtr DelSta = Native.DeleteService(ServHandle);
                    if (DelSta == IntPtr.Zero) 
                    {
                        Status = false;
                    }
                }

                if (DeleteDriver == true) 
                {
                    File.Delete(DriverPath);
                }

                if (DeleteRegEntry == true) 
                {
                    Native.SHDeleteKey(HKEY_LOCAL_MACHINE, RegPath);
                }

            }
            Native.CloseServiceHandle(hService);
            Native.CloseServiceHandle(scHandle);
            return Status;
        }
    }

}