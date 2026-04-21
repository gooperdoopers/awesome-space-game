using Godot;
using System;
using System.Collections.Generic;

namespace AWSLib.ComponentsLib{
	public abstract class GeneralComponent{
		public abstract string name { get; }
		public abstract int[][][] occupyingSpace { get; }
		public abstract int zType { get; }
		public abstract int[] uniqueData { get; }
	}

	public static class Components{
		public  static Dictionary<string,GeneralComponent> componentDictionary= [];
		public static string get_ship_data()
		{
			return("cool");
		}
	}
}
