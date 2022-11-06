# Contributing guide

Thank you for investing your time in contributing to this project! :sparkles:. 

## New contributor guide

To get an overview of the project, read the [README](README.md) and [wiki page](https://github.com/AdisonCavani/distro-grub-themes/wiki).

### Project structure:

```
.
├── assets                       - assets for creating background images
|   ├── background_template      - Photoshop project files for creating background images
|   ├── icons                    - icons that get copied to icons folder in every theme
|   └── preview_template         - Photoshop project files for creating preview images
├── customize                    - non-compressed themes
├── font                         - fonts used in each theme
├── preview                      - preview images for README.md
└── themes                       - compressed themes ready to install in .tar format
```

### Workflow

Folders that trigger new action/workflow:

- assets/icons
- customize
- font

Every time you create new commit on master branch, github action bot will update all files (as defined in [this file](https://github.com/AdisonCavani/distro-grub-themes/blob/master/.github/workflows/update-content.yml)).  
You can track your workflows [here](https://github.com/AdisonCavani/distro-grub-themes/actions).
