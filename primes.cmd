@ECHO OFF

SET ARGUMENTS_TO_PASS=%*
SET SCRIPT_PATH=%~dp0
SET EXECUTABLE=%SCRIPT_PATH%bin\primes.exe
SET PROJECT_FILE=%SCRIPT_PATH%src\PrimeTime.Console\PrimeTime.Console.csproj
SET MSBUILD="%programfiles(x86)%\MSBuild\14.0\bin\msbuild.exe"

IF EXIST "%EXECUTABLE%"  (
	REM Do nothing
) ELSE (
    ECHO Building Executable...
	CALL %MSBUILD% /t:build /p:Configuration=Release /p:Platform="AnyCPU" "%PROJECT_FILE%" > nul
)

REM Run the command
"%EXECUTABLE%" %ARGUMENTS_TO_PASS%