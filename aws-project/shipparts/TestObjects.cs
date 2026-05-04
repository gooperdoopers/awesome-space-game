using Godot;
using System;

namespace AWSLib.ComponentsLib{
    public sealed class AwesomeMachine : GeneralComponent{
        public override string Name => "awesome machine";

        // the 2nd array should have 2 elements where the difference between each corresponding index is the size
        public override int[][][] OccupyingSpace => [[[0,2],[6,4]],[[2,0],[4,6]]];

        public override int ZType => 1;

        public override int[] UniqueData => [2,2];
        public static readonly AwesomeMachine Instance = new();
        private AwesomeMachine() { }
    }

    public sealed class Thruster : GeneralComponent{
        public override string Name => "thruster";

        // the 2nd array should have 2 elements where the difference between each corresponding index is the size
        public override int[][][] OccupyingSpace => [[[0,0],[4,4]]];

        public override int ZType => 1;

        public override int[] UniqueData => [100,2];
        private static Thruster singleton;

        public static readonly Thruster Instance = new();
        private Thruster() { }
    }
}
