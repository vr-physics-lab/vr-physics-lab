# 🏢 GitHub Organization Structure

## Organization: `vr-physics-lab`

URL: `https://github.com/vr-physics-lab`

---

## Repositories

### Core Repositories

| Repository | Description | Visibility |
|-----------|-------------|------------|
| `vr-physics-lab` | Main Unity project (core VR app) | Public |
| `vr-physics-lab-sdk` | Reusable VR physics SDK for Unity | Public |
| `vr-physics-lab-docs` | Documentation website (GitHub Pages) | Public |
| `vr-physics-lab-assets` | Open-source 3D assets & textures | Public |

### Ecosystem Repositories (future)

| Repository | Description | Visibility |
|-----------|-------------|------------|
| `vr-physics-lab-web` | Teacher dashboard web app | Public |
| `vr-physics-lab-mobile` | Mobile companion app | Public |
| `vr-physics-experiments` | Community experiment contributions | Public |
| `.github` | Org-level profile, community health files | Public |

---

## Organization Profile (`.github` repo)

Create a `.github` repository in the organization with:

```
.github/
├── profile/
│   └── README.md          # Org profile shown on GitHub
├── CONTRIBUTING.md        # Default for all repos
├── CODE_OF_CONDUCT.md     # Default for all repos
└── SECURITY.md            # Default for all repos
```

---

## Organization README (`profile/README.md`)

This appears on the org homepage at `github.com/vr-physics-lab`:

```markdown
# 🔬 VR Physics Lab

> Open-source VR physics education platform for schools & universities.
> Government-funded | Unity + Meta Quest 3 | Built in Uzbekistan

## Our Mission
Make quality STEM education accessible to every student through virtual reality.

## Repositories
- 🏗️ [vr-physics-lab](../vr-physics-lab) — Main Unity application
- 📦 [vr-physics-lab-sdk](../vr-physics-lab-sdk) — Reusable physics SDK
- 🎨 [vr-physics-lab-assets](../vr-physics-lab-assets) — Open 3D assets
- 📖 [vr-physics-lab-docs](../vr-physics-lab-docs) — Documentation

## Funded by
🇸🏳️ Republic of Uzbekistan — "Bo'lajak olim" Innovation Grant
```

---

## Team Structure

| Team | Members | Access |
|------|---------|--------|
| `maintainers` | Core team | Admin on all repos |
| `contributors` | Active contributors | Write on feature branches |
| `docs-team` | Documentation writers | Write on docs repo |
| `assets-team` | 3D artists | Write on assets repo |

---

## Labels Strategy

Standard labels across all repositories:

| Label | Color | Purpose |
|-------|-------|---------|
| `bug` | `#d73a4a` | Something isn't working |
| `enhancement` | `#a2eeef` | New feature or request |
| `experiment` | `#e4e669` | New physics experiment |
| `documentation` | `#0075ca` | Documentation improvement |
| `good first issue` | `#7057ff` | Good for newcomers |
| `help wanted` | `#008672` | Extra attention needed |
| `needs-triage` | `#e11d48` | Needs review by maintainer |
| `in-progress` | `#f97316` | Being worked on |
| `blocked` | `#6b7280` | Blocked by dependency |
| `assets` | `#84cc16` | 3D model / texture work |
| `performance` | `#f59e0b` | Quest 3 optimization |
