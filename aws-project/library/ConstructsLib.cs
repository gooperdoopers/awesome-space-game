using Godot;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace AWSLib.ConstructsLib{

	public abstract class Structure{
		public int Identity { get; }
		public int[][][][] Composition { get; set;}
		public List<int[]> Components { get; set; }
		public float Mass { get; set;}
	}

    public class Spacecraft : Structure{
		public RigidBody3D Root { get;}
    }

    public static class Constructs{
		public static Node3D visualTemp;

		public static Spacecraft CreateShip(int[] size){
			Spacecraft createdCraft = new Spacecraft();
			createdCraft.Composition = MatrixesLib.Matrixes.Create(size[0],size[1],3,10);
			createdCraft.Components = new List<int[]>();
			return createdCraft;
		}

		public static void AddComponent(AWSLib.ComponentsLib.GeneralComponent component, Structure vessel, int[] position){
			for (int rectangle = 0; rectangle < component.OccupyingSpace.Count(); rectangle++){
				int xSize = component.OccupyingSpace[rectangle][1][0]-component.OccupyingSpace[rectangle][0][0];
				int ySize = component.OccupyingSpace[rectangle][1][1]-component.OccupyingSpace[rectangle][0][1];

				int xPosition = component.OccupyingSpace[rectangle][0][0]+position[0];
				int yPosition = component.OccupyingSpace[rectangle][0][1]+position[1];
			if(IsSpaceOccupied(vessel.Composition,[xSize,ySize],[xPosition,yPosition],component.ZType))
			{;return;}}

			int componentIndex = vessel.Components.Count;
			int[] fillData = [component.ZType,componentIndex+1];
			vessel.Components.Add(component.UniqueData);
			for (int rectangle = 0; rectangle < component.OccupyingSpace.Count(); rectangle++){
				int xSize = component.OccupyingSpace[rectangle][1][0]-component.OccupyingSpace[rectangle][0][0];
				int ySize = component.OccupyingSpace[rectangle][1][1]-component.OccupyingSpace[rectangle][0][1];

				int xPosition = component.OccupyingSpace[rectangle][0][0]+position[0];
				int yPosition = component.OccupyingSpace[rectangle][0][1]+position[1];
				MatrixesLib.Matrixes.Fill(vessel.Composition,fillData,[xSize,ySize],[xPosition,yPosition]);
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
			for (int x = 0; x < vessel.Composition.Length; x++){
				for (int y = 0; y < vessel.Composition[0].Length; y++){
					if (vessel.Composition[x][y][1][0] > 0){
						Node3D instacomponent = (Node3D)visualTemp.Duplicate();
						visualTemp.GetNode<Node3D>("../ship").AddChild(instacomponent);
						instacomponent.Name = ("x"+x+"y"+y);
						// instacomponent.Scale = new Vector3(1,1,1);
						instacomponent.Position = new Vector3((float)x*4,0,(float)y*4);
					}
				}
			}
		}

	}
}
