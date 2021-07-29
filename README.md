Supernova is a fork of MCGalaxy that aims to add support for older versions of Minecraft Classic.

**Features**
-----------------
Supernova adds the following features:
* Support for older versions of the Minecraft Classic Protocol.
* Dual server list functionality with the ClassiCube and Betacraft server lists.
* Support for 64-bit builds.
* An option to disable CPE-exclusive blocks.

**Setup**
-----------------
Download the latest Supernova release [from here](https://github.com/forkiesassds/Supernova/releases)
* Windows: You need to install .NET framework 4.0. Windows 8/10 already have this included.
* Linux/macOS: You need to install the [Mono framework](https://www.mono-project.com).

Run **Supernova.exe** for a graphical interface, or run **SupernovaCLI.exe** for command line only.

Joining your server
-----------------
Run Supernova.exe or SupernovaCLI.exe firstly. You'll see something like:
![opt3](https://user-images.githubusercontent.com/6509348/60258728-0e05bd00-9919-11e9-9ae8-f1262719cd50.png)

If you are signed in to classicube.net, you can copy this URL straight into your web browser and start playing.

#### Joining from the desktop client
Click **Direct connect** at the main menu.
![opt1](https://user-images.githubusercontent.com/6509348/60258725-0e05bd00-9919-11e9-8f8c-fbbdc52f04f9.png)

Type your username into *Username*, ```127.0.0.1:25565``` into *IP:Port*, and leave *Mppass* blank. Then click **Connect**.
![opt2](https://user-images.githubusercontent.com/6509348/60258727-0e05bd00-9919-11e9-890d-5c25cdf385c1.png)

#### Make yourself owner
After joining, you will want to rank yourself owner so you can use all commands.

Type ```/rank [your account] superop``` into the bottom text box, then press Enter.

![opt4](https://user-images.githubusercontent.com/6509348/60258729-0e9e5380-9919-11e9-921d-ea7e0c4365af.png)


Letting others join your server
-----------------
#### LAN players
You need to find out your LAN/local IP address.
*  Windows: Type ```ipconfig``` into **Command Prompt**. Look for ```IPv4 address``` in the output.

To join from a web browser on ClassiCube, add ```?ip=[lan ip]``` to the server's URL.\
(e.g. http://www.classicube.net/server/play/d1362e7fee1a54365514712d007c8799?ip=192.168.1.30)

To join from the desktop client, **Direct connect** to ```[lan ip]:25565``` instead. (e.g. ```192.168.1.30:25565```)


#### Across the internet
You need to port forward your router. Players can then join by entering the server URL into their web browser.

For the desktop client:
* Click **Sign in**. 
* Type/paste the hash (e.g. ```d1362e7fee1a54365514712d007c8799```) into the *classicube.net/server/play* text box. 
* Click **Connect**.


#### Show on server lists
Click **Settings** in the Supernova window, then tick the **Public** checkbox. Then click **Save**.

This makes your server appear in the server list on ClassiCube and Betacraft's respective server lists.

Compiling
-----------------
**With an IDE:**
* Visual Studio : Open `Supernova.sln`, click `Build` in the menubar, then click `Build Solution`. (Or press F6)
* SharpDevelop: Open `Supernova.sln`, click `Build` in the menubar, then click `Build Solution`. (Or press F8)

**Command line:**
* For Windows: Run `MSBuild command prompt for VS`, then type `msbuild Supernova.sln` into command prompt
* Modern mono: Type `msbuild Supernova.sln` into Terminal
* Older mono: Type `xbuild Supernova.sln` into Terminal

Copyright/License
-----------------
See LICENSE for Supernova license, and license.txt for code used from other software.
