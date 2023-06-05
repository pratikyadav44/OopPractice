namespace OopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.DuplicateElement\n2.UniqueElements\n3.CountFrequency\n4.MinMaxElement\n5.StarPattern\n6.SquarePattern\n7.ReverseWord\n8.SumOfDigit\n9.SumOfRow");
            int option = Convert.ToInt32(Console.ReadLine());



            switch (option)
            {
                case 1:
                    DuplicateElements.Duplicate();
                    break;

                case 2:
                    UniqueElements.Unique();
                    break;

                case 3:
                    CountFrequency.Count_frequency();
                    break;

                case 4:
                    MinMaxElement.Min_Max();
                    break;

                case 5:
                    StarPattern.Star();
                    break;

                case 6:
                    SquarePattern.SquareStar();
                    break;

                case 7:
                    ReverseWord.Reverse();
                    break;

                case 8:
                    SumOfDigit.Sum();
                    break;

                case 9:
                    SumOfRow.Sum_row();
                    break;

            }
        }
    }
}