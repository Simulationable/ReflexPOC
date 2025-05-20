namespace ReflexPOC.Models
{
    public class Trait
    {
        public string Name { get; set; }
        public float Intensity { get; set; } // 0 - 1

        public Trait(string name, float intensity)
        {
            Name = name;
            Intensity = intensity;
        }
    }

}
