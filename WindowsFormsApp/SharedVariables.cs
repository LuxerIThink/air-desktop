﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


public static class SharedVariables
{
    private static string ip = "localhost";
    private static string port = "80";
    public static void SetIP(string value)
    {
        ip = value;
    }
    public static void SetPORT(string value)
    {
        port = value;
    }
    public static string ShowIP()
    {
        return ip;
    }
    public static string ShowPort()
    {
        return port;
    }
}
