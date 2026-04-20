using Godot;
using System;
using System.ComponentModel;
namespace AWSLib.ConstructsLib{

	public abstract class Structure{
		public int identity { get; }
		public int[][][] composition { get; set;}
		public int[][] components { get; set; }
		public float mass { get; set;}
	}

    public class Spacecraft : Structure{
		
    }

    public static class Constructs{
		public static Spacecraft CreateShip()
		{
			Spacecraft createdCraft = new Spacecraft();
			return createdCraft;
		}

		public static void AddComponent(AWSLib.Components.GeneralComponent component,Structure structure){
			//if(IsSpaceOccupied)
		}

		public static Boolean IsSpaceOccupied(int[][][][] matrix,int[] dimensions, int[] position,int zLayer){
			Boolean occupied = false;
			for (int x = position[0]; x < dimensions[0] + position[0]; x++){
				for (int y = position[0]; y < dimensions[0] + position[0]; y++){
					if(MatrixesLib.Matrixes.Search(matrix,x,y,zLayer,1)>0){
						occupied = true;
					}
				}
			}
			return occupied;
		}
	}
}
