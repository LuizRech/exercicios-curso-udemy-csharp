using System.Globalization;
namespace Employees_ExercicioListas
{
    class Employees
    {
        public int Id;
        public string Name;
        public double Salary;


        public void IncrementSalary(double increment)
        {
            Salary = Salary + (Salary / increment);
        }

        public override string ToString()
        {
            return Id
                + ", " 
                + Name 
                + ", " 
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
