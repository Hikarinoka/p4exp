//  
// Copyright (c) Nick Guletskii and Arseniy Aseev. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.  
//
namespace WixWPFWizardBA.Utilities
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    public static class SystemInformationUtilities
    {
        /// <summary>
        ///     Checks if the system on which this bootstrapper is running is 64-bit.
        /// </summary>
        /// <returns>true if the system is 64-bit.</returns>
        public static bool Is64BitSystem()
        {
            // If the process is 64-bit, then the system is definitely 64-bit.
            if (IntPtr.Size == 8)
                return true;

            // Check if the current process is a 32-bit process running under WOW64.
            // Here, we assume that we are running under Vista or newer. In reality, this bootstrapper is created for Windows 7 Service Pack 1 or later.
            bool isWow64Process;
            return
                NativeMethods.IsWow64Process(Process.GetCurrentProcess().Handle, out isWow64Process) &&
                isWow64Process;
        }

        internal static class NativeMethods
        {
            [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool IsWow64Process([In] IntPtr process, [Out] out bool wow64Process);
        }

        // Code from here:
        // https://stackoverflow.com/questions/422090/in-c-sharp-check-that-filename-is-possibly-valid-not-that-it-exists
        public static bool IsPathValid(string path)
        {
            System.IO.FileInfo fi = null;
            try
            {
                fi = new System.IO.FileInfo(path);
            }
            catch (ArgumentException) { }
            catch (System.IO.PathTooLongException) { }
            catch (NotSupportedException) { }
            if (ReferenceEquals(fi, null))
            {
                return false;
            }
            else
            {
                // file name is valid... May check for existence by calling fi.Exists.
                return true;
            }
        }
    }
}