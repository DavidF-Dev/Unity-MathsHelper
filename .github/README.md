# Maths & Random Helper Functions for Unity
This asset contains a series of maths & random helper functions to assist in calculations in your games.

## Setup
Simply import the package into your project and you're good to go. No additional setup is required.
- Download directly from the [releases](https://github.com/DavidF-Dev/Unity-MathsHelper/releases) tab & import in Unity (<i>Assets>Import Package</i>).
- Import via the Unity package manager (<i>Window>Package Manager</i>).
  - Git URL: ``https://github.com/DavidF-Dev/Unity-MathsHelper.git``</br>
  - <i>Or</i> add the following line to <i>Packages/manifest.json</i>:</br>``"com.davidfdev.maths": "https://github.com/DavidF-Dev/Unity-MathsHelper.git"``

## Usage
To access the scripts, include the ``DavidFDev.Maths`` namespace to access the ``MathsHelper`` and ``RandomHelper`` static classes.</br>
Or, alternatively, use ``using static DavidFDev.Maths.MathsHelper`` and ``using static DavidFDev.Maths.RandomHelper`` to use the methods without needing to specify the classname (e.g. ``NextBool()`` instead of ``RandomHelper.NextBool()``).

The ``MathsHelper`` class contains many helpful maths methods, such as:
- ``Approach / ApproachAngle : float``
- ``Reduce / ReduceAngle : float``
- ``Sign / SignThreshold : float``
- ``Map10 / Map01 / Map : float``
- ``GetAngle / GetAngleBetween : float``
- ``RotateVector : Vector2``

</br>The ``RandomHelper`` class contains various methods for retrieving random values, such as:
- ``Next : bool/float/int/Angle/Colour/Vector2/Vector3``
- ``Range : float/Vector2/Vector3``
- ``MinusOneToOne / MinusOneOrOne() : float``
- ``Chance : bool``
- ``Choose : Element``

## Contact
If you have any questions or would like to get in contact, shoot me an email at contact@davidfdev.com. Alternatively, you can send me a direct message on Twitter at [@DavidF_Dev](https://twitter.com/DavidF_Dev).</br></br>
Consider showing support by [buying me a bowl of spaghetti](https://www.buymeacoffee.com/davidfdev) 🍝</br>
View my other Unity tools on my [website](https://www.davidfdev.com/tools) 🔨
