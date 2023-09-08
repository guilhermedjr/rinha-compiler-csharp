using RinhaCompiler.Enums;

namespace RinhaCompiler;

public class File
{
    public string Name { get; set; }
    public Term Expression { get; set; }
    public Loc Location { get; set; }
}
