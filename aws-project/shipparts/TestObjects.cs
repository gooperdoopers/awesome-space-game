using Godot;
using System;

namespace AWSLib.ComponentsLib{
    public class awesomeMachine : GeneralComponent
    {
        public override string name => "awesome machine";

        // the 2nd array should have 2 elements where the difference between each corresponding index is the size
        public override int[][][] occupyingSpace => [[[0,2],[6,4]],[[2,0],[4,6]]];

        public override int zType => 1;

        public override int[] uniqueData => [2,2];
    }
}
