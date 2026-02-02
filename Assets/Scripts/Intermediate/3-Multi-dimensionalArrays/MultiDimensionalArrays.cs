using System;
using UnityEngine;

public class MultiDimensionalArrays : MonoBehaviour
{
    private void Start()
    {
        // 矩形数组 初始化为为0
        // 每一行都有相同的列数（固定的宽度）
        // 用逗号分隔维度，如 [行, 列]
        // 所有数据一次性分配内存
        // 内存分配方式：创建时立即分配连续的内存块
        // 默认值：所有元素自动初始化为类型的默认值（对int来说就是0）
        // 结构确定：在声明时就确定了所有维度的大小
        
        // 矩阵数组适用场景
        //     游戏地图网格：固定尺寸的游戏地图，如棋盘、迷宫
        //     UI网格布局：规则的界面元素排列
        //     纹理数据处理：像素矩阵操作
        //     物理碰撞检测：固定区域的碰撞检测网格
        
        // // int[,] intArray = new int[5, 6];
        // int[,] intArray = new int[,] { {1, 2, 3}, {4, 5, 6} };
        //
        // // Debug.Log(intArray.Length);
        // // intArray[0, 2] = 2;
        // for (int i = 0; i < intArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < intArray.GetLength(1); j++)
        //     {
        //         Debug.Log(i + ", " + j + ": " + intArray[i, j]);
        //     }
        // }

        // 交错数组 初始化为为null
        // 每个子数组长度可以不同 
        // 每一行可以有不同的列数（灵活的宽度）
        // 实际上是"数组的数组"
        // 各部分可以独立分配内存
        // 分层分配：首先创建外层数组，内层数组还未创建
        // 引用特性：外层数组的每个元素都是指向内层数组的引用
        // 延迟分配：需要单独为每个子数组分配内存
        
        // 交错数组适用场景
        //     动态关卡数据：不同关卡有不同数量的数据项
        //     物品背包系统：不同类型物品槽位数量不同
        //     动画状态机：不同状态下的动画序列数量不一
        //     配置表数据：各种配置项数量不确定的情况
        
        // int[][][][][][] intArray;
        int[][] intArray = new int[5][];

        intArray[0] = new int[3];
        intArray[1] = new int[6];
        intArray[2] = new int[10];
        
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i] == null);
            intArray[i] = new int[6];
        }
        
        intArray[0][2] = 5;
    }
}
