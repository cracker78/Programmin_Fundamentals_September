using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0]!="print")
            {
                switch (command[0])
                {
                    case "add": AddElement(list, command);
                        break;
                    case "contains": ContainsElement(list, command);
                        break;
                    case "addMany": AddArray(list, command);
                        break;
                    case "remove": RemoveElement(list, command);
                        break;
                    case "shift": ShiftElements(list, command);
                        break;
                    case "sumPairs": list = SumPairs(list);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }

        static List<int> SumPairs(List<int> list)
        {
            List<int> resultList = new List<int>();

            if (list.Count / 2 != 0)
            {
                list.Add(0);
            }

            for (int i = 0; i < list.Count-1; i += 2)
            {
                resultList.Add(list[i] + list[i + 1]);
            }

            list = resultList;
            return list;
        }

        static void ShiftElements(List<int> list, List<string> command)
        {
            int shiftedTimes = int.Parse(command[1]);

            for (int i = 0; i < shiftedTimes; i++)
            {
                int temp;

                for (int j = 0; j < list.Count - 1; j++)
                {
                    temp = list[j];
                    list[j] = list[(j + 1)];
                    list[j + 1] = temp;

                }
            }
        }

        static void RemoveElement(List<int> list, List<string> command)
        {
            list.Remove(int.Parse(command[1])+1);
        }

        static void AddArray(List<int> list, List<string> command)
        {
            int position = int.Parse(command[1]);
            command.RemoveRange(0, 2);

            for (int i = 0; i < command.Count; i++)
            {
                list.Insert(position, int.Parse(command[i]));
                position++;
            }
        }

        static void ContainsElement(List<int> list, List<string> command)
        {
            if (list.Contains(int.Parse(command[1])))
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        static void AddElement(List<int> list, List<string> command)
        {
            list.Insert(int.Parse(command[1]), int.Parse(command[2]));
        }
    }
}
