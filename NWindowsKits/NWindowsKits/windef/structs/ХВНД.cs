using System;
using System.Collections.Generic;
using System.Text;

namespace NWindowsKits.windef.structs
{
    public class ХВНД
    {
        public static HWND Криейт(IntPtr птр)
        {
            return new HWND() { ptr = птр };
        }
    }
}
