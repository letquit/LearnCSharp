using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HFYield : MonoBehaviour
{
    ILogger logger = new UnityLogger();
    
    private void Start()
    {
        logger.Log("Hello from Start");
        
        var scores = new List<int> { 50, 125, 300, 80, 170 };
        // foreach (var s in GetBigValues(scores))
        //     logger.Log($"High score: {s}");

        var filtered = scores.Where(val =>
        {
            logger.Log($"Filtering: {val}");
            return val > 100;
        //每次都会导致过滤器再次运行，因为链接查询被推迟了，除非对它们进行迭代，否则它们不会执行
        //每个操作都会触发查询的新枚举
        // });
        }).ToList();
        
        logger.Log($"Count of big scores: {filtered.Count()}"); // Triggers filtering
        logger.Log($"Average of big scores: {filtered.Average()}"); // Triggers it again
    }

    // 这种方法在于每次调用是都会分配一个新的列表
    // public List<int> GetBigValues(List<int> input)
    // {
    //     var result = new List<int>();
    //     foreach (var val in input)
    //         if (val > 100) result.Add(val);
    //     
    //     return result;
    // }
    
    IEnumerable<int> GetBigValues(List<int> input)
    {
        // foreach (var val in input)
        //     // 将其转换为状态机 循环中每次迭代都会从中断处恢复该方法
        //     if (val > 100) yield return val;
        
        // Linq的Where方法也是使用yield return实现的
        return input.Where(val => val > 100);
    }
}
