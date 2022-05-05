using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math
{
    public static int max(int a, int b)//static 不用再new東西了，可以直接使用（常存在記憶體）
    {
        int result;
        if (a < b)
            result = b;
        else
            result = a;
        return result;
    }
}