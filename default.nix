{ stdenvNoCC, lib, theme }:
let
  themes = builtins.map (theme: (builtins.head (lib.strings.splitString "." theme))) (builtins.attrNames (builtins.readDir ./assets/backgrounds));
in
assert builtins.any (x: x == theme) themes;

stdenvNoCC.mkDerivation {
  name = "distro-grub-themes";
  src = ./.;

  installPhase = ''
    mkdir -p $out
    cp ./assets/backgrounds/${theme}.png $out/background.png
    cp ./assets/splash_image.jpg $out/splash_image.jpg
    cp -r ./assets/icons $out
    cp -r ./assets/fonts/. $out
    cp -r ./assets/menu/. $out
    cp -r ./assets/theme.txt $out
  '';

  meta = with lib; {
    homepage = "https://github.com/AdisonCavani/distro-grub-themes";
    description = "A pack of GRUB2 themes for each Linux distribution";
    license = licenses.gpl3;
    maintainers = with maintainers; [ zakuciael ];
    platforms = platforms.linux;
  };
}
