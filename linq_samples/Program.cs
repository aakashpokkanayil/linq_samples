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
                    Id = 1,
                    Name = "Name1",
                    City="City1",
                    Job="Job1"

                },
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

            #region where,orderby,orderbydesc,Thenby
            //var result = empList.Where(emp => emp.City == "City1");

            //Console.WriteLine("employees from City1");
            //foreach (Employee emp in result)
            //{
            //    Console.WriteLine(emp.Name);
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("employees Order by City Asc");
            //result = empList.OrderBy(emp => emp.City);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name} from {item.City}");
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("employees Order by City Desc");
            //result = empList.OrderByDescending(emp => emp.City);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name} from {item.City}");
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("employees Order by City,Name");
            //result = empList.OrderBy(emp => emp.City).ThenBy(emp => emp.Name);
            //// Then by canbe nested as required. also similarly ThenByDesending method also thr for order by desc.
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name} from {item.City}");
            //}
            #endregion

            #region First,FirstOrDefault
            // first return first matching element from collection.throw exception if there is no data.
            var emp =empList.First(emp=>emp.Id == 1);
            Console.WriteLine(emp.Name);

            // FirstOrDefault return first matching element from collection.This will return null object (or default object) if no data.
            emp = empList.FirstOrDefault(emp => emp.Id == 1);
            if (emp != null)
            {
                Console.WriteLine(emp.Name);
            }
            #endregion

            #region Last,LastOrDefault
            // Last return Last matching element from collection.throw exception if there is no data.
            emp = empList.Last(emp => emp.Id == 1);
            Console.WriteLine(emp.Name);

            // LastOrDefault return Last matching element from collection.This will return null object (or default object) if no data.
            emp = empList.LastOrDefault(emp => emp.Id == 1);
            if (emp != null)
            {
                Console.WriteLine(emp.Name);
            }
            #endregion

            #region ElementAt,ElementAtOrDefault
            // ElementAt return  matching element from given index from the collection.throw out of range exception
            // if given index is not there.
            Console.WriteLine("----------------------------------ElementAt vs ElementAtOrDefault---------------------------------------------------");
            emp = empList.Where(emp => emp.Id == 1).ElementAt(2);// here it give 3rd element , coz its 0 based index
            Console.WriteLine(emp.Name);

            // ElementAtOrDefault return  matching element from given index from the collection.
            // This will return null object if no index avaliable.
            emp = empList.Where(emp => emp.Id == 1).ElementAtOrDefault(2);
            if (emp != null)
            {
                Console.WriteLine(emp.Name);
            }
            #endregion

            #region Select
            Console.WriteLine("----------------------------------Select---------------------------------------------------");
            var trnformedEmpList = empList.Select(emp => emp.Id*100);// save all id which is multiplied by 100

            foreach (var item in trnformedEmpList)
            {
                Console.WriteLine(item); // Print Ids
            }

            // Creating new object
            var trnsobj=empList.Select(emp => new { Id=emp.Id*100,Name=$"This is my name: {emp.Name}"});  
            foreach (var item in trnsobj) { Console.WriteLine(item.Name); }
            #endregion

            #region Min,Max,Sum,Average,Count
            Console.WriteLine("----------------------------------Min,Max,Sum,Average,Count---------------------------------------------------");

            var _emp= empList.Min(emp => emp.Id);
            Console.WriteLine("Min:" + _emp);

            _emp = empList.Max(emp => emp.Id);
            Console.WriteLine("Max:" + _emp);

            _emp = empList.Sum(emp => emp.Id);
            Console.WriteLine("Sum:" + _emp);

            var _empAvg = empList.Average(emp => emp.Id);
            Console.WriteLine("Average:" + _empAvg);

            _emp = empList.Count();
            Console.WriteLine("Count:" + _emp);

            #endregion



        }
    }
}
