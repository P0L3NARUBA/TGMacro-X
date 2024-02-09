# TGMX - TGMacro X
Fixed & Cleaned version of TGMacro.

This repository includes TGMacro X source code and release, also fork of [TGMacro](https://github.com/trksyln/TGMacro)

* You can download our prebuilt macro program [from releases](https://github.com/WH0LEWHALE/TGMacro-X/releases)
* For more advanced stuff like compiling tutorial or anything, Go over to [our wiki](https://github.com/WH0LEWHALE/TGMacro-X/wiki)
* You can check out [our project](https://github.com/users/WH0LEWHALE/projects/5) page and get informed about done or future plans.

### New Features 
* New Language(s)
* Some improvements for Turkish Language
* New Icon for Program
* Dark & White Theme Support

#### New Technical Features

* A new setup with Source code! (TGMacroX.nsi)
* Upgraded to Visual Studio 2022!
* Upgraded to .NET 4.8!
* Added .sln files.
* It contains CSInputs library inside of the repository so you don't need to download from other places.

# QNA (Questions And Answers)

 **Why should you choose TGMacroX instead of TGMacro?** 
          
Because the TGMacro is has some problems, and TGMacro X is revamp of TGMacro but better and more cleaned version.

 **I dont want to mess with the source code, where can i download the program?**

You can look out [Our Releases](https://github.com/WH0LEWHALE/TGMacro-X/releases) for latest or older versions of TGMacro X Program!

# Known Issues and Errors

**Unable to load .resx Because it is not trusted**
------

Apply these steps to fix it:

1. Open the file explorer. Navigate to project/solution directory
2. Search for *.resx. --> You will get list of resx files
3. Right click the resx file, open the properties and check the option 'Unblock'
4. Repeat #3 for each resx file.
5. Reload the project.
- **Source: https://stackoverflow.com/a/54395716**

If you get a error message that types/has this:
* **Couldn't process file .resx due to its being in the Internet or Restricted zone or having the mark of the web on the file. Remove the mark of the web if you want to process these files.**

You need to apply same procedures at the top.

**Reason:**
* Its because when you download a zip folder from internet the windows will block some files that has blacklisted extensions, so you need manually unblock the files by doing the steps at the top.

# For Developers

## How To Build
* This tutorial maybe can be bit of complex, so make sure you reading the tutorial more focused
* In the end of the day, you will able to compile the whole project and make it more good
* In the normal TGMacro repository, there are not a full tutorial that covers everything but in this repository you can learn how to compile and how to set your workspace.

### Requirements
- Source Code of TGMacroX
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- .NET desktop development

### Running in Visual Studio 2022

- You need install Visual Studio 2022
- Install Visual Studio 2022 and Download .NET desktop development from Workloads. (If you have Visual Studio 2022 then just press Modify and add .Net desktop development)
- DONE, Now check out the bottom for compiling tutorial.


#### Compiling TGMacro-X

- Just open TGMacroX.sln
- Switch Debug to Release before compiling.
- At the top Press Build -> Build Solution
- Go to bin -> Release and you can find the compiled program.
  
#### Compiling CSInputs
- Just open CSInputs.sln **(In the "CSInputs" Folder)**
- Switch Debug to Release before compiling.
- At the top Press Build -> Build Solution
- Go into CSInputs -> bin -> Release and find the CSInputs.dll
- Copy and paste that new file that you compiled to main folder that contains **"TGMacroX.sln"**

> [!NOTE]
>  There is already prebuilded version of CSInputs already in the source code but if you interested you can build yourself as instructed on the top.
