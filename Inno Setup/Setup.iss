#define appName "Watcher"
#define appVersion "1.2.0"
#define appPublisher "Christopher Mackay"
#define buildPath "..\Watcher\bin\x64\Release\"

[Setup]
AppId={{E706627B-FD45-4AA0-A325-2FF741E8ABA0}
AppName={#appName}
AppCopyright=Copyright � 2026 Christopher Mackay
AppVersion={#appVersion}
VersionInfoVersion={#appVersion}
AppVerName={#appName}
AppPublisher={#appPublisher}
DefaultDirName={userdocs}\{#appPublisher}\{#appName}
DefaultGroupName={#appName}
OutputDir=.
OutputBaseFilename={#appName}-{#appVersion} Setup
Compression=lzma
SolidCompression=yes
UninstallDisplayIcon={app}\{#appName}.exe
DisableDirPage=yes
PrivilegesRequired=lowest
DisableProgramGroupPage=yes
DisableStartupPrompt=yes
DisableWelcomePage=yes
DisableReadyPage=yes
WizardSmallImageFile=setupicon.bmp
WizardImageFile=bannericon.bmp

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "{#buildPath}\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs

[Icons]
Name: "{group}\{#appName}"; Filename: "{app}\{#appName}.exe"

[UninstallDelete]
Type: filesandordirs; Name: "{localappdata}\{#appPublisher}"