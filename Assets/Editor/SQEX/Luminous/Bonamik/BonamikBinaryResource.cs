using SQEX.Ebony.Std;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQEX.Luminous.Bonamik
{
    public class BonamikBinaryResource
    {
        public IList<uint> AnimBoneMap { get; } = new List<uint>();
        /*SQEX::Luminous::Bonamik::BonamikSceneManagerBin* loadedScnMngrs_;*/
        IList<BonamikSolverBin> LoadedSolvers { get; } = new List<BonamikSolverBin>();
        /*SQEX::Ebony::Std::DynamicArray<SQEX::Luminous::Bonamik::BonamikBodyBin*,2,16> loadedBodies_;
        SQEX::Ebony::Std::DynamicArray<SQEX::Luminous::Bonamik::BonamikLinkBin*,2,16> loadedLinks_;
        SQEX::Ebony::Std::DynamicArray<SQEX::Luminous::Bonamik::BonamikPlaneBin*,2,16> loadedPlanes_;
        SQEX::Ebony::Std::DynamicArray<SQEX::Luminous::Bonamik::BonamikShapeMatchingBin*,2,16> loadedShapeMatchings_;
        SQEX::Ebony::Std::DynamicArray<SQEX::Luminous::Bonamik::BonamikPossessionBin*,2,16> loadedPossessions_;*/
        public uint TotalKinematics { get; private set; }
        public uint TotalConstraints { get; private set; }
        public uint TotalCones { get; private set; }
        public uint TotalLinks { get; private set; }
        public uint TotalCollisions { get; private set; }
        public uint TotalSelfCollisions { get; private set; }
        public uint TotalChainRootParticles { get; private set; }
        public uint TotalGrassInteractBodies { get; private set; }
        public uint TotalPossessions { get; private set; }
        public bool IsValid { get; private set; }
        public uint IndexOffset { get; private set; }
        public bool IsShared { get; private set; }

        public void LoadBinaryData(byte[] data, string filename, bool isShared)
        {
            var magicStr = System.Text.Encoding.UTF8.GetString(data.Take(12).ToArray());
            if (magicStr != "Bonamik_2_47")
            {
                DefaultPrintFunction.Write($"Error loading Bonamik file. Please re-convert the bonamik file(file:{filename})");
                return;
            }

            var solvers = BitConverter.ToUInt32(data, 4 * sizeof(int));
            var bodies = BitConverter.ToUInt32(data, 5 * sizeof(int));
            var links = BitConverter.ToUInt32(data, 6 * sizeof(int));
            var planes = BitConverter.ToUInt32(data, 7 * sizeof(int));
            var shapeMatchingGroups = BitConverter.ToUInt32(data, 8 * sizeof(int));

            DefaultPrintFunction.Write($"[Bonamik] Imported : Solvers({solvers}), Bodies({bodies}), Links({links}), Planes({planes}) SM({shapeMatchingGroups})");

            this.TotalKinematics = BitConverter.ToUInt32(data, 9 * sizeof(int));
            this.TotalConstraints = BitConverter.ToUInt32(data, 10 * sizeof(int));
            this.TotalCones = BitConverter.ToUInt32(data, 11 * sizeof(int));
            this.TotalLinks = BitConverter.ToUInt32(data, 12 * sizeof(int));
            this.TotalCollisions = BitConverter.ToUInt32(data, 13 * sizeof(int));
            this.TotalSelfCollisions = BitConverter.ToUInt32(data, 14 * sizeof(int));
            this.TotalChainRootParticles = BitConverter.ToUInt32(data, 15 * sizeof(int));
            this.TotalGrassInteractBodies = BitConverter.ToUInt32(data, 16 * sizeof(int));
            this.TotalPossessions = BitConverter.ToUInt32(data, 17 * sizeof(int));

            DefaultPrintFunction.Write($"----------------- Kinematics({this.TotalKinematics}), Constraints({this.TotalConstraints}), Cones({this.TotalCones}), Links({this.TotalLinks}), Collisions({this.TotalCollisions}), Self-collisions({this.TotalSelfCollisions})");
            DefaultPrintFunction.Write($"----------------- ChainRoot({this.TotalChainRootParticles}), GrassInteract.({this.TotalGrassInteractBodies}), Possessions({this.TotalPossessions})");

            // TODO read scene managers

            // Read solvers
            var startPosition = 620;
            for (var i = 0; i < solvers; i++)
            {
                var position = startPosition;

                var groupId = BitConverter.ToUInt32(data, position);
                position += sizeof(uint);

                var groupName = ReadCString(data, position);
                position += groupName.Length + 1;

                // TODO
                startPosition += 296;
            }
        }

        private static string ReadCString(byte[] data, int offset)
        {
            var sb = new StringBuilder();
            for (var c = (char)data[offset]; c != 0;)
            {
                sb.Append(c);
                offset++;
                c = (char)data[offset];
            }

            return sb.ToString();
        }
    }
}
