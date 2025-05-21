
Sites de ajuda:
-->>  https://marcelo-albuquerque.medium.com/como-instalar-o-wsl-2-no-windows-10-3e26d99d7161
-->>  https://docs.docker.com/desktop/setup/install/windows-install/

Passo 1 — Habilitar o Subsistema do Windows para Linux
dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart

Passo 2 — Habilitar o recurso de Máquina Virtual
dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart

Passo 3— Baixar o pacote de atualização do kernel do Linux
https://wslstorestorage.blob.core.windows.net/wslblob/wsl_update_x64.msi

Passo 4 — Definir o WSL 2 como a sua versão padrão
wsl --set-default-version 2

Passo 5 - Ver as distribuições do Linux disponiveis para instalar no WSL2
wsl --list --online

Passo 6 - Instalar a distro do linux Ubuntu-24.04
wsl --install -d Ubuntu-24.04

Passo 7 - Finalizada a instalação da distro informar usuario e senha para acessar o Linux na WSL2

Passo 8 - Reiniciar a máquina
