using Demo.Abstraction;
using System.Drawing;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Overloading Opertors
            #region Binary Operators
            ////Complex c1 = new Complex() { Real = 2, Imge = 4 };
            ////Complex c2 = new Complex() { Real = 3, Imge = 5 };
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
            #region Casting Operator

            #region Ex01
            // Explicit Recommended

            //int Y = (int)c1;
            //Console.WriteLine(Y);


            //-----------------------------
            //object o1 = 5;
            //int x=(int)o1;Explicit Casting
            //Console.WriteLine(x); 
            #endregion
            #region Ex02
            // Implicit

            //string comp = c1;
            //Console.WriteLine(comp);

            #endregion
            #endregion
            #endregion

            #region Business Need For Operator Overlaoding
            //User user = new User()
            //{
            //    Id = 1,
            //    Name = "khaled",
            //    Email = "khhaa@gmale",
            //    Password = "effdsdv",
            //    SecurityStmp = Guid.NewGuid(),
            //};
            //UserViewModel userViewModel = (UserViewModel) user;
            //Console.WriteLine(userViewModel.Fname);
            //Console.WriteLine(userViewModel.Lname);
            //Console.WriteLine(userViewModel.Emale);
            //Console.WriteLine(userViewModel.Password);
            //Console.WriteLine(userViewModel.SecurityStmp);
            #endregion

            #region Abstraction
            //Rect rect = new Rect() { Dim1=10,Dim2=20};
            //decimal rectArea=rect.CalcArea();
            //decimal peri = rect.perimeter;
            //Console.WriteLine(rectArea);
            //Console.WriteLine($"perim{peri}");

            #endregion

        }
    }
}
