{
  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs/nixos-25.05";
    systems.url = "github:nix-systems/default";
    parts = {
      url = "github:hercules-ci/flake-parts";
      inputs.nixpkgs-lib.follows = "nixpkgs";
    };
  };

  outputs =
    inputs:
    inputs.parts.lib.mkFlake { inherit inputs; } {
      systems = import inputs.systems;

      perSystem =
        {
          config,
          pkgs,
          ...
        }:
        let
          pname = "FS.FluentUI";
          version = "0.1.0";
          dotnet-sdk = pkgs.dotnetCorePackages.sdk_8_0_3xx;
        in
        {
          devShells = {
            default = pkgs.mkShell {
              name = "FS.FluentUI";
              buildInputs = [ dotnet-sdk pkgs.nodejs ];
              packages = with pkgs; [
                fantomas
                fsautocomplete
              ];
            };
            cd = pkgs.mkShellNoCC {
              packages = with pkgs; [
                sd
                docker
              ];
            };
          };
        };
    };
}
