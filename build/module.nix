{ pkgs, lib, config, ... }:
with lib;
let
  cfg = config.distro-grub-themes;
  themes = builtins.map (theme: (builtins.head (lib.strings.splitString "." theme))) (builtins.attrNames (builtins.readDir ./../assets/backgrounds));
in
{
  options.distro-grub-themes = {
    enable = mkEnableOption "Enable Distro Grub Theme";
    theme = mkOption {
      type = types.enum themes;
      default = "nixos";
      example = "arch-linux";
      description = ''
        Selected theme name.
        IMPORTANT! Theme name must be the same as in assert/backgrounds directory without the extension
      '';
    };
  };

  config = mkIf (cfg.enable)
    {
      boot.loader.grub = {
        theme = pkgs.callPackage ./default.nix { theme = cfg.theme; };
        splashImage = ./assets/splash_image.jpg;
      };
    };
}
