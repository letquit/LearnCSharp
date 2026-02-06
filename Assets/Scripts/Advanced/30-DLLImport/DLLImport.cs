using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class DLLImport : MonoBehaviour
// public partial class DLLImport : MonoBehaviour
{
    [DllImport("user32.dll")]
    public static extern bool MessageBeep(uint utype);
    // public static extern bool MessageBep(uint utype);
    
    // [LibraryImport("user32.dll")]
    // [return: MarshalAs(UnmanagedType.Bool)]
    // public static partial bool MessageBeep(uint utype);
    
    
    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    public static extern int MessageBox(int hWnd, String text, String caption, uint type);
    // public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
    
    private void Start()
    {
        // MessageBeep(0);
        // MessageBox(0, "Hello World!", "Code Monkey", 0);
        MessageBox(0, "Hello World!", "Code Monkey", 0x00000004 | 0x00000020);
    }
}
