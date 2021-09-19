using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени класса "Service" в коде, SVC-файле и файле конфигурации.
public class Service : IService
{
    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }

    public void gameOfLife(ref int[] arr, int numOfThreads, ref DateTime time1, ref DateTime time2)
    {
        int n = (int)Math.Sqrt(arr.Length);
        int[,] oldGen = new int[n, n];
        int[,] newGen = new int[n, n];

        int z = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                oldGen[i, j] = arr[z];
                z++;
            }
        }

        int size = (n + numOfThreads - 1) / numOfThreads;
        var tasks = new List<Task>();
        time1 = DateTime.Now;
        for (int k = 0; k < 1000; k++)
        {
            for (int t = 0; t < numOfThreads; t++)
            {
                tasks.Add(Task.Factory.StartNew((object pos) =>
                {
                    int left, right, up, down;
                    var m = (int)pos;
                    for (int i = size * m; i < size * m + size && i < n; i++)
                    {   
                        for (int j = 0; j < n; j++)
                        {
                            down = i - 1;
                            up = i + 1;
                            left = j - 1;
                            right = j + 1;

                            int lifeCount = 0;
                            if (i != 0)
                            {
                                if (j != 0)
                                {
                                    lifeCount += oldGen[down, left];
                                }
                                if (j != n - 1)
                                {
                                    lifeCount += oldGen[down, right];
                                }
                                lifeCount += oldGen[down, j];
                            }
                            if (i != n - 1)
                            {
                                if (j != 0)
                                {
                                    lifeCount += oldGen[up, left];
                                }
                                if (j != n - 1)
                                {
                                    lifeCount += oldGen[up, right];
                                }
                                lifeCount += oldGen[up, j];
                            }
                            if (j != 0)
                            {
                                lifeCount += oldGen[i, left];
                            }
                            if (j != n - 1)
                            {
                                lifeCount += oldGen[i, right];
                            }
                            //в пер-ю lifeCount подсчитывается сколько у клетки живых соседей (со значением 1)
                            if (lifeCount == 3 && oldGen[i, j] == 0) //если сегодня клетка мертвая (today[i, j]) и соседей у нее 3
                                newGen[i, j] = 1;
                            else if ((lifeCount < 2 || lifeCount > 3) && oldGen[i, j] == 1)
                                newGen[i, j] = 0;
                            else
                                newGen[i, j] = oldGen[i, j];
                        }
                    }
                }, t));
            }
            Task.WhenAll(tasks).Wait();
            tasks.Clear();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    oldGen[i, j] = newGen[i, j];
                }
            }
        }
        time2 = DateTime.Now;
        z = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[z] = oldGen[i, j];
                z++;
            }
        }
    }
}
