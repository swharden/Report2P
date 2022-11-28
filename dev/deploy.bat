rmdir /S /Q X:\Software\Report2P
dotnet publish ../src/ --configuration Release
robocopy "..\src\Report2P.GUI\bin\Release\net6.0-windows\publish" "X:\Software\Report2P" /E /NJH /NFL /NDL
pause