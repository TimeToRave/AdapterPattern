namespace MatrixAdder
{
    interface IMatricesHandler
    {
        /// <summary>
        /// Подготавливает матрицы заданного размера
        /// </summary>
        /// <param name="sizeX">Количество строк матриц</param>
        /// <param name="sizeY">Количество столбцов матриц</param>
        /// <returns>Массив подготовленных матриц</returns>
        public Matrix[] PrepareMatrices(int sizeX, int sizeY);
        /// <summary>
        /// Выполняет действия над матрицами
        /// </summary>
        /// <param name="matrices">Массив матриц</param>
        /// <returns>Результирующий массив матриц</returns>
        public Matrix[] OperateMatrices(Matrix[] matrices);
        /// <summary>
        /// Сохраняет матрицы
        /// </summary>
        /// <param name="matrices">Массив матриц</param>
        public void SaveMatrices(Matrix[] matrices);
    }
}