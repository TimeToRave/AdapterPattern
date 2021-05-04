using System.Runtime.CompilerServices;
using MatrixAdder;
using NUnit.Framework;

namespace MatrixAdderTests
{
    public class MatrixAdderTests
    {
        private MatrixAdder.MatrixAdder adder = new MatrixAdder.MatrixAdder();
        
        [Test]
        public void SummAllMatrices_NormalCase()
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

            Matrix result = adder.SummAllMatrices(
                new Matrix[]{
                    m1, m2
            });
            
            Matrix etalon = new Matrix(new int[,]
            {
                {3, 4, 5},
                {7, 8, 9}
            });
            
            Assert.IsTrue(result.Equals(etalon));
        }
        
        [Test]
        public void SummAllMatrices_ZeroMatrces()
        {
            Matrix m1 = new Matrix(0,0);
            
            Matrix m2 = new Matrix(0,0);

            Matrix result = adder.SummAllMatrices(
                new Matrix[]{
                    m1, m2
                });
            
            Matrix etalon = new Matrix(0,0);
            
            Assert.IsTrue(result.Equals(etalon));
        }
        
        [Test]
        public void SummAllMatrices_MatricesWithNegativeElements()
        {
            Matrix m1 = new Matrix(new int[,]
            {
                {-1, -1, -1},
                {2, -20, 2}
            });
            
            Matrix m2 = new Matrix(new int[,]
            {
                {2, 3, 4},
                {5, 6, 7}
            });

            Matrix result = adder.SummAllMatrices(
                new Matrix[]{
                    m1, m2
                });
            
            Matrix etalon = new Matrix(new int[,]
            {
                {1, 2, 3},
                {7, -14, 9}
            });
            
            Assert.IsTrue(result.Equals(etalon));
        }
    }
}