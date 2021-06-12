using System.Diagnostics;

namespace SQEX.Luminous.GraphicsLoad
{
    [DebuggerDisplay("{Path}")]
    public class DependencyRef
    {
        public string Path { get; }
        public string HashValue { get; }

        public DependencyRef(string path, string hashValue)
        {
            this.Path = path;
            this.HashValue = hashValue;
        }
    }
}
