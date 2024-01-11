# TGMX - TGMacro X

This repository includes TGMacro X source code and release, also fork of [TGMacro](https://github.com/trksyln/TGMacro) made by [Tarık](https://github.com/trksyln)

### Features That Added New
- German Language Support
- Some improvements for Turkish Language
- New Icon for Program
- Some UI Changes

#### Technical Features

- Upgraded to Visual Studio 2022!
- Added .sln files.
- It compiles very easier than original TGMacro.
- It contains CSInputs library inside of the repository so you don't need to download from other places.

And also have prebuilded CSInputs library inside of the repository, If you lazy to build CSInputs you can actually use prebuilded one. [or even you can build yourself from here](#compiling-csinputs)

# For Developers

If you dont wanna mess with these type of things then you can just [download the precompiled and ready to use zip file that includes executable from here](https://github.com/WH0LEWHALE/TGMacro-X/releases)

## How To Build
* This tutorial maybe can be bit of complex, so make sure you reading the tutorial more focused.
* In the end of the day, you will able to compile the whole project and make it more good.
* In the normal TGMacro repository, there are not a full tutorial that covers everything but in this repository you can learn how to compile and how to set your workspace.

### Requirements
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- .NET Framework 4 Targeting Pack from VS2019
- .NET desktop development

### Running in Visual Studio 2022

- You need install Visual Studio 2022 and 2019, First install 2019 then 2022.
- You can find Visual Studio 2019 [from here](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=community&rel=16&utm_medium=microsoft&utm_campaign=download+from+relnotes&utm_content=vs2019ga+button)
- Install .NET Framework 4 Targeting Pack in Visual Studio 2019 Installer from Individual components > .NET Framework 4 Targeting Pack
- Install Visual Studio 2022 and Download .NET desktop development from Workloads. (If you have Visual Studio 2022 then just press Modify and add .Net desktop development.)
- DONE, Now check out the bottom for compiling tutorial.


#### Compiling TGMacroX 

- Just open TGMacroX.sln
- Switch Debug to Release before compiling.
- At the top Press Build > Build Solution
- Go to bin > Release and you can find the compiled program.
  
#### Compiling CSInputs
- Just open CSInputs.sln **(In the "CSInputs" Folder)**
- Switch Debug to Release before compiling.
- At the top Press Build > Build Solution
- Go into CSInputs > bin > Release and find the CSInputs.dll
- Copy and paste that new file that you compiled to main folder that contains **"TGMacroX.sln"**
> [!NOTE]
>  There is already prebuilded version of CSInputs already in the source code but if you interested you can build yourself as instructed on the top.


