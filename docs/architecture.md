# 🏗️ VR Physics Lab — Architecture Overview

## High-Level Architecture

```
┌───────────────────────────────────────────────────────────────────────┐
│                     VR Physics Lab                                    │
├────────────────────┬─────────────────┬─────────────────────────┤
│  Experiment Manager  │  Physics Engine  │    VR Interaction Layer      │
├────────────────────┼─────────────────┼─────────────────────────┤
│  Newton's Laws      │  Unity Physics  │  Meta XR SDK               │
│  Gravity            │  Rigidbody      │  XR Interaction Toolkit    │
│  Energy Conserv.    │  Colliders      │  OpenXR                    │
│  Collisions         │  Joints         │  Hand Tracking             │
└────────────────────┴─────────────────┴─────────────────────────┘
```

## Core Systems

### 1. Experiment Manager
Central controller for loading, running, and transitioning between physics experiments.

- `ExperimentManager.cs` — singleton managing experiment lifecycle
- `ExperimentBase.cs` — abstract base class all experiments inherit from
- `ExperimentConfig` — ScriptableObject for per-experiment settings

### 2. Physics Simulation Layer
Builds on top of Unity's built-in physics engine with custom extensions for educational feedback.

- Real-time force/velocity/energy visualization
- Slow-motion replay system
- Data recording for post-experiment review

### 3. VR Interaction Layer
Handles all user input, locomotion, and object manipulation.

- **Locomotion**: Teleport + smooth movement
- **Interaction**: Grab, push, throw, measure
- **UI**: World-space panels, hand menu

## Unity Project Structure

```
Assets/
└── _VRPhysicsLab/
    ├── Scripts/
    │   ├── Core/                  # ExperimentManager, GameManager
    │   ├── Experiments/
    │   │   ├── NewtonLaws/
    │   │   ├── Gravity/
    │   │   ├── EnergyConservation/
    │   │   └── Collisions/
    │   ├── Physics/               # Custom physics helpers
    │   ├── UI/                    # In-VR UI controllers
    │   └── Utils/                 # Shared utilities
    ├── Scenes/
    │   ├── MainMenu.unity
    │   ├── Lab_Newton.unity
    │   ├── Lab_Gravity.unity
    │   └── Lab_Energy.unity
    ├── Prefabs/
    ├── Materials/
    ├── Models/
    └── ScriptableObjects/
        └── Experiments/
```

## Performance Targets (Meta Quest 3)

| Metric | Target |
|--------|--------|
| Frame Rate | 72 fps (stable) |
| Draw Calls | < 100 per frame |
| Triangles | < 500k per frame |
| Texture Memory | < 1 GB |
| APK Size | < 500 MB |
