using Godot;
using System;
using System.Collections.Generic;

namespace AWSLib.ComponentsLib{
	public abstract class GeneralComponent{
		public abstract string Name { get; }
		public abstract int[][][] OccupyingSpace { get; }
		public abstract int ZType { get; }
		public abstract int[] UniqueData { get; }
	}

	public static class Components{
		public  static Dictionary<string,GeneralComponent> componentDictionary= [];
		public static string get_ship_data()
		{
			return("cool");
		}

		public static void CompileComponents()
		{
			
		}
	}
}
