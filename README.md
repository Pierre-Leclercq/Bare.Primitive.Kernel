# Bare.Primitive.Kernel

Minimal abstractions for system-level concerns (time, identity) consumed across the Bare ecosystem.

## Status

Early-stage library. Public, usable, but the API surface is intentionally small and may evolve.

## Purpose

Provides the most foundational interfaces and default implementations needed by higher-level Bare libraries — specifically, access to the current UTC time and GUID generation. These are the kinds of dependencies that almost every layer needs but that should not be coupled to `DateTimeOffset.UtcNow` or `Guid.NewGuid()` directly.

## What is inside

| Type | Kind | Description |
|---|---|---|
| `IClock` | interface | Exposes `DateTimeOffset UtcNow` |
| `SystemClock` | class | Default implementation backed by `DateTimeOffset.UtcNow` |
| `IGuidProvider` | interface | Exposes `Guid NewGuid()` |
| `SystemGuidProvider` | class | Default implementation backed by `Guid.NewGuid()` |
| `KernelIdentity` | static class | Assembly identity constant (`Name = "Bare.Primitive.Kernel"`) |

No external NuGet dependencies. Targets .NET 8+ (or .NET 10 when available).

## Relationship to other Bare repositories

```
Bare.Primitive.Kernel        ← you are here
  └─ Bare.Primitive.UI       ← references this project
       └─ Bare.Infrastructure.Controls
            └─ Bare.Infrastructure.UI
```

`Bare.Primitive.Kernel` is the root dependency in the Bare family. It is referenced by `Bare.Primitive.UI` and, transitively, by the Infrastructure layer. No Bare repository depends on a lower layer than this one.

## What it does not try to do

- Provide application-level services (configuration, logging, DI, etc.).
- Define UI abstractions of any kind — those belong in `Bare.Primitive.UI`.
- Offer multiple clock strategies (frozen, virtual, etc.) beyond the system clock. Consumers can implement `IClock` themselves for testing.

## Build / development notes

```sh
dotnet build Bare.Primitive.Kernel.slnx
dotnet test Bare.Primitive.Kernel.slnx
```

No special build flags or external tooling required.

## License

AGPL-3.0