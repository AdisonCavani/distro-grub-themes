# Distro Grub Themes

A pack of GRUB2 themes for each Linux distribution
 
## Supported distributions
- Arch Linux
- Debian
- ElementaryOS
- Fedora
- Linux Mint
- Manjaro
- openSUSE
- Pop! OS
- Solus
- Ubuntu

## Preview theme

<p float="left">
<img src="https://raw.githubusercontent.com/AdisonCavani/grub-theme/master/preview/Arch%20Linux.png" width="49%"/>
<img src="https://raw.githubusercontent.com/AdisonCavani/grub-theme/master/preview/Debian.png" width="49%"/>
</p>
<p float="left">
<img src="https://raw.githubusercontent.com/AdisonCavani/grub-theme/master/preview/ElementaryOS.png" width="49%"/>
<img src="https://raw.githubusercontent.com/AdisonCavani/grub-theme/master/preview/Fedora.png" width="49%"/>
</p>
<p float="left">
<img src="https://raw.githubusercontent.com/AdisonCavani/os-grub-themes/master/preview/Linux%20Mint.png" width="49%"/>
<img src="https://raw.githubusercontent.com/AdisonCavani/os-grub-themes/master/preview/Manjaro.png" width="49%"/>
</p>
<p float="left">
<img src="https://raw.githubusercontent.com/AdisonCavani/os-grub-themes/master/preview/openSUSE.png" width="49%"/>
<img src="https://raw.githubusercontent.com/AdisonCavani/os-grub-themes/master/preview/popOS.png" width="49%"/>
</p>
<p float="left">
<img src="https://raw.githubusercontent.com/AdisonCavani/os-grub-themes/master/preview/Solus.png" width="49%"/>
<img src="https://raw.githubusercontent.com/AdisonCavani/os-grub-themes/master/preview/Ubuntu.png" width="49%"/>
</p>

## Installation

In order to clone repository from Github you have to install `git` package <br>
Alternatively you can download zip package - **Code -> Download ZIP**

Clone the repository
```
git clone https://github.com/AdisonCavani/distro-grub-themes.git
```

### Install Grub Customizer

Apt
```
sudo add-apt-repository ppa:danielrichter2007/grub-customizer
sudo apt-get update
sudo apt-get install grub-customizer
```
Pacman
```
sudo pacman -S grub-customizer
```

Dnf
```
sudo dnf install grub-customizer
```

Eopkg
```
sudo eopkg install grub-customizer
```
### Install pre-made theme with Grub Customizer

- Open Grub Customizer
- Go to **Appearance settings** tab
- Select *Custom resolution* and type in your resolution. E.g: 1920x1080
- Press *Add theme* button, go to your directory, where you have cloned repository. In my case `/home/adison/distro-grub-theme`
- Select your theme located in `/themes` directory
- Save changes

### Install custom-made theme with Grub Customizer

- Edit your theme located in `/customize` folder
- With your file manager, inside edited theme directory, select all files and **create archive** with .tar or .tar.xz extension
- Open Grub Customizer
- Go to **Appearance settings** tab
- Select *Custom resolution* and type in your resolution. E.g: 1920x1080
- Press *Add theme* button, go to your directory, where you have cloned repository. In my case `/home/adison/distro-grub-theme`
- Change view settings from *Archive files* to **All files**
- Select your archive
- Save changes
