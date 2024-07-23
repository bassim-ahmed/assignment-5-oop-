using session_5__oop_.Casting_Operaores_Overriding;
using session_5__oop_.Operator_Overloading;
using session_5__oop_.Static;
using System.Drawing;

namespace session_5__oop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region operator overloading
            Complex C1 = new Complex() { Real=3,Imag=5};
            //Console.WriteLine(C1);

            Complex C2 = new Complex() { Real=4,Imag=6};
            //Console.WriteLine(C2);
            #region operators overloading -Binary
            Complex C3 = C1 - C2;
            Console.WriteLine(C3);
            //Complex C3 = default;
            //Complex C4 = C1+C3;
            //Console.WriteLine(C4);
            #endregion
            #region operators overloading unary
            C1++;
            Console.WriteLine(C1);
            C2--;
            Console.WriteLine(C2);


            #endregion
            #region operators overloading relationaloperators
            if (C1 > C2)
            {
                Console.WriteLine("c1 is greater than c2");
            }else if(C1 < C2)
            {
                Console.WriteLine("c2 is creater than c1");
            }
            #endregion

            #region casting operators overloading
            //object obj = 2;//Boxing
            //int x = (int)obj;
            int y = (int)C1;//invalid
                            //explicit casting
                            //(int)->
            Console.WriteLine(y);
            string S1 = C1;//invalid
            Console.WriteLine(S1);
            #endregion
            #endregion

            #region casting operators overloading
            // view ->EmployeeViewModel->Employee[Nodel]->database
            //Dadatabase->Employee->EmployeeViewModel->view
            //Employee employee = new Employee() { Id = 1,FullName="bassim ahmed",Password="password",Email="email",Security=Guid.NewGuid() };
            //EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            //employeeViewModel= (EmployeeViewModel)employee;
            //Console.WriteLine(employeeViewModel.FirstName);
            //Console.WriteLine(employeeViewModel.LastName);
            //Console.WriteLine(employeeViewModel.Email);

            #endregion
            #region abstraction
            //Rectangle rectangle = new Rectangle(4, 7);
            //decimal recarea=rectangle.CalcArea();
            //Console.WriteLine($"area of rectangle={recarea}");
            //Console.WriteLine($"preimeter of rentangle={rectangle.perimeter}");
            #endregion
            #region  struct
            //Utitly U1=new Utitly(10,20);
            //Console.WriteLine(U1.CmToInch(23));

            //Utitly U2 = new Utitly(45, 23);
            //Console.WriteLine(Utitly.CmToInch(23));
            //IF RESULT OF CALLING METHOD CMTOINCH WILL NOT DIFFRENENCE of the object
            //we must use static
            Console.WriteLine($" circle:{Utitly.CalcCircleArea(5)}");
            #endregion

        }
    }
}
