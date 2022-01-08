using System;
/*
 * echo "# MyCSharpCode2" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/nahakahaka/MyCSharpCode2.git
git push -u origin main

 * git remote -v
 * git remote remove <origin>
 */
namespace MyAI
{
    class Metrix_M
    {
        private int[,] a;
        private int[,] b;
        private int[,] c;
        public Metrix_M(int[,] A = null, int[,] B = null)
        {
            this.a = A;
            this.a = B;
            if (a != null && b != null)
            {
                Console.WriteLine($"a[{a.GetLength(0)},{a.GetLength(1)}], b[{b.GetLength(0)},{b.GetLength(1)}]");
                this.c = new int[this.a.GetLength(0), this.b.GetLength(1)];
                Console.WriteLine($"C[{c.GetLength(0)},{c.GetLength(1)}]");
            }
            else
            {
                this.c = null;
                Console.WriteLine("a or b or c is null!!");
            }
        }
        public int[,] A
        {
            get
            {
                return a;
            }
            set
            {
                this.a = value;
            }
        }
        public int[,] B
        {
            get
            {
                return b;
            }
            set
            {
                this.b = value;
            }
        }
        public int[,] C
        {
            get
            {
                return c;
            }
        }

        public void Print_A()
        {
            Console.WriteLine("-- A in MetriX --------------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = {a[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void Print_B()
        {
            Console.WriteLine("-- B in MetriX --------------");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"b[{i},{j}] = {b[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void Print_C()
        {
            Console.WriteLine("-- C in MetriX --------------");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"c[{i},{j}] = {c[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void Multi()
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                Console.WriteLine($"\nA[{a.GetLength(0)},{a.GetLength(1)}] * " +
                                    $"B[{b.GetLength(0)},{b.GetLength(1)}] 으로 행렬곱은 성립하지 않음!!");
                return;
            }

            if (this.c == null)
            {
                this.c = new int[a.GetLength(0), b.GetLength(1)];
                Console.WriteLine($"Allocate C by {a.GetLength(0)} * {b.GetLength(1)}");
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    c[i, j] = Multiply(i, j, b.GetLength(0));
                }
            }
        }
        public int Multiply(int p, int q, int m)
        {
            Console.WriteLine($"\np: {p}, q: {q}, m: {m}");
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += a[p, i] * b[i, q];
                Console.WriteLine($"A[{p},{i}] : {a[p, i]} * b[{i},{q}] : {b[i, q]} = {sum}");
            }
            return sum;
        }

        public void Print_Mat(int[] mat)
        {
            throw new NotImplementedException();
        }
    }
    class MyAI
    {
        static void Main(string[] args)
        {
            int[,] A = new int[,] { {2, 1, 3} ,
                                    {4, 3, 2} };
            int[,] B = new int[,] { {1, 5, 2 },
                                    {3, 4, 3 },
                                    {2, 2, 1 } };
            int[,] C = null;


            Console.WriteLine("\n-- Array input ---------------");
            //Metrix_M metrix = new Metrix_M(A, B);
            Metrix_M metrix = new Metrix_M();
            metrix.A = A;
            metrix.B = B;
            metrix.Print_A();
            metrix.Print_B();

            metrix.Multi();
            Console.WriteLine("After Metrix Multiply................");
            metrix.Print_C();

            Console.WriteLine("Conform Main return..................");
            C = metrix.C;
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write($"C[{i},{j}] : {C[i, j]} ");
                }
                Console.WriteLine();
            }

            //C[1, 1] = 3;
            //metrix.Print_C();
        }
    }
}
