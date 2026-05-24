```csharp
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public static class TrainerCore
{
    private static Process process;
    private static IntPtr processHandle;

    // Static addresses for Roblox-specific values
    private const int PLAYER_HEALTH_ADDRESS = 0x123456; // Replace with the correct address
    private const int PLAYER_GOLD_ADDRESS = 0x123457; // Replace with the correct address
    private const int PLAYER_XP_ADDRESS = 0x123458; // Replace with the correct address

    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(int processAccess, bool bInheritHandle, int processId);
    
    [DllImport("kernel32.dll")]
    private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, out int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll")]
    private static extern bool CloseHandle(IntPtr handle);

    public static bool AttachToProcess(string processName)
    {
        process = Process.GetProcessesByName(processName)[0];
        if (process == null) return false;

        processHandle = OpenProcess(0x1F0FFF, false, process.Id); // PROCESS_ALL_ACCESS
        return processHandle != IntPtr.Zero;
    }

    public static bool IsGameRunning(string processName)
    {
        return Process.GetProcessesByName(processName).Length > 0;
    }

    public static float ReadFloat(IntPtr address)
    {
        byte[] buffer = new byte[4];
        ReadProcessMemory(processHandle, address, buffer, (uint)buffer.Length, out _);
        return BitConverter.ToSingle(buffer, 0);
    }

    public static void WriteFloat(IntPtr address, float value)
    {
        byte[] buffer = BitConverter.GetBytes(value);
        WriteProcessMemory(processHandle, address, buffer, (uint)buffer.Length, out _);
    }

    public static int ReadInt(IntPtr address)
    {
        byte[] buffer = new byte[4];
        ReadProcessMemory(processHandle, address, buffer, (uint)buffer.Length, out _);
        return BitConverter.ToInt32(buffer, 0);
    }

    public static void WriteInt(IntPtr address, int value)
    {
        byte[] buffer = BitConverter.GetBytes(value);
        WriteProcessMemory(processHandle, address, buffer, (uint)buffer.Length, out _);
    }

    public static float GetPlayerHealth()
    {
        return ReadFloat((IntPtr)PLAYER_HEALTH_ADDRESS);
    }

    public static void SetPlayerHealth(float health)
    {