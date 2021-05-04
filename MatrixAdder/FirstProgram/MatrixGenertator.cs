using System;

namespace MatrixAdder
{
    /// <summary>
    /// Генерирует и записывает матрицы в файл
    /// </summary>
    public class MatrixGenerator : IMatricesHandler
    {
        /// <summary>
        /// Записывает сгенерированные две матрицы в один файл
        /// </summary>
        /// <param name="sizeX"></param>
        /// <param name="sizeY"></param>
        public void RunOperation(int sizeX, int sizeY)
        {
            Matrix[] matrices = PrepareMatrices(sizeX, sizeY);
            matrices = OperateMatrices(matrices);
            SaveMatrices(matrices);
        }

        /// <summary>
        /// Подготавливает пустые матрицы заданного размера
        /// </summary>
        /// <param name="sizeX">Количество строк матриц</param>
        /// <param name="sizeY">Количество столбцов матриц</param>
        /// <returns>Массив пустых матриц</returns>
        public Matrix[] PrepareMatrices(int sizeX, int sizeY)
        {
            Matrix[] matrices = {
                new Matrix(sizeX, sizeY),
                new Matrix(sizeX, sizeY)
            };
            return matrices;
        }

        /// <summary>
        /// Формирует массив матриц заданного размера
        /// </summary>
        /// <param name="matrices">Массив матриц, которые будут заполняться случайными значениями</param>
        /// <returns>Массив матриц</returns>
        public Matrix[] OperateMatrices(Matrix[] matrices)
        {
            for(int i = 0; i < matrices.Length; i++)
            {
                matrices[i] = GenerateMatrix(matrices[i]);
            }
            return matrices;
        }

        /// <summary>
        /// Выполняет запись матрицы в файл
        /// </summary>
        /// <param name="matrices">Массив матриц на запись</param>
        public void SaveMatrices(Matrix[] matrices)
        {
            var result = ConvertMatricesToString(matrices);

            FileOperator fileOperator = new FileOperator();
            fileOperator.WriteTextToFile("F3.txt", result);
        }

        /// <summary>
        /// Преобразует массив матриц в строку
        /// </summary>
        /// <param name="matrices">Массив матриц</param>
        /// <returns>Результирующая строка</returns>
        private string ConvertMatricesToString(Matrix[] matrices)
        {
            string result = string.Empty;
            foreach (var matrix in matrices)
            {
                result += matrix.ToString() + "#";
            }

            return result.Substring(0, result.Length - 1);
        }

        /// <summary>
        /// Заполняет матрицу заданного размера случайными значениями
        /// </summary>
        /// <param name="sizeX">Количество столбцов матрицы</param>
        /// <param name="sizeY">Количество строк матрицы</param>
        /// <returns>Сгенерированная матрица</returns>
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
        
        /// <summary>
        /// Заполняет переданную матрицу случайными значениями
        /// </summary>
        /// <param name="matrix">Матрица для заполнения</param>
        /// <returns>Сгенерированная матрица</returns>
        private Matrix GenerateMatrix(Matrix matrix)
        {
            return GenerateMatrix(matrix.Data.GetLength(0), matrix.Data.GetLength(1));
        }
        
    }
}