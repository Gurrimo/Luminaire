using SQEX.Ebony.Std;
using System.Collections.Generic;

namespace SQEX.Luminous.GraphicsLoad
{
    public class LmGfxBin_V1
    {
        public uint Version { get; private set; }
        public ulong Timestamp { get; private set; }
        private IDictionary<string, string> Metadata { get; } = new Dictionary<string, string>();
        private ISet<DependencyRef> Dependencies { get; } = new HashSet<DependencyRef>();
               
        public bool Load(LmMsgPck msg, IDictionary<string, byte[]> dependencies)
        {
            this.Version = (uint)msg.Read();
            if (this.Version < 1)
            {
                DefaultPrintFunction.Write($"[LmGfxBin_V1]Version {this.Version}");
                return false;
            }
            else if (this.Version > 20160705)
            {
                DefaultPrintFunction.Write($"[LmGfxBin_V1]Version {this.Version}");
            }
            else if (this.Version < 20150713)
            {
                DefaultPrintFunction.Write($"[LmGfxBin_V1]Version {this.Version}");
                return false;
            }

            var dependencyRefCount = msg.ReadMapCount();
            for(var _ = 0; _ < dependencyRefCount; _++)
            {
                // TODO: This is actually Metadata, not Dependencies
                var dependencyRef = UnpackDependencyRef(msg);
                this.Dependencies.Add(dependencyRef);

                if (ulong.TryParse(dependencyRef.HashValue, out ulong parsedHash))
                {
                    // msg.UserData.DependencyTable.Put(parsedHash, dependencies[dependencyRef.Path]);
                }
            }

            // Next up is a repeat of all the hashes; skip them
            // ReadArrayCount is the problem fyi
            msg.UnpackArraySize(out int hashArrayCount);
            var hashes = new List<ulong>();
            for(var _ = 0; _ < hashArrayCount; _++)
            {
                var hash = msg.ReadUint64();
                hashes.Add(hash);
            }

            //msg.Skip(hashArrayCount * 9);

            return true;
        }

        private static DependencyRef UnpackDependencyRef(LmMsgPck msg)
        {
            var hash = msg.ReadString();
            var path = msg.ReadStr8();
            return new DependencyRef(path, hash);
        }
    }
}
