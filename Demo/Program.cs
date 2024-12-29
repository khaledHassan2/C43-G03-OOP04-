namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Overloading Opertors
            #region Binary Operators
            Complex c1 = new Complex() { Real = 2, Imge = 4 };
            Complex c2 = new Complex() { Real = 3, Imge = 5 };
            ////Complex c3 = c1 + c2;
            ////Console.WriteLine(c1);
            ////Console.WriteLine(c2);
            ////Console.WriteLine("_-----------");
            ////Console.WriteLine(c3);

            ////-----------------

            //Complex c3 = c1 - c2;
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine("_-----------");
            //Console.WriteLine(c3);
            #endregion
            #region Unary Operators
            //Complex C3 = ++c1;
            //Console.WriteLine(C3);

            //Complex C3 = --c1;
            //Console.WriteLine(C3);
            #endregion
            #region Relational Operators
            //if (c1 > c2)
            //{
            //    Console.WriteLine("c1  is > c2");
            //}
            //else if(c1 < c2) { Console.WriteLine("c1 is < c2"); }
            //else { Console.WriteLine("c1 is Equals c2"); }
            #endregion
            #endregion
        }
    }
}
