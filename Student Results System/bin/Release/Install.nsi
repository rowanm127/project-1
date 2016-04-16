!include "MUI2.nsh"

# define the name of the installer
Outfile "Student Results System Install.exe"

# define install directory 
InstallDir "$Desktop\Student Results System"

#Set Install pages
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
#Set Uninstall pages
!define MUI_UNCONFIRMPAGE_TEXT_TOP "This will remove all TINE files except the student database."
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

Name "TINE"

BrandingText "TINE"

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
SectionEnd

# uninstaller section start
Section "uninstall"
 
    # first, delete the uninstaller
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
 
# uninstaller section end
SectionEnd