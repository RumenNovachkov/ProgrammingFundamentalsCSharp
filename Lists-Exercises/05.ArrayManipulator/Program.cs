using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                List<string> action = Console.ReadLine().Split(' ').ToList();

                if (action[0] == "add")
                {
                    var index = int.Parse(action[1]);
                    var element = int.Parse(action[2]);
                    inputList.Insert(index, element);
                }
                else if (action[0] == "addMany")
                {
                    var index = int.Parse(action[1]);
                    for (int i = action.Count - 1; i >= 2; i--)
                    {
                        var element = int.Parse(action[i]);
                        inputList.Insert(index, element);
                    }
                }
                else if (action[0] == "contains")
                {
                    var element = int.Parse(action[1]);
                    bool exist = inputList.Contains(element);
                    if (exist == true) Console.WriteLine(inputList.IndexOf(element));
                    else Console.WriteLine("-1");
                }
                else if (action[0] == "remove")
                {
                    var index = int.Parse(action[1]);
                    inputList.RemoveAt(index);
                }
                else if (action[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(action[1]); i++)
                    {
                        inputList.Add(inputList[0]);
                        inputList.RemoveAt(0);
                    }
                }
                else if (action[0] == "sumPairs")
                {
                    var newList = new List<int>();
                    if (inputList.Count % 2 == 0)
                    {
                        for (int i = 0; i < inputList.Count; i+=2) newList.Add(inputList[i] + inputList[i + 1]);
                    }
                    else
                    {
                        for (int i = 0; i < inputList.Count - 1; i += 2) newList.Add(inputList[i] + inputList[i + 1]);

                        newList.Add(inputList[inputList.Count - 1]);
                    }
                    inputList.Clear();
                    for (int i = 0; i < newList.Count; i++) inputList.Add(newList[i]);
                }
                else if (action[0] == "print")
                {
                    Console.WriteLine("[" + string.Join(", ", inputList) + "]");
                    return;
                }
            }
        }
    }
}
