# AndroSpy - Xamarin-C# Android RAT  
<img src="https://user-images.githubusercontent.com/45147475/89324496-096d1580-d690-11ea-86d2-1b8b1d484d35.png" width="25%"></img>   

An Android RAT that written in completely C# by me (qH0sT a.k.a Sagopa K)  

Minumum Android Version: 4.1    

Tested on some systems:  
Android 4.4.2 - OK  
Android 5.1.1 - OK  
Android 7.1.2 - OK  
Android 6.0.1 - OK  
Android 9.0   - OK  
Android 10    - OK  

AndroSpy Project aims to most powerful-stable-useful open source Android RAT.  

<img src="https://user-images.githubusercontent.com/45147475/101283742-7da9f800-37ed-11eb-86ce-4b2c702962b4.PNG" width="40%"></img> 
<img src="https://user-images.githubusercontent.com/45147475/101283744-800c5200-37ed-11eb-9a6d-182c4c339639.PNG" width="30%"></img> 
<img src="https://user-images.githubusercontent.com/45147475/101283745-800c5200-37ed-11eb-9cea-006ecaf63ef1.PNG" width="30%"></img> 
<img src="https://user-images.githubusercontent.com/45147475/101283746-81d61580-37ed-11eb-817c-c3e936c1d7c8.PNG" width="30%"></img> 
<img src="https://user-images.githubusercontent.com/45147475/101283748-83074280-37ed-11eb-94ff-3a508a0413c0.png" width="30%"></img> 
<img src="https://user-images.githubusercontent.com/45147475/101283749-84386f80-37ed-11eb-82bd-0f372ae50369.PNG" width="30%"></img>   


# Update 6 december 2020 on Version 3  
+Added Live Screen (MediaProjection API has been available since API Level 21, for more: https://developer.android.com/  
+File Manager has been improvement.  
+Fully English version.  
+Fixed English Flag issue.  
and other changes, fixing, improvents. :)

# Version 3  
+Added live Camera stream (with resolution,zoom,flash,quality controls and scene,focus,white balance mode)  
+Fixed loss data transfer  
+Some excess codes have been removed  
+Performance has been increased

# [+] Update on version V2  
+Added logs.  
+Added preview of clicked image into the filemaneger.  
+Added choose sizes of both front and back camera.  
+Some other fixes and changes.

# [+]Version Update 2 (first update as version)  
+Switching to ``System.Net.Sockets.NetworkStream`` from directly ``System.Net.Sockets.Socket`` Communitation. This change was more stable and fast. And Project has cleaner code.  
+Added Wifi,Bluetooth,Mobil Data etc. into  the Phone Infos form.  
+Added screen brightness option into the settings panel.  
+Some important updates-changes.

# [+]Update 1.3 (First stable Update)  
+Added "Add Shortcut to home screen" option into the Fun Manager.  
+Added Name of Phone Number into the Window that is showed when Incall or Outgoing Call starts in any Victim.  
+a Correction in SMS Manager.
  
# [+]Update 1.2 ( semi-stable Update :) )  
+Connection between Client and Server has been improvement.  
+Added 'Name' column into the Sms and Call Log manager.  
+Some visual changes.  
+Added dropped Pin URL into the Location Manager  
+Fixed terminate problem that caused by Ram Cleaner.  
+Fixed problem that caused when our trojan hides self from launcher.  
+Our trojan can hide it self from launcher.

# [+]Update 1.1  
+Major improvements  
+Added Flash/Torch option to Camera Manager and percentage status with progressbar.  
+Reconstructed Upload/Download file and added percentage status with progressbar.  
+Added Download Manager (you can download any file that you want into the victim's phone but you must put filename into textBox)  
+Added some features into Call Manager (Send sms to selected phone number directly, call selected number...)
+Added source into Microphone Manager (Mic, Call, Default)  
+Some visual improvements.
And more that I have forgot to write :)

# [+]Update 1.0  
+Critical improvements (in both Server and Client)  
+Re-made File Manager (more sightly, stable and useful)

# [+]Update 0.1.2  
+some improvements (in both Server and Client)  
+Notify when Call (incoming or outgoing) in any client starts.  
+Camera was improvement.
  
# User Manual
For Users:
For builder you must install msbuild tools latest version, JDK latest version and Android SDK Tools. Then open the file (in the \Debug\ path) that has .tht extension with Notepad and configure the paths in the this .tht file again to your side. And copy the files in the "Client" folder into the \ProjectFolder\ path in the Server side.

MsBuild Tools: https://download.visualstudio.microsoft.com/download/pr/c10c95d2-4fba-4858-a1aa-c3b4951c244b/54dedc13fbb321033e5d3297ac7c5ad8de484be2871153fe20599211135c9448/vs_BuildTools.exe  

(Check Xamarin checkBox in the installation panel)

For Developers:  
Your Visual Studio must have Xamarin Developing Kit then you can develop the Android side project (Client)
