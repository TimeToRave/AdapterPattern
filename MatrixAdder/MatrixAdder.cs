namespace MatrixAdder
{
    public class MatrixAdder
    {
        public void SumMatrix()
        {
            // читает две матрицы из файла
            FileOperator fileOperator = new FileOperator();
            string fileContent = fileOperator.ReadTextFromFile("F0.txt");
            fileContent = fileContent.Replace("\r\n", string.Empty);
            string[] textMatrix = fileContent.Split('#');

            if (textMatrix.Length > 1)
            {
                var source = new Matrix(textMatrix[0]);
                var addendum = new Matrix(textMatrix[1]);

                var result = source + addendum;

                fileOperator.WriteTextToFile("F1.txt", result.ToString());
            }
        }
    }
}