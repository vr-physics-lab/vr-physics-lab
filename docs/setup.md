# 🚀 Development Setup Guide

This guide walks you through setting up VR Physics Lab for local development.

---

## Prerequisites

### Required Software

| Software | Version | Download |
|----------|---------|----------|
| Unity Hub | Latest | [unity.com](https://unity.com/download) |
| Unity | 2022.3 LTS | via Unity Hub |
| Git | Latest | [git-scm.com](https://git-scm.com) |
| Git LFS | Latest | [git-lfs.github.com](https://git-lfs.github.com) |
| Meta Quest Developer Hub | Latest | [developer.oculus.com](https://developer.oculus.com/downloads/package/oculus-developer-hub-win) |

### Unity Modules (install via Unity Hub)
- Android Build Support
- Android SDK & NDK Tools
- OpenJDK

### Optional
- Blender 3.6+ (for 3D asset creation)
- Visual Studio 2022 or JetBrains Rider (for C# development)

---

## Step 1: Clone the Repository

```bash
# Install Git LFS first
git lfs install

# Clone
git clone https://github.com/vr-physics-lab/vr-physics-lab.git
cd vr-physics-lab

# Pull large files
git lfs pull
```

---

## Step 2: Open in Unity

1. Open **Unity Hub**
2. Click **Open** → **Add project from disk**
3. Select the cloned folder
4. Ensure Unity **2022.3 LTS** is selected
5. Click **Open**

> ⚠️ Unity may take several minutes to import assets the first time.

---

## Step 3: Configure Meta XR SDK

1. In Unity: **Window** → **Package Manager**
2. Click **+** → **Add package by name**
3. Add: `com.meta.xr.sdk.all`
4. Follow the Meta XR setup wizard

---

## Step 4: Configure Build Settings

1. **File** → **Build Settings**
2. Switch platform to **Android**
3. Set **Texture Compression** to ASTC
4. Under **Player Settings**:
   - Package name: `org.vrphysicslab.app`
   - Minimum API Level: Android 10 (API 29)
   - Target API Level: Android 12 (API 32)

---

## Step 5: Enable Developer Mode on Quest 3

1. Open the **Meta Quest mobile app**
2. Go to **Menu** → **Devices** → your Quest 3
3. Go to **Developer Mode** and toggle ON
4. Connect Quest 3 via USB-C
5. Put on the headset and **Allow USB Debugging** when prompted

---

## Step 6: Build and Run

```bash
# Verify device is connected
adb devices

# In Unity: File → Build Settings → Build and Run
```

Or use **Build and Run** directly in Unity to deploy to the connected Quest 3.

---

## Testing Without Hardware

You can test basic VR interactions in the Unity Editor using:
- **XR Device Simulator** (included with XR Interaction Toolkit)
- **Meta Quest Link** (requires Meta Quest Link app + compatible GPU)

To enable XR Device Simulator:
1. **Window** → **XR** → **XR Device Simulator**
2. Enable and use WASD + mouse to simulate VR

---

## Troubleshooting

| Problem | Solution |
|---------|----------|
| `adb devices` shows nothing | Re-plug USB, re-allow debugging in headset |
| Unity can't find Android SDK | Reinstall via Unity Hub → Installs → Add modules |
| Meta XR package errors | Run Meta XR → Project Setup Tool |
| LFS files missing | Run `git lfs pull` |

---

For more help, open an [issue](https://github.com/vr-physics-lab/vr-physics-lab/issues) or start a [discussion](https://github.com/vr-physics-lab/vr-physics-lab/discussions).
