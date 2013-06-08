﻿using System;
using System.Reflection;

namespace MahApps.Metro.SimpleChildWindow
{
  public class Program
  {
    [STAThread]
    public static void Main() {
      AppDomain.CurrentDomain.AssemblyResolve += (sender, args) => {
                                                   var resourceName = "MahApps.Metro.SimpleChildWindow.DllsAsResource." + new AssemblyName(args.Name).Name + ".dll";
                                                   using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)) {
                                                     if (stream != null) {
                                                       var assemblyData = new Byte[stream.Length];
                                                       stream.Read(assemblyData, 0, assemblyData.Length);
                                                       return Assembly.Load(assemblyData);
                                                     }
                                                   }
                                                   return null;
                                                 };
      App.Main();
    }
  }
}