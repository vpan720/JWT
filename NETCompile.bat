@echo off

"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" -logger:"C:\Program Files\OutSystems\Development Environment 11\Integration Studio\OutSystems.IntegrationStudio.Logger.dll" "D:\Curbside Res\jwt\Source\NET\jwt.sln" /nologo /verbosity:minimal /target:Rebuild /property:Configuration=Release