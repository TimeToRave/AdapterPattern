using System.Linq;

namespace MatrixAdder
{
    public class MatrixAdder
    {
        /// <summary>
        /// Считывает матрицы, и записывает их сумму в другой файл
        /// </summary>
        public void SumMatrix()
        {
            var matrices = ReadMatricesFromFile();
            
            Matrix result = SummAllMatrices(matrices);
            WriteToFile(result);
        }

        private static Matrix[] ReadMatricesFromFile()
        {
            Matrix[] matrices = ReadMatrixFromFile()
                .Select(x => new Matrix(x)).ToArray();
            return matrices;
        }

        /// <summary>
        /// Производит подсчет всех считанных матриц
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public Matrix SummAllMatrices(Matrix[] matrix)
        {
            var result = matrix[0];
            for (int i = 1; i < matrix.Length; i++)
            {
                result = result + matrix[i];
            }
            return result;
        }

        /// <summary>
        /// Считывает досутпные матрицы из файла
        /// </summary>
        /// <returns></returns>
        public static string[] ReadMatrixFromFile()
        {
            FileOperator fileOperator = new FileOperator();
            string fileContent = fileOperator.ReadTextFromFile("F0.txt");
            fileContent = fileContent.Replace("\r\n", string.Empty);
            return fileContent.Split('#');
        }
        
        /// <summary>
        /// Записывает переданную матрицу в файл
        /// </summary>
        /// <param name="result">Матрица на записьь в файл</param>
        public void WriteToFile(Matrix result)
        {
            FileOperator fileOperator = new FileOperator();
            fileOperator.WriteTextToFile("F1.txt", result.ToString());
        }
    }
}