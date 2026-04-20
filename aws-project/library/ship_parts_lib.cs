using Godot;
using System;

namespace AWSLib.Components{
	public abstract class GeneralComponent{
		public abstract string name { get;}
		public abstract int[][] occupyingSpace { get;}
	}
	
	public static class Components{
		public static string get_ship_data()
		{
			return("cool");
		}
	}
}
