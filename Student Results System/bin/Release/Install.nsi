!include "MUI2.nsh"

# define the name of the installer
Outfile "Student Results System Install.exe"

# define install directory 
InstallDir "$PROGRAMFILES\TINE"

#Set Install pages
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
#Set Uninstall pages
!define MUI_UNCONFIRMPAGE_TEXT_TOP "This will remove all TINE files except the student results database."
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

Name "TINE"

BrandingText "TINE"

Section -Prerequisites
  SetOutPath $INSTDIR\Prerequisites
  MessageBox MB_YESNO "Access Database Engine 2010 is required by TINE. Install?" /SD IDYES IDNO endAccessDatabaseEngine
    File "Prerequisites\AccessDatabaseEngine.exe"
    ExecWait "$INSTDIR\Prerequisites\AccessDatabaseEngine.exe"
    Goto endAccessDatabaseEngine
  endAccessDatabaseEngine:
SectionEnd

# default section
Section
	
	# set the installation directory as the destination for the following actions
	SetOutPath $INSTDIR
	 
	# create the uninstaller
    WriteUninstaller "$INSTDIR\uninstall.exe"
	 
	# define what to install and place it in the output path
	File "Default.accdb"
	File "Student Results System.exe"
	File "itextsharp.dll"
	File "itextsharp.xml"
	File "Microsoft.VisualBasic.PowerPacks.Vs.dll"
	File "Microsoft.VisualBasic.PowerPacks.Vs.xml"
	File "Student Results System.exe.config"
	File "Student Results System.pdb"
	File "Student Results System.xml"
	File "System.Data.SqlServerCe.dll"
    
    ;create desktop shortcut
    CreateShortCut "$DESKTOP\TINE.lnk" "$INSTDIR\Student Results System.exe" ""
     
    ;create start-menu items
    CreateDirectory "$SMPROGRAMS\TINE"
    CreateShortCut "$SMPROGRAMS\TINE\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
    CreateShortCut "$SMPROGRAMS\TINE\TINE.lnk" "$INSTDIR\Student Results System.exe" "" "$INSTDIR\Student Results System.exe" 0
SectionEnd

# uninstaller section start
Section "uninstall"
 
    # Delete the uninstaller
    Delete "$INSTDIR\uninstall.exe"
	#Then delete all files
	Delete "$INSTDIR\Student Results System.exe"
	Delete "$INSTDIR\itextsharp.dll"
	Delete "$INSTDIR\itextsharp.xml"
	Delete "$INSTDIR\Microsoft.VisualBasic.PowerPacks.Vs.dll"
	Delete "$INSTDIR\Microsoft.VisualBasic.PowerPacks.Vs.xml"
	Delete "$INSTDIR\Student Results System.exe.config"
	Delete "$INSTDIR\Student Results System.pdb"
	Delete "$INSTDIR\Student Results System.xml"
	Delete "$INSTDIR\System.Data.SqlServerCe.dll"
    Delete "$INSTDIR\Prerequisites\AccessDatabaseEngine.exe"
    RmDir  "$INSTDIR\Prerequisites"
    
    ;Delete Start Menu Shortcuts
    Delete "$DESKTOP\TINE.lnk"
    Delete "$SMPROGRAMS\TINE\*.*"
    RmDir  "$SMPROGRAMS\TINE"
     
# uninstaller section end
SectionEnd