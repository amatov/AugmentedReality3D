### Augmented reality

This is an application I developed for smartphones, smart glasses, laptops, and desktop computers
C# code I wrote in 2017

## Quick start

This repository contains a Unity/C# augmented reality application for
smartphones, smart glasses, laptops, and desktop computers. It overlays real-time weather forecast information -- icons for
sun, rain, wind, and other metrics -- on the live camera view of the
area the device is pointed at; this is demonstrated in the videos in
[`media/`](media/). Building the project requires the Unity ARKit Plugin (see
[DEPENDENCIES.md](DEPENDENCIES.md)).

## Repository contents

- `ARMap.unity`, `ARMapTouch.unity`, `cloud_scene.unity` -- Unity scene
  files.
- `TouchManager.cs` -- touch-input handling; depends on the Unity ARKit
  Plugin (`UnityEngine.XR.iOS`, `UnityARHitTestExample`; see
  DEPENDENCIES.md).
- `PanWM.cs`, `ParticlePainter.cs`, `particleAttractor*.cs`,
  `rotation.cs`, `SpinningCube.cs`, `transparency.cs`, `visibility.cs`
  -- supporting Unity scripts.
- [`media/`](media/) -- demonstration videos of the app in use, including the
  weather-forecast overlay.
- **License:** see [LICENSE](LICENSE) -- research/educational use.

## About

The app reads the weather forecast for the area the phone or iPad is pointed at and overlays on the phone screen icons for the sun, rain, wind, etc., with the air temperature and other metrics in real time
For detailed information, see: https://www.researchgate.net/publication/382593670_Quantitative_Video_Microscopy_in_Medicine

