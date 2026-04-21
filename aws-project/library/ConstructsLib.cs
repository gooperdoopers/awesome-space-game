using Godot;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace AWSLib.ConstructsLib{

	public abstract class Structure{
		public int identity { get; }
		public int[][][][] composition { get; set;}
		public List<int[]> components { get; set; }
		public float mass { get; set;}
	}

    public class Spacecraft : Structure{
		
    }

    public static class Constructs{
		public static Polygon2D visualTemp;

		public static Spacecraft CreateShip(int[] size){
			Spacecraft createdCraft = new Spacecraft();
			createdCraft.composition = MatrixesLib.Matrixes.Create(size[0],size[1],10,10);
			createdCraft.components = new List<int[]>();
			return createdCraft;
		}

		public static void AddComponent(AWSLib.ComponentsLib.GeneralComponent component, Structure vessel, int[] position){
			for (int rectangle = 0; rectangle < component.occupyingSpace.Count(); rectangle++){
				int xSize = component.occupyingSpace[rectangle][1][0]-component.occupyingSpace[rectangle][0][0];
				int ySize = component.occupyingSpace[rectangle][1][1]-component.occupyingSpace[rectangle][0][1];

				int xPosition = component.occupyingSpace[rectangle][0][0]+position[0];
				int yPosition = component.occupyingSpace[rectangle][0][1]+position[1];
			if(IsSpaceOccupied(vessel.composition,[xSize,ySize],[xPosition,yPosition],component.zType))
			{;return;}}

			int componentIndex = vessel.components.Count;
			int[] fillData = [component.zType,componentIndex+1];
			vessel.components.Add(component.uniqueData);
			for (int rectangle = 0; rectangle < component.occupyingSpace.Count(); rectangle++){
				int xSize = component.occupyingSpace[rectangle][1][0]-component.occupyingSpace[rectangle][0][0];
				int ySize = component.occupyingSpace[rectangle][1][1]-component.occupyingSpace[rectangle][0][1];

				int xPosition = component.occupyingSpace[rectangle][0][0]+position[0];
				int yPosition = component.occupyingSpace[rectangle][0][1]+position[1];
				MatrixesLib.Matrixes.Fill(vessel.composition,fillData,[xSize,ySize],[xPosition,yPosition]);
			}
		}

		public static Boolean IsSpaceOccupied(int[][][][] matrix,int[] dimensions, int[] position,int zLayer){
			Boolean occupied = false;
			for (int x = position[0]; x < dimensions[0] + position[0]; x++){
				for (int y = position[1]; y < dimensions[1] + position[1]; y++){
					if(MatrixesLib.Matrixes.Search(matrix,x,y,zLayer,0)>0){
						occupied = true;
					}
				}
			}
			return occupied;
		}

		public static void VisualizeShip(Structure vessel){
			for (int x = 0; x < vessel.composition.Length; x++){
				for (int y = 0; y < vessel.composition[0].Length; y++){
					if (vessel.composition[x][y][1][0] > 0){
						Polygon2D instacomponent = (Polygon2D)visualTemp.Duplicate();
						visualTemp.GetNode<Node2D>("../ship").AddChild(instacomponent);
						instacomponent.Name = ("x"+x+"y"+y);
						instacomponent.Scale = new Vector2(9,9);
						instacomponent.Position = new Vector2((float)x*10,(float)y*10);
					}
				}
			}
		}

	}
}
