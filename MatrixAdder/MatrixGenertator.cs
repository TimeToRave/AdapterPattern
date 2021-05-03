using System;

namespace MatrixAdder
{

    interface IFileSystemOperableMatrix
    {
        public Matrix[] GetMatrices(int sizeX, int sizeY);
        public void SaveMatrices(Matrix[] matrices);
    }
    
    /// <summary>
    /// Генерирует и записывает матрицы в файл
    /// </summary>
    public class MatrixGenerator : IFileSystemOperableMatrix
    {
        /// <summary>
        /// Записывает сгенерированные две матрицы в один файл
        /// </summary>
        /// <param name="sizeX"></param>
        /// <param name="sizeY"></param>
        public void RunOperation(int sizeX, int sizeY)
        {
            var matrices = GetMatrices(sizeX, sizeY);
            SaveMatrices(matrices);
        }

        /// <summary>
        /// Формирует массив матриц заданного размера
        /// </summary>
        /// <param name="sizeX">Количество колонок матриц</param>
        /// <param name="sizeY">Количество строк матриц</param>
        /// <returns>Массив матриц</returns>
        public Matrix[] GetMatrices(int sizeX, int sizeY)
        {
            Matrix[] matrices = new Matrix[]
            {
                GenerateMatrix(sizeX, sizeY),
                GenerateMatrix(sizeX, sizeY)
            };
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

            result.Substring(0, result.Length - 1);
            return result;
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
    }
}