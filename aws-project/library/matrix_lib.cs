using Godot;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AWSLib.MatrixesLib{
	public static class Matrixes{
		public static int[][][][] Create(int xSize, int ySize, int zSize, int wSize){
			int[] wLayer = new int[wSize];
			int[][] zLayer = new int[zSize][];
			int[][][] yLayer = new int[ySize][][];
			int[][][][] xLayer = new int[xSize][][][];
			
			//Fills each layer so all coordinates are satified
			for (int i = 0; i < wSize; i++){
				wLayer.SetValue(1,i);}

			for (int i = 0; i < zSize; i++){
				zLayer.SetValue(wLayer,i);}
			
			for (int i = 0; i < ySize; i++){
				yLayer.SetValue(zLayer,i);}

			for (int i = 0; i < xSize; i++){
				xLayer.SetValue(yLayer,i);}

			return xLayer;//xLayer is equivilant to the Matrix
		}

		public static int Search(int[][][][] matrix,int x, int y, int z,int w){
			GD.Print(matrix[x][y][z][0]);
			int coordinateData = matrix[x][y][z][w];
			return coordinateData;
		}
	}
}
