---
title: 'ReflexPOC: A Reflex AI Companion System for Emotionally Responsive NPCs'
tags:
  - reflex AI
  - NPC
  - emotional AI
  - GPT-4o
  - .NET
  - LiteDB
authors:
  - name: ธนาคาร คลังเกษม
    affiliation: Independent Researcher
    orcid: 0009-0003-1581-4277
    email: thanakarn.klangkasame@gmail.com
date: 2025-05-21
---

# Summary

**ReflexPOC** is a real-time Reflex AI simulation system designed to support emotionally responsive NPCs in game and interactive environments. It integrates a six-layer reflex model capable of interpreting player states (stress and loneliness) through cognitive filtering and AI-driven decision models. Unlike traditional scripted NPCs, ReflexPOC uses GPT-4o to create emergent, personality-based interactions in both reactive and disengagement scenarios.

The architecture supports multiple AI companion types (cheerful, stoic, tsundere, etc.), and adapts its behavioral responses over time using embedded reflex triggers. Designed with modularity and local-first principles, ReflexPOC runs on .NET 8 and uses LiteDB for local data storage, requiring no external dependencies.

# Statement of need

Modern NPCs often rely on linear, script-based dialogue trees that limit immersion and adaptability. ReflexPOC addresses this gap by offering a model-agnostic, reflex-driven behavior system that leverages large language models and a cognitive gatekeeper framework for more realistic interaction. It serves developers and researchers exploring emotionally responsive AI companions, reflex layers, and human-AI affective systems.

# Installation

ReflexPOC requires .NET 8 and a GPT-4o-compatible OpenAI API key.

```bash
git clone https://github.com/Simulationable/ReflexPOC
cd ReflexPOC
dotnet build
dotnet run
```

# Example

A sample output interaction shows how a "stoic" NPC companion recognizes elevated stress in the player and chooses to disengage gently:

```
[AI-Stoic]: “I’ll stay nearby. If you need anything, you know where I am.”
```

# Repository

The source code is available at: https://github.com/your/repo

# License

MIT
