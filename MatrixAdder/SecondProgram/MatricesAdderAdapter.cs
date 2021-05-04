namespace MatrixAdder
{
    public class MatricesAdderAdapter : IMatricesHandler
    {
        private MatrixAdder Adder { get; } = new MatrixAdder();
        private MatrixGenerator Generator { get; } = new MatrixGenerator();

        /// <summary>
        /// Выполняет генерацию матриц с заданным размером
        /// </summary>
        /// <param name="sizeX">>Количество строк матриц</param>
        /// <param name="sizeY">Количество столбцов матриц</param>
        /// <returns>Массив сгенерированных матриц</returns>
        public Matrix[] PrepareMatrices(int sizeX, int sizeY)
        {
            var matrices = Generator.PrepareMatrices(sizeX, sizeY);
            matrices = Generator.OperateMatrices(matrices);
            return matrices;
        }

        /// <summary>
        /// Выполняет сложение сгенерированных матриц
        /// </summary>
        /// <param name="matrices">Массив матриц для сложения</param>
        /// <returns>Массив, состоящий из одной матрицы, которая является суммой матриц, поданных на вход</returns>
        public Matrix[] OperateMatrices(Matrix[] matrices)
        {
            Matrix result = Adder.SummAllMatrices(matrices);
            return new Matrix[] {result};
        }

        /// <summary>
        /// Записывает результат в файл
        /// </summary>
        /// <param name="matrices">Массив матриц для записи в файл</param>
        public void SaveMatrices(Matrix[] matrices)
        {
            Generator.SaveMatrices(matrices);
        }
    }
}