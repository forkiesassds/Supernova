Supernova is a fork of MCGalaxy that aims to add support for older versions of **Minecraft Classic**.

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
![opt3](https://github.com/MisterSheeple/Supernova/blob/1ee1be2fc677b14c3b94d331530da01b3ec4310b/Images/Supernova1.PNG)

If you are signed in to classicube.net, you can copy this URL straight into your web browser and start playing.

#### Joining from the Betacraft Launcher
Click on **Select version** at the main menu, and select 0.30-c (or a different version if you've changed the PVN).
#### WIP (picture will go here)

Enter a username into the *Username* text box, or click **Log in** to sign in with a Mojang or Microsoft account.
#### WIP (picture will go here)

Once you click **Play**, a text box will pop up requesting a server IP. Enter ```127.0.0.1:25565``` into this text box and click **OK**.
#### WIP (picture will go here)

#### Joining from the ClassiCube desktop client
Click **Direct connect** at the main menu.
![opt1](https://user-images.githubusercontent.com/6509348/60258725-0e05bd00-9919-11e9-8f8c-fbbdc52f04f9.png)

Type your username into *Username*, ```127.0.0.1:25565``` into *IP:Port*, and leave *Mppass* blank. Then click **Connect**.
![opt2](https://user-images.githubusercontent.com/6509348/60258727-0e05bd00-9919-11e9-890d-5c25cdf385c1.png)

#### Make yourself owner
After joining, you will want to rank yourself owner so you can use all commands.

Type ```/rank [your account] superop``` into the bottom text box, then press Enter.

![opt4](https://github.com/MisterSheeple/Supernova/blob/b6a28bebd25d7fc13ac2913aa020bd39f15a584e/Images/Supernova2_new.PNG)


Letting others join your server
-----------------
#### LAN players
You need to find out your LAN/local IP address.
*  Windows: Type ```ipconfig``` into **Command Prompt**. Look for ```IPv4 address``` in the output.

To join from a web browser on ClassiCube, add ```?ip=[lan ip]``` to the server's URL.\
(e.g. http://www.classicube.net/server/play/d1362e7fee1a54365514712d007c8799?ip=192.168.1.30)

To join from the ClassiCube or Betacraft desktop clients, connect to ```[lan ip]:25565``` instead. (e.g. ```192.168.1.30:25565```)


#### Across the internet
You need to port forward your router. Players can then join by entering the server URL into their web browser.

For the ClassiCube desktop client:
* Click **Sign in**. 
* Type/paste the hash (e.g. ```d1362e7fee1a54365514712d007c8799```) into the *classicube.net/server/play* text box. 
* Click **Connect**.

For the Betacraft desktop client:
* Find your public IP address. This can typically be seen in your router's settings (your public IP should not begin with ```192.168```)
* Type/paste the public IP address into the *Server IP* text box and click **OK**.


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
