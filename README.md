# Distro Grub Themes

[![name](https://img.shields.io/github/license/AdisonCavani/distro-grub-themes)](https://github.com/AdisonCavani/distro-grub-themes/blob/master/LICENSE)
[![name](https://img.shields.io/github/v/release/AdisonCavani/distro-grub-themes)](https://github.com/AdisonCavani/distro-grub-themes/releases)
[![Build](https://github.com/AdisonCavani/distro-grub-themes/actions/workflows/update-content.yml/badge.svg?event=push)](https://github.com/AdisonCavani/distro-grub-themes/actions/workflows/update-content.yml)<br>

A pack of GRUB2 themes for different Linux distributions and OSs.<br>
It aims to replace the default GRUB look, with a nice and colorful theme.

## Get started

- [Themes](#themes)
  - [Supported distributions](#supported-distributions)
  - [Supported vendors](#supported-vendors)

- [Preview themes](#preview-themes)
  - [Distro themes](#distro-themes)
  - [Vendor themes](#vendor-themes)

- [Installation](#installation)
  - [Installation via Grub Customizer](#installation-via-grub-customizer)
  - [Manual Installation](#manual-installation)
  - [Install theme in Ventoy](#install-theme-in-ventoy)
  
- [To-do list](#to-do-list)

# Themes

## Supported distributions

- Arch Linux
- Arco Linux
- Artix Linux
- Bedrock Linux
- CentOS
- Debian
- Deepin
- ElementaryOS
- EndeavourOS
- Fedora
- FreeBSD
- Garuda
- Gentoo
- KDE Neon
- Kubuntu
- Linux Mint
- Manjaro
- MX Linux
- openSUSE
- Pop!_OS
- Rocky Linux
- Slackware
- Solus
- Ubuntu
- Ubuntu Mate
- Ventoy
- Void Linux
- Windows 10
- Windows 11
- Xero Linux
- Zorin OS

## Supported vendors

- Acer
- Aorus
- Apple
- Asus
- ASRock
- Dell
- Framework
- Gigabyte
- HP
- Kingston
- Legion
- Lenovo
- MSI
- Razer
- System76
- Toshiba
- Vaio

## Preview themes

### Distro themes

<p float="left">
<img src="./preview/Arch%20Linux.png" width="49%"/>
<img src="./preview/Arco%20Linux.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Artix%20Linux.png" width="49%"/>
<img src="./preview/Bedrock.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/CentOS.png" width="49%"/>
<img src="./preview/Debian.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Deepin.png" width="49%"/>
<img src="./preview/ElementaryOS.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/EndeavourOS.png" width="49%"/>
<img src="./preview/Fedora.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/FreeBSD.png" width="49%"/>
<img src="./preview/Garuda.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Gentoo.png" width="49%"/>
<img src="./preview/KDEneon.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Kubuntu.png" width="49%"/>
<img src="./preview/Linux%20Mint.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Manjaro.png" width="49%"/>
<img src="./preview/MX%20Linux.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/OpenSUSE.png" width="49%"/>
<img src="./preview/PopOS.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Rocky%20Linux.png" width="49%"/>
<img src="./preview/Slackware.png" width="49%"/> 
</p>
<p float="left">
<img src="./preview/Solus.png" width="49%"/>
<img src="./preview/Ubuntu.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/UbuntuMate.png" width="49%"/>
<img src="./preview/Ventoy.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Void%20Linux.png" width="49%"/>
<img src="./preview/Windows%2010.png" width="49%"/>  
</p>
<p float="left">
<img src="./preview/Windows%2011.png" width="49%"/>
<img src="./preview/Xero.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/ZorinOS.png" width="49%"/>
</p>

### Vendor themes

<p float="left">
<img src="./preview/Acer.png" width="49%"/>
<img src="./preview/Aorus.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Apple.png" width="49%"/>
<img src="./preview/Asus.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/ASRock.png" width="49%"/>
<img src="./preview/Dell.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Framework.png" width="49%"/>  
<img src="./preview/Gigabyte.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/HP.png" width="49%"/>
<img src="./preview/Kingston.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Legion.png" width="49%"/>
<img src="./preview/Lenovo.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/MSI.png" width="49%"/>  
<img src="./preview/Razer.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/System76.png" width="49%"/>  
<img src="./preview/Toshiba.png" width="49%"/>
</p>
<p float="left">
<img src="./preview/Vaio.png" width="49%"/>
</p>

# Installation

## Installation via GRUB Customizer

In order to clone the repository from GitHub, you have to install Git, via the `git` package <br>
Alternatively, you can download a zip archive by clicking on **Code** then **Download ZIP**

#### Clone the repository

You can clone the repository or go to the [release page](https://github.com/AdisonCavani/distro-grub-themes/releases) and download a single theme.

```shell
git clone https://github.com/AdisonCavani/distro-grub-themes.git
```

### Install GRUB Customizer

**Warning**: ``grub-customizer`` is not available on Ubuntu 21.10 and above. See [#56](https://github.com/AdisonCavani/distro-grub-themes/issues/56). You should [install it manually](#manual-installation), instead.<br><br>

apt

```shell
sudo add-apt-repository ppa:danielrichter2007/grub-customizer
sudo apt-get update
sudo apt-get install grub-customizer
```

pacman

```shell
sudo pacman -S grub-customizer
```

dnf<br>

**WARNING**: Grub Customizer DOES NOT WORK on recent Fedora releases without extensive modification. [Manually installing](#manual-installation) a GRUB theme is much more secure and hassle free. Use at your own risk.

```shell
sudo dnf install grub-customizer
```

eopkg

```shell
sudo eopkg install grub-customizer
```

### Install a pre-made theme with GRUB Customizer

- Open GRUB Customizer
- Click on the **Appearance settings** tab
- Select _Custom resolution_ and select or type in your resolution, e.g 1920x1080
- Press the _Add theme_ button, then navigate to the directory where you cloned the repository; in my case `/home/adison/distro-grub-themes`
- Select your theme located in the `/themes` directory
- Save the changes

### Install a custom-made theme with GRUB Customizer

- Edit your theme located in the `/customize` folder
- With your file manager, inside the modified theme's directory, select all files and create an archive with .tar or .tar.xz format
- Open GRUB Customizer
- Click on the **Appearance settings** tab
- Enable _Custom resolution_ and select or type in your resolution, e.g 1920x1080
- Press the _Add theme_ button, then navigate to the directory where you cloned the repository; in my case `/home/adison/distro-grub-themes`
- Change the _Archive files_ setting to **All files**
- Select your archive
- Save the changes

#### Note:
KDE Neon's default theme is set in a separate file that overrides any theme changes you make. Run the following to disable the default GRUB theme:

```shell
sudo rm /etc/default/grub.d/99_breeze-grub.cfg
sudo update-grub
```

To revert back to the orignal KDE Neon theme, open GRUB Customizer, and in the Appearance settings tab, change the theme dropdown back to breeze.

## Manual Installation

In order to clone the repository from GitHub, you have to install Git, via the `git` package <br>
Alternatively, you can download a zip archive by clicking on **Code** then **Download ZIP**

#### Clone the repository

You can clone the repository, or go to the [release page](https://github.com/AdisonCavani/distro-grub-themes/releases) and download a single theme.

```shell
git clone https://github.com/AdisonCavani/distro-grub-themes.git
```

#### Create the themes directory
To create the themes directory, replace `GRUB Location` with the directory where GRUB is located.<br>
Usually it's ``/boot/grub`` or ``/boot/grub2`` but some distributions have a different one, so you'll have to figure it out. Your distro's documentation is a great place to start.

```shell
sudo mkdir <GRUB Location>/themes
```

#### Edit or use a pre-made theme

```shell
cd distro-grub-themes/customize
```

#### Copy theme

The theme must be unpacked inside a folder before you can copy it.

```shell
sudo cp -r <theme_name>/<GRUB Location>/themes
```

#### Edit GRUB config

You can use your favourite text editor for this. Here, we use nano.

```shell
sudo nano /etc/default/grub
```

Uncomment this line and set your display resolution:

```
GRUB_GFXMODE=1920x1080
```

Make sure ``GRUB_TERMINAL_OUTPUT="console"`` is commented out!

At the end of the file, add the path of your theme:

```
GRUB_THEME="<GRUB Location>/themes/<theme_name>/theme.txt"
```

Ctrl+O to save, Ctrl+X to exit

#### Update Grub config

You'll need to tell GRUB to update its configuration in order to include the new theme.


##### Ubuntu and Debian-based systems:

```shell
sudo update-grub
```


##### Fedora and RHEL-based distros:
```shell
sudo grub2-mkconfig -o /etc/grub2.cfg #For BIOS systems
```

OR

```shell
sudo grub2-mkconfig -o /etc/grub2-efi.cfg #For UEFI systems
```


##### Arch & others: 

```shell
sudo grub-mkconfig -o <GRUB Location>/grub.cfg
```
or

```shell
sudo grub2-mkconfig -o <GRUB Location>/grub.cfg
```

#### Note:

- Commands tested on: ***(Please add your distro here)***
  - Fedora
  - Arch
  - Debian and it's derivatives (Ubuntu, Mint etc.)

- KDE Neon's default theme is set in a separate file that overrides any theme changes you make. Run the following to disable the default GRUB theme:

```shell
sudo rm /etc/default/grub.d/99_breeze-grub.cfg
sudo update-grub
```
  To revert back to the orignal KDE Neon theme, set the `GRUB_THEME` value in `/etc/default/grub` to `/boot/grub/themes/breeze/theme.txt`.

## Install theme in Ventoy

Extract `Ventoy.tar` to `/ventoy/theme`

Locate `ventoy.json` file in `/plugin/ventoy/` directory and change:

```
"file": "/ventoy/theme/blur/theme.txt",
```

to

```
"file": "/ventoy/theme/Ventoy/theme.txt",
```

For more information, head over to the [Ventoy website](https://www.ventoy.net/en/plugin_theme.html).

# To-do list

| Feature                   | Status        |
|---------------------------|---------------|
| 4K & 2K displays support  | In the future |
| Ultrawide display support | In the future |
