# ReflexPOC: A Reflex-Orchestrated Companion AI System
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.15481782.svg)](https://doi.org/10.5281/zenodo.15481782)

ReflexPOC is a modular, reflex-oriented architecture for emotionally-aware NPCs. Designed with a layered behavioral control structure, ReflexPOC separates immediate reflex reactions, cognitive safety checks, trust-based overrides, and recovery behavior from generative language reasoning.

## 🔧 Installation

Requirements:
- .NET 8+ SDK
- OpenAI API Key (if using with external LLM; stubbed by default)

Run locally:

```bash
dotnet restore
dotnet run
```

## 🚀 Example Usage

On running, the system will prompt you to select a personality and enter user dialogue:

```
> Select personality: 3 (Empathetic)
> Enter message: I don’t want to talk to anyone...
>> Companion: I'm here with you. Take a breath. You're not alone.
```

## 📄 Citation

If you use this work in your research, cite as:

```
@software{klangkasame2025reflexpoc,
  author = {Thanakan Klangkasame},
  title = {ReflexPOC: A Reflex-Orchestrated Ecosystem for Emotion-Aware NPC Systems},
  year = 2025,
  url = {https://github.com/Simulationable/ReflexPOC},
  note = {Submitted to the Journal of Open Source Software}
}
```

## 📝 License

This project is licensed under the MIT License.
