using ReflexPOC.Data;
using ReflexPOC.Controllers;
using System;
using System.IO;
using System.Threading.Tasks;
using ReflexPOC.Enums;
using ReflexPOC.Models;

string? openaiKey = null;
try
{
    openaiKey = File.ReadAllText("openai.key").Trim();
}
catch
{
    Console.WriteLine("Missing openai.key");
    return;
}

NpcPersonality personality = NpcPersonality.Cheerful;

Console.WriteLine("Select AI Personality before chatting:");
Console.WriteLine("1 = Cheerful (positive & playful)");
Console.WriteLine("2 = Stoic (calm & reserved)");
Console.WriteLine("3 = Empathetic (warm & caring)");
Console.WriteLine("4 = Playful (witty & teasing)");
Console.WriteLine("5 = Tsundere (tough but secretly cares)");
Console.Write("Choose (1-5) and press Enter: ");
var personStr = Console.ReadLine();
switch (personStr?.Trim())
{
    case "2": personality = NpcPersonality.Stoic; break;
    case "3": personality = NpcPersonality.Empathetic; break;
    case "4": personality = NpcPersonality.Playful; break;
    case "5": personality = NpcPersonality.Tsundere; break;
    default: personality = NpcPersonality.Cheerful; break;
}

var openai = new OpenAIClient(openaiKey);
var npc = new NpcReflexController(openai, personality);
var behavior = new AIBehaviorModel();
var gatekeeper = new CognitiveGatekeeperController();
var supporter = new CompanionSupportController();
var tokenUnlock = new TokenUnlockController();
var recovery = new RecoveryReflexController();
var state = new PlayerState();

Console.WriteLine("=== Reflex NPC Chat (Type Enter on empty line to exit) ===");
while (true)
{
    Console.Write("\nYou: ");
    string msg = Console.ReadLine() ?? "";
    if (string.IsNullOrWhiteSpace(msg)) break;

    state.LastMessage = msg;
    var (stress, lonely) = await openai.AnalyzeEmotionAsync(msg);
    state.Stress = stress;
    state.Loneliness = lonely;

    // Gatekeeper
    bool abnormal = gatekeeper.DetectAbnormal(state, msg);

    // Token unlock
    tokenUnlock.TryUnlock(state);

    // Recovery
    recovery.TryRecovery(state);

    // Support Layer
    if (supporter.NeedsSupport(state))
        Console.WriteLine("🫂 [Support Mode]: NPC will stay with you and help you recover.");

    // Token Reflex Unlock
    if (state.TokenUnlocked)
        Console.WriteLine("🔓 [Token Unlock]: You now have unlimited access to the companion's help.");

    // Recovery Reflex
    if (state.RecoveryMode)
    {
        Console.WriteLine("🌀 [Recovery Reflex]: NPC is gently stepping back to let you grow.");
        state.RecoveryMode = false; // only show once
        continue;
    }

    // NPC Reflex/AI Decision
    if (abnormal)
        Console.WriteLine("🕵️‍♀️ [Gatekeeper]: Detected abnormal/critical mental state!");

    if (behavior.ShouldBeSilent(state))
        Console.WriteLine("🤐 [NPC Reflex]: NPC stays silent to respect your space.");
    else
    {
        string npcReply = await npc.ReplyAsync(state);
        Console.WriteLine($"\nNPC: {npcReply.Trim()}");
    }
    Console.WriteLine($"(status: stress={state.Stress:0.00} lonely={state.Loneliness:0.00})");
}
Console.WriteLine("Chat ended.");
