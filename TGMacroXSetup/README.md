## TGMacroX Setup

#### Requirements
- [NSIS (Nullsoft scriptable install system)](https://nsis.sourceforge.io/Download)
- ["TGMacroXSetup" Folder](https://github.com/WH0LEWHALE/TGMacro-X/tree/dark-theme/TGMacroXSetup)
- A Compiled CSInputs.dll and TGMacroX Executables (Dark And White)

### Compiling TGMacro-X Setup

1. Download and Install all the Requirements
2. Delete All the files inside TGMacroXSetup that named **DELETE-ME** because there are placeholder files so you dont need them.
3. Change all of ``C:\TGMacroXSetup\`` in TGMacroX.nsi to ``C:\whereyouwant\TGMacroXSetup\`` by CTRL + H in Notepad or other text editors.
4. Put The Dark Theme Executable That you compiled to ``TGMacroXSetup/Dark`` directory and Put The CSInputs.dll to ``TGMacroXSetup/Dark/Lib``.
5. Put The White Theme Executable That you compiled to ``TGMacroXSetup/White`` directory and Put The CSInputs.dll to ``TGMacroXSetup/White/Lib``.
6. Open the **NSIS** program that you installed and press **"Compile NSI scripts"** from **"Compiler"** tab
7. Go to  File -› Load Script and Load the **"TGMacroX.nsi"**
8. It will automatically build it, when its done just save the setup to anywhere that you want.
