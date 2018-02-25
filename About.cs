using System;
using System.Windows.Forms;

namespace AboutApp {

    public class About {

        public static void ShowAboutInformation()
        {
            String Ab =
            "\nDload .Net [ Driver Loader ]\n" +
            "Machinized Fractals [ www.machinized.com ]\n" +
            "Abilities:\n" +
            "[+] Load driver with ZwSetSystemInformation\n" +
            "[+] Load driver with NtLoadDriver\n" +
            "[+] Load driver with Service Control Manager\n" +
            "[+] Unload driver\n" +
            "[+] Delete driver file\n" +
            "[+] Delete driver registry entries\n" +
            "[+] Usage of Thread Injection technique\n" +
            "[+] Injection with RtlCreateUserThread\n" +
            "[+] Injection with CreateRemoteThread\n" +
            "[+] Injection with NtCreateThreadEx\n" +
            "[+] LOAD Mode\n" +
            "[+] UNLOAD Mode\n" +
            "[+] Reboot System\n" +
            "[+] Shutdown System\n" +
            "[+] Any combination of the above functions\n";
            MessageBox.Show(Ab);
            return;
        }
    }
}