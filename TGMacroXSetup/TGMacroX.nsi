;--------------------------------
;Include Modern UI

  !include "MUI2.nsh"
  !define MUI_ICON "C:\Users\gianni\Desktop\Dosyalar\TGMacroXSetup\ico.ico"

;--------------------------------
;General

  ;Name and file
  Name "TGMacro X"
  OutFile "Setup_TGMacroX.exe"
  Unicode True

  ;Default installation folder
  InstallDir "$LOCALAPPDATA\TGMacro X"
  
  ;Get installation folder from registry if available
  InstallDirRegKey HKCU "Software\TGMacro X" ""

  ;Request application privileges for Windows Vista
  RequestExecutionLevel user

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING

;--------------------------------
;Pages


  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES


  
;--------------------------------
;Languages
 
  !insertmacro MUI_LANGUAGE "English"

;--------------------------------
;Installer Sections

Section # "Base"

  SetOutPath "$InstDir"
  File /r "C:\Users\gianni\Desktop\Dosyalar\TGMacroXSetup\Dark\*.*"
  File /r "C:\Users\gianni\Desktop\Dosyalar\TGMacroXSetup\ico.ico"
  SetOutPath "$InstDir\White"
  File /r "C:\Users\gianni\Desktop\Dosyalar\TGMacroXSetup\White\*.*"

 ;Store installation folder
WriteRegStr HKCU "Software\TGMacro X" "" $INSTDIR
WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\TGMacroX" \
                 "DisplayName" "TGMacro X"
WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\TGMacroX" \
                 "DisplayIcon" $\"$INSTDIR\ico.ico$\"
WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\TGMacroX" \
                 "UninstallString" "$\"$INSTDIR\Uninstall.exe$\""
WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\TGMacroX" \
                 "InstallLocation" "$\"$INSTDIR\$\""
WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\TGMacroX" \
                 "DisplayVersion" "0.4 FIX 2"
WriteRegDword HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\TGMacroX" \
                 "NoModify" 0x00000001
WriteRegDword HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\TGMacroX" \
                 "NoRepair" 0x00000001
  
  ;Create uninstaller
  WriteUninstaller "$INSTDIR\Uninstall.exe"


SectionEnd

Section "Desktop Shortcut" SectionX
    SetShellVarContext current
    CreateShortCut "$DESKTOP\TGMacroX Dark.lnk" "$INSTDIR\TGMacroX.exe"

SetShellVarContext current
    CreateShortCut "$DESKTOP\TGMacroX White.lnk" "$INSTDIR\White\TGMacroX.exe"

SectionEnd

;--------------------------------
;Descriptions

  ;Language strings
  LangString DESC_SecDummy ${LANG_ENGLISH} "A test section."

  ;Assign language strings to sections
  !insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_FUNCTION_DESCRIPTION_END

;--------------------------------
;Uninstaller Section

Section "Uninstall"

  ;ADD YOUR OWN FILES HERE...

  RMDir /r "$INSTDIR"

  DeleteRegKey HKCU "Software\TGMacro X"
  DeleteRegKey HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\TGMacroX\"

SectionEnd

