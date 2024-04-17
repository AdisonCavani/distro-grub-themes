{
  description = "A pack of GRUB2 themes for each Linux distribution";

  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs?ref=nixos-unstable";
    flake-utils.url = "github:numtide/flake-utils";
  };

  outputs =
    { self, nixpkgs, flake-utils }:
    let
      systems = [ "aarch64-linux" "i686-linux" "x86_64-linux" ];
    in
    flake-utils.lib.eachSystem systems (
      system:
      let
        pkgs = import nixpkgs { inherit system; };
        themeNames = builtins.attrNames (builtins.readDir ./assets/backgrounds);
        themePackages = builtins.listToAttrs (builtins.map
          (theme:
            let name = (builtins.head (pkgs.lib.strings.splitString "." theme)); in {
              name = name + "-grub-theme";
              value = pkgs.callPackage ./build/default.nix { theme = name; };
            })
          themeNames);
      in
      {
        packages = {
          default = pkgs.callPackage ./build/default.nix { theme = "nixos"; };
        } // themePackages;

        devShells.default = pkgs.mkShell {
          nativeBuildInputs = with pkgs; [ nixd nixpkgs-fmt act jq ];
        };

        nixosModules.default = ./build/module.nix;
      }
    );
}
 