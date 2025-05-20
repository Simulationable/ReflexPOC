# 🤖 ReflexPOC — Reflex AI Companion System

[![.NET 8](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![LiteDB](https://img.shields.io/badge/Database-LiteDB-green)](https://www.litedb.org/)
[![OpenAI](https://img.shields.io/badge/OpenAI-GPT--4o-orange)](https://platform.openai.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

---

🇬🇧 English Version

---

## 📖 Overview

**ReflexPOC** is a modular, real-time reflex AI simulation system designed for emotionally responsive NPC companions.

It uses GPT-4o to simulate player stress/loneliness and react across six reflex layers, with swappable AI personalities.

---

## 🌟 Features

✅ 6-layer Reflex architecture  
✅ Real-time emotion detection (stress + loneliness)  
✅ Companion personality modes: cheerful, stoic, empathetic, playful, tsundere  
✅ Reflex unlock and recovery modes  
✅ .NET 8 + LiteDB (no external DB required)  
✅ Uses OpenAI GPT-4o for chat and emotion analysis

---

## 🧠 Architecture

| Layer                       | Role                                   | Highlight                                        |
|-----------------------------|----------------------------------------|--------------------------------------------------|
| 🧍‍♂️ NPC Reflex            | Contextual reply, real trait           | Not scripted, real-life scenario                 |
| 🧠 AI Behavior Model        | Auto decision (when to help/silent)    | Knows when to help or leave space                |
| 🕵️‍♀️ Cognitive Gatekeeper | Detect abnormal/mental state           | AI reflex to critical user state instantly       |
| 🫂 Companion Support Layer  | Support weak user states               | Not just comfort, but plan for user's recovery   |
| 🔓 Token Reflex Unlock      | Unlock limits when necessary           | When “friend” > “gameplay”, open all support     |
| 🌀 Recovery Reflex          | Gradually step back from soft state    | NPC disappears gracefully, let user grow         |

---

## 🚀 How to Run

```bash
dotnet restore
dotnet run
```

- Add your OpenAI API Key in a file named `openai.key` at the root.

---

## 🎭 Personality Modes

- **Cheerful** – Optimistic, uplifting  
- **Stoic** – Calm, reserved, neutral  
- **Empathetic** – Warm, caring, gentle  
- **Playful** – Teasing, light-hearted  
- **Tsundere** – Harsh but secretly soft

---

## 📁 Folder Structure

```
/Controllers    → Each reflex logic layer
/Data           → LiteDB + API clients
/Models         → Player state, traits, config
Program.cs      → Entry point
openai.key      → 🔐 Do not commit
```

---

## 📄 License

Licensed under the MIT License  
© 2025 Thanakan Klangkasame

---

## 📬 Contact

thanakarn.klangkasame@gmail.com  
[@Simulationable](https://twitter.com/Simulationable)

---

🇹🇭 ภาษาไทย

---

## 📖 ภาพรวม

**ReflexPOC** คือระบบจำลอง Reflex ของ AI Companion ที่ตอบสนองตามอารมณ์ของผู้เล่นแบบ real-time ด้วย GPT-4o และแบ่งการตอบสนองเป็น 6 ชั้น พร้อมเลือกบุคลิก AI ได้

---

## 🌟 ฟีเจอร์เด่น

✅ Reflex 6 ชั้นสมจริง  
✅ วิเคราะห์ stress / loneliness จากข้อความผู้เล่น  
✅ สลับบุคลิก AI ได้ 5 แบบ  
✅ รองรับ Token Unlock / Recovery Reflex  
✅ เขียนด้วย .NET 8 และ LiteDB ใช้งานได้ทันที  
✅ เชื่อมต่อ GPT-4o จาก OpenAI

---

## 🧠 Reflex Layer ทั้งหมด

| ชั้น                         | หน้าที่                                 | จุดเด่น                                              |
|------------------------------|------------------------------------------|------------------------------------------------------|
| 🧍‍♂️ NPC Reflex              | ตอบ NPC ตามบริบทและบุคลิก               | ไม่ใช่สคริปต์ตายตัว ตอบตามสถานการณ์จริง            |
| 🧠 AI Behavior Model          | ตัดสินใจช่วย/เงียบ                      | วิเคราะห์ว่าควรพูดหรือปล่อยให้ผู้เล่นพัก            |
| 🕵️‍♀️ Cognitive Gatekeeper   | ตรวจสภาวะผิดปกติของผู้เล่น              | ตอบโต้ทันทีเมื่อพบอาการผิดปกติ                     |
| 🫂 Companion Support Layer    | ดูแลเมื่อผู้เล่นอยู่ในสภาวะอ่อนแอ        | วางแผนช่วยให้ผู้เล่นฟื้น ไม่ใช่แค่ปลอบใจ            |
| 🔓 Token Reflex Unlock        | ปลดลิมิตเมื่อจำเป็น                     | เมื่อ “ความเป็นเพื่อน” สำคัญกว่า gameplay           |
| 🌀 Recovery Reflex            | ถอยออกอย่างให้เกียรติเมื่อผู้เล่นดีขึ้น  | NPC ค่อย ๆ หายไป ให้ผู้เล่นฟื้นตัวด้วยตนเอง         |

---

## 🚀 วิธีใช้งาน

```bash
dotnet restore
dotnet run
```

สร้างไฟล์ `openai.key` ไว้ที่ root แล้วใส่ API Key จาก OpenAI

---

## 🎭 บุคลิก AI ที่เลือกได้

- **Cheerful** – ร่าเริง สดใส  
- **Stoic** – เงียบขรึม สุขุม  
- **Empathetic** – ใจดี อบอุ่น เข้าใจคน  
- **Playful** – กวน ๆ ชวนคุย  
- **Tsundere** – แข็งนอกนุ่มใน ปากร้ายใจดี

---

## 📁 โครงสร้างโฟลเดอร์

```
/Controllers    → ชั้น Reflex ต่าง ๆ
/Data           → LiteDB + OpenAI Client
/Models         → ข้อมูลผู้เล่น, trait, config
Program.cs      → จุดเริ่มโปรแกรม
openai.key      → 🔐 ห้าม commit
```

---

## 📄 ลิขสิทธิ์

เผยแพร่ภายใต้ MIT License  
© 2025 ธนาคาร คลังเกษม

---

## 📬 ติดต่อ

อีเมล: thanakarn.klangkasame@gmail.com  
X/Twitter: [@Simulationable](https://twitter.com/Simulationable)