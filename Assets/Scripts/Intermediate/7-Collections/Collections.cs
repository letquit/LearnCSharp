using System;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    private void Start()
    {
        // 栈
        //     场景堆栈管理（前进/后退功能）
        //     撤销/重做系统
        //     UI页面导航历史
        //     状态机的状态切换
        // Stack<string> nameStack = new Stack<string>();
        // nameStack.Push("Code Monkey");
        // nameStack.Push("Iron Man");
        // nameStack.Push("Spider-Man");
        //
        // Debug.Log(nameStack.TryPop(out var result));
        // Debug.Log(nameStack.Peek());
        
        // 队列
        //     任务调度队列
        //     消息处理系统
        //     资源加载队列
        //     事件通知队列
        // Queue<string> stringQueue = new Queue<string>();
        //
        // stringQueue.Enqueue("Code Monkey");
        // stringQueue.Enqueue("Iron Man");
        // stringQueue.Enqueue("Spider-Man");
        //
        // Debug.Log(stringQueue.Dequeue());
        
        // 哈希集
        // 唯一性保证，无重复元素
        //     已解锁成就集合
        //     已拾取物品追踪
        //     碰撞检测对象去重
        //     独立玩家ID管理
        // HashSet<string> stringHashSet = new HashSet<string>();
        //
        // stringHashSet.Add("Code Monkey");
        // stringHashSet.Add("Code Monkey");
        // // stringHashSet.Remove("Code Monkey");
        // // stringHashSet.UnionWith(new []{"Iron Man", "Spider-Man"});
        // Debug.Log(stringHashSet.Count);
        
        // 排序列表
        // 键值对存储，按键排序
        //     排行榜系统
        //     优先级任务列表
        //     配置参数管理
        //     时间轴事件排序
        // SortedList<string, int> stringSortedList = new SortedList<string, int>();
        
        // 排序集
        // 唯一性 + 自动排序
        //     排序的玩家分数
        //     按时间排序的日志记录
        //     有序的道具ID集合
        //     优先级对象管理
        // SortedSet<string> stringSortedSet = new SortedSet<string>();
    }
}
