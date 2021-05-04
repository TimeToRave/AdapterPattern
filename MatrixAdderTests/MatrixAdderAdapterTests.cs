using System;
using MatrixAdder;
using NUnit.Framework;

namespace MatrixAdderTests
{
    [TestFixture]
    public class MatrixAdderAdapterTests
    {
        private MatricesAdderAdapter adapter = new MatricesAdderAdapter();
        
        /// <summary>
        /// Выполняет проверку размерности матрицы на стадии подготовки
        /// </summary>
        [Test]
        public void GenerateMatrix_GenerateBySize()
        {
            var preparedMatrices = adapter.PrepareMatrices(3, 4);
            Assert.IsTrue(
                preparedMatrices.Length == 2 &&
                preparedMatrices[0].Data.GetLength(0) == 3 &&
                preparedMatrices[0].Data.GetLength(1) == 4 &&
                preparedMatrices[1].Data.GetLength(0) == 3 &&
                preparedMatrices[1].Data.GetLength(1) == 4
            );
        }
        
        /// <summary>
        /// Проверяет сложение двух матриц
        /// </summary>
        [Test]
        public void OperateMatrices_TwoNormalMatrices()
        {
            Matrix m1 = new Matrix(new int[,]
            {
                {1, 1, 1},
                {2, 2, 2}
            });
            
            Matrix m2 = new Matrix(new int[,]
            {
                {2, 3, 4},
                {5, 6, 7}
            });

            Matrix[] result = adapter.OperateMatrices(
                new Matrix[]{
                    m1, m2
                });
            
            Matrix etalon = new Matrix(new int[,]
            {
                {3, 4, 5},
                {7, 8, 9}
            });
            
            Assert.IsTrue(
                result.Length == 1 && 
                result[0].Equals(etalon)
            );
        }
        
        /// <summary>
        /// Проверяет сложение двух матриц с нулевой размерностью
        /// </summary>
        [Test]
        public void OperateMatrices_TwoZeroMatrices()
        {
            Matrix m1 = new Matrix(new int[,]
            {
                {}
            });
            
            Matrix m2 = new Matrix(new int[,]
            {
                {}
            });

            Matrix[] result = adapter.OperateMatrices(
                new Matrix[]{
                    m1, m2
                });
            
            Matrix etalon = new Matrix(new int[,]
            {
                {}
            });
            
            Assert.IsTrue(
                result.Length == 1 && 
                result[0].Equals(etalon)
            );
        }
        
        /// <summary>
        /// Проверяет сложение двух матриц, размерность которых различается
        /// </summary>
        [Test]
        public void OperateMatrices_IncorrectMatricesSizes()
        {
            Matrix m1 = new Matrix(new int[,]
            {
                {1, 1},
                {2, 2}
            });
            
            Matrix m2 = new Matrix(new int[,]
            {
                {2, 3, 4},
                {5, 6, 7}
            });

            var exception = Assert.Throws<Exception>(() => 
                    adapter.OperateMatrices(
                        new Matrix[]{
                            m1, m2
                    })
            );
            
            Assert.That(exception.Message, Is.EqualTo("Sizes of matrix are not equal"));
        }
    }
}