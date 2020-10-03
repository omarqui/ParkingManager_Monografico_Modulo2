IF (!(Get-Module -Name sqlps))
    {
        Write-Host 'Cargando modulo SQLPS' -ForegroundColor DarkYellow
        Push-Location
        Import-Module sqlps -DisableNameChecking
        Pop-Location
    }
  
  
$localScriptRoot = "."
$Server = Read-Host 'MRCODE\MRCODE2017:'
$scripts = Get-ChildItem $localScriptRoot | Where-Object {$_.Extension -eq ".sql"}
  
foreach ($s in $scripts)
    {
        Write-Host "Ejecutando Script : " $s.Name -BackgroundColor DarkGreen -ForegroundColor White
        $script = $s.FullName
        Invoke-Sqlcmd -ServerInstance $Server -InputFile $script
    }