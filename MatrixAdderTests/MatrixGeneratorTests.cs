using System.Net.WebSockets;
using System.Reflection;
using MatrixAdder;
using NUnit.Framework;

namespace MatrixAdderTests
{
    [TestFixture]
    public class MatrixGeneratorTests
    {
        private MatrixGenerator generator = new MatrixGenerator();

        /// <summary>
        /// Выполняет проверку размерности матрицы на стадии подготовки
        /// </summary>
        [Test]
        public void GenerateMatrix_GenerateBySize()
        {
            var preparedMatrices = generator.PrepareMatrices(3, 4);
            Assert.IsTrue(
                preparedMatrices.Length == 2 &&
                preparedMatrices[0].Data.GetLength(0) == 3 &&
                preparedMatrices[0].Data.GetLength(1) == 4 &&
                preparedMatrices[1].Data.GetLength(0) == 3 &&
                preparedMatrices[1].Data.GetLength(1) == 4
            );
        }
        
        /// <summary>
        /// Выполняет проверку размерности матрицы после обработки 
        /// </summary>
        [Test]
        public void OperateMatrices()
        {
            var operatedMatrices = generator.OperateMatrices(new Matrix[] {new Matrix(3, 4)});
            Assert.IsTrue(
                operatedMatrices.Length == 1 &&
                operatedMatrices[0].Data.GetLength(0) == 3 &&
                operatedMatrices[0].Data.GetLength(1) == 4
            );
        }
    }
}