using System;
using UnityEngine;

public class Recursion : MonoBehaviour
{
    private void Start()
    {
        // 由于性能和内存管理的重要性，通常推荐使用循环来替代递归，除非递归能显著简化算法复杂度且递归深度可预测。
        Debug.Log(RecursionIncrementer(0, 5, 1));
        
        // 递归的使用场景
        //     树形结构遍历：如场景层级遍历、UI组件树操作
        //     路径查找算法：如A*寻路、迷宫生成
        //     分形图形生成：如地形生成、植物生长模拟
        //     嵌套数据处理：如JSON/XML解析
        //     数学计算：如阶乘、斐波那契数列 
        // 循环的使用场景
        //     集合遍历：数组、列表等数据结构的迭代
        //     游戏逻辑更新：帧循环、状态机切换
        //     资源管理：批量加载、卸载资源
        //     物理计算：碰撞检测、粒子系统更新
        //     UI刷新：界面元素的定期更新
    }

    private int RecursionIncrementer(int number, int numberMax, int incrementAmount)
    {
        if (number < numberMax)
        {
            return RecursionIncrementer(number + incrementAmount, numberMax, incrementAmount);
        }
        else
        {
            return number;
        }
    }
}
