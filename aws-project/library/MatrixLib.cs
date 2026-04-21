using System.Linq;
using Godot;

namespace AWSLib.MatrixesLib{
	public static class Matrixes{
		public enum FillType{
			force,
			add
		}
		public static int[][][][] Create(int xSize, int ySize, int zSize, int wSize){
			int[][][][] matrix = new int[xSize][][][];
			//Fills each layer so all coordinates are satified
			for (int x = 0; x < xSize; x++){
				matrix[x] = new int[ySize][][];

				for (int y = 0; y < ySize; y++){
					matrix[x][y] = new int[zSize][];

					for (int z = 0; z < zSize; z++){
						matrix[x][y][z] = new int[wSize];

						for (int w = 0; w < wSize; w++){
							matrix[x][y][z][w] = 0;
            			}
					}
				}
            }

			return matrix;//xLayer is equivilant to the Matrix
		}

		public static int Search(int[][][][] matrix,int x, int y, int z,int w){
			int coordinateData = matrix[x][y][z][w];
			return coordinateData;
		}

		public static void Fill(int[][][][] matrix, int[] data, int[] dimensions, int[] position){
			int z = data[0]; // which layer on the z layer should we write our data on i.e. floor, wall, wire?
			int writeInt = data[1];
			for (int x = position[0]; x < dimensions[0] + position[0]; x++){
				for (int y = position[1]; y < dimensions[1] + position[1]; y++){
					matrix[x][y][z][0] = writeInt;
					//matrix[x][y][z].OrderDescending();
				}
			}
		}
	}
}
