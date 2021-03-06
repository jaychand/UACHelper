﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UACHelper.Native.ComInterop
{
    [ComImport]
    [Guid("000214E2-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IShellBrowser
    {
        void _VtblGap0_12(); // Skip 12 members.

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void QueryActiveShellView(
            [MarshalAs(UnmanagedType.IUnknown)] out object shellView
        );
    }
}