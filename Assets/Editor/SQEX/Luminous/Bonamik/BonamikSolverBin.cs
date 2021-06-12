using System;
using System.Diagnostics;

namespace SQEX.Luminous.Bonamik
{
    [DebuggerDisplay("{GroupName}")]
    public class BonamikSolverBin
    {
        public BonamikSolverBin(uint groupId, string groupName, uint tagId, uint collisionTagId, bool isEnable, bool isEnableGround, float lodDistance, uint colIter, uint consIter, uint coneIter, uint linkIter, uint solverIter)
        {
            GroupId = groupId;
            GroupName = groupName ?? throw new ArgumentNullException(nameof(groupName));
            TagId = tagId;
            CollisionTagId = collisionTagId;
            IsEnable = isEnable;
            IsEnableGround = isEnableGround;
            LodDistance = lodDistance;
            ColIter = colIter;
            ConsIter = consIter;
            ConeIter = coneIter;
            LinkIter = linkIter;
            SolverIter = solverIter;
        }

        public uint GroupId { get; }
        public string GroupName { get; }
        public uint TagId { get; }
        public uint CollisionTagId { get; }
        public bool IsEnable { get; }
        public bool IsEnableGround { get; }
        public float LodDistance { get; }
        public uint ColIter { get; }
        public uint ConsIter { get; }
        public uint ConeIter { get; }
        public uint LinkIter { get; }
        public uint SolverIter { get; }
    }
}
