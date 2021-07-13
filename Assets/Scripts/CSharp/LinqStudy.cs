using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Jow
{
    public static class LinqStudy
    {
        public static void ArrayOddSortFor()
        {
            int[] arr = new int[10] { 3, 1, 4, 5, 2, 10, 8, 7, 9, 6 };
            var odds = new int[5];
            var index = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    odds[index] = item;
                    index++;
                }
            }
            Array.Sort<int>(odds);
            Array.Reverse(odds);

            Debug.Log("For Sort!");

            Debug.Log(string.Join(",", odds));
        }

        public delegate bool FilterFunc(int value);

        public static void ArrayOddSortDelegate(FilterFunc filter)
        {
            int[] arr = new int[10] { 3, 1, 4, 5, 2, 10, 8, 7, 9, 6 };
            var odds = new int[5];
            var index = 0;
            foreach (var item in arr)
            {
                if (filter(item))
                {
                    odds[index] = item;
                    index++;
                }
            }
            Array.Sort<int>(odds);
            Array.Reverse(odds);

            Debug.Log("Delegate Sort!");

            Debug.Log(string.Join(",", odds));
        }

        public static void ArrayOddSortLinq()
        {
            int[] arr = new int[10] { 3, 1, 4, 5, 2, 10, 8, 7, 9, 6 };
            var odds = arr.Where((i) => i % 2 == 0).ToArray<int>();
            Array.Sort<int>(odds);
            Array.Reverse(odds);
            Debug.Log("Linq Sort!");
            Debug.Log(string.Join(",", odds));
        }

        public static void ArrayOddLinqSearch()
        {
            int[] arr = new int[10] { 3, 1, 4, 5, 2, 10, 8, 7, 9, 6 };
            var odds = from item in arr where item % 2 == 0 select item;
            var oddArr = odds.ToArray<int>();
            Array.Sort<int>(oddArr);
            Array.Reverse(oddArr);
            Debug.Log("Linq Search!");
            Debug.Log(string.Join(",", odds));
        }

        public static void LinqSelect()
        {
            //使用集合初始化器给集合赋值
            List<Employee> emp = new List<Employee>
            {
               new Employee(){Id=Guid.NewGuid(),Name="张三",Sex=0,CompanyName="xx技术有限公司"},
               new Employee(){Id=Guid.NewGuid(),Name="李四",Sex=0,CompanyName="xx培训"},
               new Employee(){Id=Guid.NewGuid(),Name="王五",Sex=0,CompanyName="xx集团"}
            };

            var query = (from p in emp where p.Name.StartsWith("王") select p).FirstOrDefault();

            //查询方法:设计到Lambda表达式，全部返回 可以省略最后的select 延迟加载
            var query1 = emp.Where(p => p.Name.StartsWith("王")).Select(e => new { e.Name, e.CompanyName });

            //查询方法:返回匿名类
            var query2 = emp.Where(p => p.Name.StartsWith("王")).Select(p => p);
            var query3 = emp.Where(p => p.Name.StartsWith("王")).Select(p => p);
            foreach (var item in query1)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();

        }

        public class Employee
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public int Sex { get; set; }
            public string CompanyName { get; set; }
        }
    }
}
