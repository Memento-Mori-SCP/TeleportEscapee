using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: AssemblyVersion("1.1.1")]
[assembly: AssemblyFileVersion("1.1.1")]
[assembly: AssemblyTitle("TeleportEscapee")]
[assembly: AssemblyProduct("TeleportEscapee")]
[assembly: AssemblyCompany("Memento Mori ~ Dev")]
[assembly: AssemblyTrademark("Memento Mori ~ Dev")]
[assembly: Guid("24855641-21ca-4921-991e-577942debce4")]
[assembly: AssemblyCopyright("Copyright © Memento Mori ~ Dev 2023")]
[assembly: AssemblyDescription("SCP:SL Plugin on NwAPI that teleports players who escape to their previous position.")]

#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif