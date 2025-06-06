using Modding;

namespace GrubSpoiler
{
    public class GrubSpoiler : Mod
    {
        new public string GetName() => "GrubSpoiler";
        public override string GetVersion() => "1.0.0.0";
        public override void Initialize()
        {
            CondensedSpoilerLogger.AddCategory("Grubs", () => true, ["Grub"]);
            Log("Grub.");
        }
    }
}