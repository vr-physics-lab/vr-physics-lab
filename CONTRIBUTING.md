# 🤝 Contributing to VR Physics Lab

Thank you for your interest in contributing to **VR Physics Lab**! This is a government-funded, open-source educational project and we welcome contributions from developers, educators, 3D artists, and anyone passionate about STEM education.

---

## 📋 Table of Contents

- [Code of Conduct](#code-of-conduct)
- [How to Contribute](#how-to-contribute)
- [Development Setup](#development-setup)
- [Branch Strategy](#branch-strategy)
- [Commit Message Convention](#commit-message-convention)
- [Pull Request Process](#pull-request-process)
- [Issue Guidelines](#issue-guidelines)
- [Style Guides](#style-guides)
- [Community](#community)

---

## 📜 Code of Conduct

This project follows our [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md). By participating, you agree to uphold these standards. Please report unacceptable behavior to the maintainers.

---

## 🚀 How to Contribute

### 1. Fork & Clone

```bash
# Fork the repo on GitHub, then:
git clone https://github.com/YOUR_USERNAME/vr-physics-lab.git
cd vr-physics-lab
git remote add upstream https://github.com/vr-physics-lab/vr-physics-lab.git
```

### 2. Create a Branch

```bash
git checkout -b feature/newton-laws-experiment
# or
git checkout -b fix/gravity-simulation-bug
```

### 3. Make Your Changes

Follow the [Style Guides](#style-guides) below.

### 4. Test Your Changes

- Test in Unity Editor using Play Mode
- If possible, test on Meta Quest 3 hardware
- Ensure no compiler errors or warnings

### 5. Submit a Pull Request

Push your branch and open a PR against `develop`.

---

## 🛠️ Development Setup

### Requirements

| Tool | Version |
|------|--------|
| Unity | 2022.3 LTS |
| Meta XR SDK | Latest |
| XR Interaction Toolkit | 2.5+ |
| Git LFS | Latest |
| Blender (optional) | 3.6+ |

### Setup Steps

```bash
# Install Git LFS
git lfs install

# Pull assets
git lfs pull

# Open project in Unity Hub
# Window → Package Manager → verify all packages installed
```

---

## 🌿 Branch Strategy

| Branch | Purpose |
|--------|---------|
| `main` | Stable releases only |
| `develop` | Active development, base for PRs |
| `feature/*` | New experiments or features |
| `fix/*` | Bug fixes |
| `docs/*` | Documentation updates |
| `release/v*` | Release preparation |

**All PRs should target `develop`, not `main`.**

---

## ✍️ Commit Message Convention

We follow [Conventional Commits](https://www.conventionalcommits.org/):

```
<type>(<scope>): <short description>

[optional body]

[optional footer]
```

### Types

| Type | When to use |
|------|------------|
| `feat` | New experiment, feature, or capability |
| `fix` | Bug fix |
| `docs` | Documentation changes |
| `refactor` | Code restructure without behavior change |
| `test` | Adding or updating tests |
| `chore` | Build system, CI, dependencies |
| `assets` | 3D models, textures, audio |

### Examples

```
feat(experiments): add Newton's First Law interactive demo
fix(gravity): correct mass calculation in free fall simulation
docs(readme): update hardware requirements section
assets(models): add lab table and equipment 3D models
```

---

## 🔍 Pull Request Process

1. **Target `develop` branch** (never commit directly to `main`)
2. **Fill out the PR template** completely
3. **Link related issues** using `Closes #123`
4. **Ensure CI passes** (no build errors)
5. **Request a review** from at least one maintainer
6. **Respond to feedback** promptly

### PR Title Format

```
[Type] Short description (#issue)
```

Examples:
```
[Feat] Newton's Laws interactive experiment (#12)
[Fix] Gravity calculation off by factor of 10 (#45)
```

---

## 🐛 Issue Guidelines

### Bug Reports

Use the **Bug Report** template and include:
- Unity version and OS
- Meta Quest 3 firmware version (if applicable)
- Steps to reproduce
- Expected vs. actual behavior
- Screenshots or video if possible

### Feature Requests

Use the **Feature Request** template and include:
- Which physics topic/experiment
- Educational value
- Technical feasibility notes (if any)

---

## 🎨 Style Guides

### C# Code Style

- Follow [Microsoft C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- Use `PascalCase` for classes and public members
- Use `camelCase` for private fields (prefix with `_`)
- Add XML doc comments to all public methods
- Keep scripts focused — one responsibility per script

```csharp
/// <summary>
/// Controls the physics behavior of a lab object.
/// </summary>
public class PhysicsObject : MonoBehaviour
{
    [SerializeField] private float _mass = 1f;
    
    public float Mass => _mass;
    
    private void Start()
    {
        InitializePhysics();
    }
}
```

### Unity Project Structure

```
Assets/
├── _VRPhysicsLab/          # All project-specific assets
│   ├── Scripts/
│   │   ├── Core/
│   │   ├── Experiments/
│   │   └── UI/
│   ├── Scenes/
│   ├── Prefabs/
│   ├── Materials/
│   └── Models/
└── ThirdParty/             # External packages (do not modify)
```

### 3D Assets (Blender)

- Export as `.fbx` or `.glb`
- Keep poly count reasonable (< 10k tris for interactive objects)
- Apply transformations before export
- Use descriptive names: `lab_table_v1.fbx`

---

## 🌍 Community

- **Discussions**: [GitHub Discussions](https://github.com/vr-physics-lab/vr-physics-lab/discussions)
- **Issues**: [GitHub Issues](https://github.com/vr-physics-lab/vr-physics-lab/issues)
- **Email**: contact@vrphysicslab.org

---

Thank you for helping make physics education more immersive and accessible! 🚀
