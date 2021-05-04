namespace MatrixAdder
{
    class Program
    {
        static void Main()
        {
            OperateMatrices(new MatrixGenerator(), 4, 6);
            OperateMatrices(new MatricesAdderAdapter(), 4, 6);
        }
        
        /// <summary>
        /// Выполняет операции над матрицами
        /// </summary>
        /// <param name="matricesHandler">Экземпляр класса работы с матрицами</param>
        /// <param name="sizeX">Количество строк матриц</param>
        /// <param name="sizeY">Количество столбцов матриц</param>
        private static void OperateMatrices(IMatricesHandler matricesHandler, int sizeX, int sizeY)
        {
            Matrix[] matrices = matricesHandler.PrepareMatrices(sizeX, sizeY);
            matrices = matricesHandler.OperateMatrices(matrices);
            matricesHandler.SaveMatrices(matrices);
        }
    }
}