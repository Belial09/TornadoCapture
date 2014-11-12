[Setup]
AppName=TornadoCapture
AppVerName=TornadoCapture 2.1
Compression=lzma
SolidCompression=true
DefaultDirName={pf}/TornadoCapture
OutputDir=C:\Sourcen\tc2
MinVersion=0,5.01.2600
CreateAppDir=true
DisableProgramGroupPage=false
Uninstallable=true
LicenseFile=C:\Sourcen\tc2\license.txt
AppCopyright=easytornado.com
RestartIfNeededByRun=false
DisableFinishedPage=false
ShowLanguageDialog=no
SetupIconFile=C:\Sourcen\tc2\box16x.ico
DisableDirPage=false
AppPublisher=easytornado.com
AppPublisherURL=http://www.easytornado.com/
AppSupportURL=http://www.easytornado.com/
AppUpdatesURL=http://www.easytornado.com/
UninstallDisplayIcon={app}\TornadoCapture.exe
UninstallDisplayName=TornadoCapture
AlwaysUsePersonalGroup=true
UninstallFilesDir={app}
ExtraDiskSpaceRequired=5000000
OutputBaseFilename=TornadoCapture-Setup
AppID={{2609544C-9133-462D-9E34-9B8CE2285FF3}
VersionInfoVersion=2.1
VersionInfoCompany=easytornado.com
VersionInfoCopyright=COPYRIGHT 2012
AppVersion=2.1
DefaultGroupName=TornadoCapture

[Files]
Source: TornadoCapture_v2\obj\x86\Debug\TornadoCapture.exe; DestDir: {app}; Flags: overwritereadonly ignoreversion
Source: license.txt; DestDir: {app}; Flags: overwritereadonly ignoreversion



[Icons]
Name: {group}\TornadoCapture; Filename: {app}\TornadoCapture.exe
Name: {commonstartup}\TornadoCapture; Filename: {app}\TornadoCapture.exe; WorkingDir: {app}; IconIndex: 0
Name: {group}\License.txt; Filename: {app}\license.txt
Name: {group}\Uninstall TornadoCapture; Filename: {app}\unins000.exe; WorkingDir: {app}

[Run]
Filename: {app}\TornadoCapture.exe; WorkingDir: {app}; Flags: postinstall nowait
[Messages]
FinishedLabel=Setup has finished installing TornadoCapture on your computer. The application may be launched by selecting the installed icons.
ButtonFinish=&Finish
ClickFinish=Thank you for using TornadoCapture
ButtonInstall=&Next >
ReadyLabel2b=Please select "Install" in the following window for the correct installation of TornadoCapture. %n%n[name] requires the .NET® Framework 2.0 from Microsoft®.%n%nAny questions about installation?%nJust contact support@easytornado.com %n%nClick Next to continue with the installation.
UninstalledMost=%1 uninstall complete!
[UninstallDelete]
Name: {app}\TornadoCapture.exe; Type: files
Name: {app}\TornadoCapture.exe.config; Type: files
Name: {app}\license.txt; Type: files
Name: {app}; Type: filesandordirs
