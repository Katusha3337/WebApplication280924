namespace WebApplication280924.Models
{
    public class MatrixModel
    {
        public int Size { get; set; }
        public int[][] MatrixA { get; set; }
        public int[][] MatrixB { get; set; }
        public int[][] Result { get; set; }

        public MatrixModel()
        {
            Size = 3;
            MatrixA = new int[3][];
            MatrixB = new int[3][];
            Result = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                MatrixA[i] = new int[3];
                MatrixB[i] = new int[3];
                Result[i] = new int[3];
            }
        }
    }
}
