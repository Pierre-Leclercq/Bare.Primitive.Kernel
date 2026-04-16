# Bare.Primitive.Kernel - Spécification Initiale

## Objectif
Fournir des primitives noyau minimales, stables et portables pour les couches supérieures TUI.

## Surface API MVP
- `IClock` : abstraction du temps UTC.
- `SystemClock` : implémentation système de `IClock`.
- `KernelIdentity` : identifiant constant de package.

## Contraintes
- Compatible Windows/Linux.
- Sans dépendance UI.
- API volontairement petite (YAGNI).
