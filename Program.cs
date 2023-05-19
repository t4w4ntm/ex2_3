class Program
{static void Main(){
Plus();
}
static void Plus(){ while (true){
    Console.Write("กรอกอักขระ + , - เพื่อดำเนินการต่อ : ");
            string Chars;
            Chars = Console.ReadLine();
            Console.WriteLine();

            if (Chars == "+" || Chars == "-"){
                Check();
            }
            else if(Chars != "+" || Chars != "-"){
                break;
        }
     }
}
static void Check() {
        Console.Write("ใส่แถวเมทริกต์ A : ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("ใส่หลักเมทริกต์ A : ");
        int col = int.Parse(Console.ReadLine());

        int row2 = row;
        int col2 = col;
        double[,] matrix1 = new double[row, col];

        Console.WriteLine("ตัวเลขในเมทริกต์ A: ");

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write($"ช่องที่ [{i}, {j}]: ");
                matrix1[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double[,] matrix2 = new double[row2, col2];

        Console.WriteLine("ตัวเลขในเมทริกต์ B:");

        for (int i = 0; i < row2; i++)
        {
            for (int j = 0; j < col2; j++)
            {
                Console.Write($"ช่องที่ [{i}, {j}]: ");
                matrix2[i, j] = double.Parse(Console.ReadLine());
            }
        }
        double[,] sumMatrix = new double[row, col];

        Console.WriteLine("ผลรวมของเมทริกต์ :");

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                Console.Write(sumMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Plus();
    }
}
