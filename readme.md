This repository contains the following Oxygen Not Included mods:

- [Resize Dup UI](https://steamcommunity.com/sharedfiles/filedetails/?id=2549295369)
- [Taller Mods Menu](https://steamcommunity.com/sharedfiles/filedetails/?id=2553830824)

# Development & Build

Create a "lib" directory at the repository root and copy the following assemblies from your ONI install: \OxygenNotIncluded\OxygenNotIncluded_Data\Managed\:

- 0Harmony.dll
- Assembly-CSharp-firstpass.dll
- Assembly-CSharp.dll
- Newtonsoft.Json.dll
- Unity.TextMeshPro.dll
- UnityEngine.CoreModule.dll
- UnityEngine.dll
- UnityEngine.ImageConversionModule.dll
- UnityEngine.InputLegacyModule.dll
- UnityEngine.TextRenderingModule.dll
- UnityEngine.UI.dll
- UnityEngine.UIModule.dll
- UnityEngine.UnityWebRequestModule.dll

"Build" the solution to deploy the Mod to your Mods\Dev directory.

A post-build action deploys the mod .dll (ILMerged with PLib) and .yaml files.