namespace Task
{
    internal class Program
    {
        #region Part 2
        //internal interface IShape
        //{
        //    public double Area { get;  }

        //    public void DisplayShapeInfo();
        //}

        //internal interface ICircle: IShape
        //{
        //    public double Radius { get; set; }
        //}
        //internal interface IRectangle : IShape
        //{
        //    public double Length { get; set; }
        //    public double Width { get; set; }
        //}
        //internal class Rectangle: IRectangle
        //{
        //    public double Length { get; set; }
        //    public double Width { get; set; }

        //    public double Area {
        //        get { return Length * Width; }
        //    }
        //    public void DisplayShapeInfo()
        //    {
        //        Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area}");
        //    }

        //}
        //internal class Circle : ICircle
        //{
        //    public double Radius { get; set; }


        //    public double Area {
        //        get { return Radius * Radius * Math.PI ; }
        //    }
        //    public void DisplayShapeInfo()
        //    {
        //        Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        //    }

        //}
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Part 1
            #region  Question 1  
            // To define a blueprint for a class 
            #endregion

            #region Question 2   
            // private
            #endregion

            #region  Question 3 
            // No 
            #endregion

            #region Question 4 
            //  Yes, interfaces can inherit from multiple interfaces 
            #endregion

            #region Question 5 
            // implements 
            #endregion

            #region Question 6 
            // Yes ==> Default Methods 
            #endregion

            #region Question 7 
            // No, all members are implicitly public 
            #endregion

            #region Question 8 
            // To hide the interface members from outside access  
            #endregion

            #region Question 9 
            // No, interfaces cannot have constructors
            #endregion

            #region Question 10 
            // By separating interface names with commas
            #endregion
            #endregion

            #region Part 2
            //// Test Circle
            //Circle circle = new Circle();
            //circle.Radius = 10;
            //circle.DisplayShapeInfo();

            //// Test Rectangle
            //IRectangle rectangle = new Rectangle();
            //rectangle.Length = 10;
            //rectangle.Width = 10;
            //rectangle.DisplayShapeInfo();
            #endregion
        }
    }
}
