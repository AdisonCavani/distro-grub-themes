# Contributing guide

Thank you for investing your time in contributing to this project! :sparkles:. 

## New contributor guide

To get an overview of the project, read the [README](README.md) and [wiki page](https://github.com/AdisonCavani/distro-grub-themes/wiki).

### Project structure:

```
.
├── assets                       - assets for creating background images
|   ├── fonts                    - fonts used in each theme
|   └── icons                    - icons that get copied to icons folder in every theme
├── customize                    - non-compressed themes
├── docs                         - documentation markdown files
├── preview                      - preview images for README.md
├── themes                       - compressed themes ready to install in .tar format
└── themes.json                  - json file containing all themes definitions (used as database for wiki page)
```

### Workflow

Folders that trigger new action/workflow:

- assets
- customize

Every time you create new commit on master branch, github action bot will update all files (as defined in [this file](https://github.com/AdisonCavani/distro-grub-themes/blob/master/.github/workflows/update-content.yml)).  
You can track your workflows [here](https://github.com/AdisonCavani/distro-grub-themes/actions).

### Branches

```
├── master                       - main branch containing latest changes
├── legacy                       - obsolete C# program, replaced by Github Actions workflow
└── templates                    - PSD, phosothop templates for background images
```

### Frequently Asked Questions
**Q**: Where are `psd` templates located?  
**A**: Templates are located in [`templates`](https://github.com/AdisonCavani/distro-grub-themes/tree/templates) branch.

**Q**: How can I edit `psd` template? I don't have Photoshop  
**A**: You can import `psd` into GIMP, however this might cause to lose some Photoshop related data. I recommend to use [Photopea](https://www.photopea.com/) - free web-based Photoshop alternative.
