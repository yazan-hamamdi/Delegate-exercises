
namespace Delegate_Exercises
{
    public class CarExercise
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }

        public delegate bool Check(CarExercise car);
        public static bool GreaterThan(CarExercise car) => car.Price > 26000.00m;
        public static bool LessThan(CarExercise car) => car.Price < 26000.00m;
        public static bool NameStartWith_A(CarExercise car) => car.Name[0] == 'F';

        public static int CountCars(List<CarExercise> cars, Check check)
        {
            int count = 0;
            foreach (CarExercise car in cars)
            {
                if (check(car))
                    count++;
            }
            return count;
        }
    }
}
