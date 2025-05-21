---
title: "ReflexPOC: A Reflex-Orchestrated Ecosystem Architecture for Emotion-Aware NPC Systems"
tags:
  - artificial intelligence
  - game NPC
  - reflex system
  - emotional AI
  - ASP.NET
authors:
  - name: Thanakan Klangkasame
    orcid: 0009-0003-1581-4277
    email: thanakarn.klangkasame@gmail.com
    affiliation: 1
affiliations:
  - name: Independent Researcher, Bangkok, Thailand
    index: 1
date: 2025-05-21
---

# Summary

ReflexPOC is a reflex-layered ecosystem architecture for building emotionally-aware NPCs in games and simulations. Unlike prompt-chained agents, ReflexPOC implements a six-layer decision logic including cognitive safety gates, trust unlocks, and recovery protocols to support emotionally safe interaction. The system is written in C# using .NET and is designed to be model-agnostic, composable, and locally testable.

# Statement of Need

Current NPC agents rely on monolithic LLM prompts and lack structural emotional reflex. ReflexPOC addresses this by decoupling reflex behavior, safety arbitration, and trust recovery from language generation logic.

# Installation

See README.md for installation and run instructions.

# Usage

Run `dotnet run` and interactively test different personalities and distress signals to observe reflex activations.

# Acknowledgements

Thanks to the Helion Game AI Initiative for conceptual validation.
