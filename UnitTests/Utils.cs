using System;
using System.IO;

namespace UnitTesting;

public static partial class Toolkit
{
    public static string TestAsset(string filename) =>
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", filename);
}
