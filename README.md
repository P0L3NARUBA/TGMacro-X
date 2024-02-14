# TGMX - TGMacro X
Best & Free Open Source Macro Program Ever,
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

Also, feel free to create pull request and issues.

# QNA (Questions And Answers)

 **Why should you choose TGMacroX instead of TGMacro?** 
          
Because the TGMacro is has some problems, and TGMacro X is revamp of TGMacro but better and more cleaned version.

 **I dont want to mess with the source code, where can i download the program?**

You can check out [Our Releases](https://github.com/WH0LEWHALE/TGMacro-X/releases) for latest or older versions of TGMacro X Program!

# Known Issues and Errors

**Unable to load .resx Because it is not trusted**

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
