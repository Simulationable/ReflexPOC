using LiteDB;
using ReflexPOC.Models;

public static class Database
{
    private static readonly LiteDatabase _db = new LiteDatabase("ReflexData.db");

    public static ILiteCollection<ReflexLog> ReflexLogs =>
        _db.GetCollection<ReflexLog>("reflex_logs");

    public static void SaveLog(ReflexLog log)
    {
        ReflexLogs.Insert(log);
    }
}
