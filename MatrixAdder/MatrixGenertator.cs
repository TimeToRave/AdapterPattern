using System;

namespace MatrixAdder
{
    public class MatrixGenerator
    {
        public void WriteRandomMatricesToFile(int sizeX, int sizeY)
        {
            var matrixString = $"{GenerateMatrix(sizeX, sizeY)}#{GenerateMatrix(sizeX, sizeY)}";
            
            FileOperator fileOperator = new FileOperator();
            fileOperator.WriteTextToFile("F3.txt", matrixString);
        }
        
        private Matrix GenerateMatrix(int sizeX, int sizeY) 
        {
            Random random = new Random();
            int[,] result = new int[sizeX, sizeY];
            
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    result[i, j] = random.Next(-1000, 1000);
                }
            }

            return new Matrix(result);
        }
    }
}