namespace linq_samples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var empList = new List<Employee>()
            { 
                new Employee(){
                    Id = 1,
                    Name = "Name1",
                    City="City1",
                    Job="Job1"

                },
                new Employee(){
                    Id = 2,
                    Name = "Name2",
                    City="City2",
                    Job="Job2"

                },
                new Employee(){
                    Id = 3,
                    Name = "Name3",
                    City="City3",
                    Job="Job1"

                },
                new Employee(){
                    Id = 4,
                    Name = "Name4",
                    City="City1",
                    Job="Job2"

                },
            };

            var result=empList.Where(emp => emp.City == "City1");

            foreach (Employee emp in result)
            {
                Console.WriteLine(emp.Name);
            }


        }
    }
}
