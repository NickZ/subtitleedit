@ECHO OFF
SETLOCAL

CD /D %~dp0

REM Check for the help switches
IF /I "%~1" == "help"   GOTO ShowHelp
IF /I "%~1" == "/help"  GOTO ShowHelp
IF /I "%~1" == "-help"  GOTO ShowHelp
IF /I "%~1" == "--help" GOTO ShowHelp
IF /I "%~1" == "/?"     GOTO ShowHelp
IF /I "%~1" == "-?"     GOTO ShowHelp

:SetBuildType
IF "%~1" == "" (
  SET "BUILDTYPE=Build"
) ELSE (
  IF /I "%~1" == "Build"     SET "BUILDTYPE=Build"   & GOTO START
  IF /I "%~1" == "/Build"    SET "BUILDTYPE=Build"   & GOTO START
  IF /I "%~1" == "-Build"    SET "BUILDTYPE=Build"   & GOTO START
  IF /I "%~1" == "--Build"   SET "BUILDTYPE=Build"   & GOTO START
  IF /I "%~1" == "Clean"     SET "BUILDTYPE=Clean"   & GOTO START
  IF /I "%~1" == "/Clean"    SET "BUILDTYPE=Clean"   & GOTO START
  IF /I "%~1" == "-Clean"    SET "BUILDTYPE=Clean"   & GOTO START
  IF /I "%~1" == "--Clean"   SET "BUILDTYPE=Clean"   & GOTO START
  IF /I "%~1" == "Rebuild"   SET "BUILDTYPE=Rebuild" & GOTO START
  IF /I "%~1" == "/Rebuild"  SET "BUILDTYPE=Rebuild" & GOTO START
  IF /I "%~1" == "-Rebuild"  SET "BUILDTYPE=Rebuild" & GOTO START
  IF /I "%~1" == "--Rebuild" SET "BUILDTYPE=Rebuild" & GOTO START

  ECHO.
  ECHO Unsupported commandline switch!
  GOTO EndWithError
)


:START
TITLE %BUILDTYPE%ing Subtitle Edit snap package...
ECHO.
ECHO %BUILDTYPE%ing Subtitle Edit snap package...

ECHO Starting %BUILDTYPE% for Subtitle Edit...
cmd /c build.bat %~1
IF %ERRORLEVEL% NEQ 0 GOTO EndWithError

CALL :SubDetectMultipassPath
IF DEFINED MULTIPASS IF EXIST "%MULTIPASS%" (
  ECHO Found Multipass!
) ELSE (
  ECHO Multipass not found in PATH!
  GOTO EndWithError
)

CALL :SubDetectSnapcraftPath
IF DEFINED SNAPCRAFT IF EXIST "%SNAPCRAFT%" (
  ECHO Found Snapcraft!
  CALL :SubGetFullVersion
  ECHO "%VERSION%" >version.txt
) ELSE (
  ECHO Snapcraft not found in Path!
  GOTO EndWithError
)


IF /I "%BUILDTYPE%" == "Clean" (
  snapcraft clean
  IF %ERRORLEVEL% NEQ 0 GOTO EndWithError
  GOTO EndSuccessful
)

DEL /F SubtitleEdit.zip
copy SubtitleEdit-%VERSION%.zip SubtitleEdit.zip

Echo "Cleaning previous snapcraft builds..."
snapcraft clean subtitle-edit

Echo "Starting snapcraft..."
snapcraft
IF %ERRORLEVEL% NEQ 0 GOTO EndWithError

:EndSuccessful
TITLE %BUILDTYPE%ing Subtitle Edit snap finished!
GOTO END


:EndWithError
TITLE Snapping Subtitle Edit [ERROR]
ECHO.
ECHO.
ECHO  ** ERROR: Snap build failed and aborted! **
GOTO END


:ShowHelp
TITLE %~nx0 %1
ECHO.
ECHO.
ECHO Usage:   %~nx0
ECHO.
ECHO Notes:   You can also prefix the commands with "-", "--" or "/".
ECHO          The arguments are not case sensitive.
ECHO.
ECHO Executing %~nx0 without any arguments is equivalent to "%~nx0 build".


:END
ECHO.
ECHO.
ENDLOCAL
PAUSE
EXIT /B

:SubGetFullVersion
FOR /F delims^=^"^ tokens^=2 %%A IN ('FINDSTR /R /C:"AssemblyVersion" "src\Properties\AssemblyInfo.cs.template"') DO (
  REM 3.4.1.[REVNO]
  SET "VERSION=%%A"
)
EXIT /B


:SubDetectMultipassPath
FOR %%G IN (multipass.exe) DO (SET "MULTIPASS_PATH=%%~$PATH:G")
IF EXIST "%MULTIPASS_PATH%" (SET "MULTIPASS=%MULTIPASS_PATH%" & EXIT /B)

:SubDetectSnapcraftPath
FOR %%G IN (snapcraft.exe) DO (SET "SNAPCRAFT_PATH=%%~$PATH:G")
IF EXIST "%SNAPCRAFT_PATH%" (SET "SNAPCRAFT=%SNAPCRAFT_PATH%" & EXIT /B)
