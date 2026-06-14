# 🚀 Release Strategy

## Versioning

VR Physics Lab follows [Semantic Versioning](https://semver.org/):

```
v<MAJOR>.<MINOR>.<PATCH>

v0.1.0  — First working experiment
v0.2.0  — New experiment added
v0.2.1  — Bug fixes
v1.0.0  — Full prototype (stable)
```

- **MAJOR**: Breaking changes or architectural overhaul
- **MINOR**: New experiment or significant feature
- **PATCH**: Bug fixes, performance improvements

---

## Branch → Release Flow

```
feature/* ──┬──> develop ──┬──> release/v* ──> main ──> tag v*
fix/*    ──┘             └───────────────────┘
```

1. Features merge into `develop`
2. Create `release/v0.x.x` branch from `develop`
3. QA testing on release branch
4. Merge to `main` + tag
5. GitHub Actions auto-builds APK + creates GitHub Release

---

## Release Checklist

- [ ] All targeted issues closed
- [ ] CHANGELOG.md updated
- [ ] Version bumped in `ProjectSettings/ProjectVersion.txt`
- [ ] Tested on Meta Quest 3 hardware
- [ ] Performance validated (72 fps)
- [ ] Documentation updated
- [ ] Release notes written
- [ ] APK signed and tested

---

## Artifact Distribution

| Channel | Format | Audience |
|---------|--------|---------|
| GitHub Releases | `.apk` | Developers / testers |
| Meta App Lab | `.aab` | Schools (future) |
| SideQuest | `.apk` | Early adopters |
| Direct install | `.apk` | School pilots |

---

## Pre-release Program

Before v1.0:
- **Alpha** (`v0.x.x`) — Developers only, may be unstable
- **Beta** (`v0.9.x`) — School pilot program participants
- **RC** (`v1.0.0-rc.x`) — Final testing before stable

---

## Communication

For each release:
1. GitHub Release with full changelog
2. Update README badges and feature table
3. Post in GitHub Discussions
4. Update documentation site
