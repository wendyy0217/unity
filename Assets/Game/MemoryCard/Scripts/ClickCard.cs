using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCard : MonoBehaviour
{
    private void getRndPuzzle()
    {
        int[] data = new int[] { 0, 1, 2 }; // 牌組
        string str = "";
        // 題目資料
        List<int> nums = new List<int>();
        for (int i = 0; i < 2; i++)
        { // 要配對 所以跑兩次迴圈
            for (int j = 0; j < data.Length; j++)
            {
                nums.Add(data[j]);
            }
        }
        for (int i = 0; i < nums.Count; i++)
        {
            str += nums[i].ToString() + ",";
        }
        Debug.Log("原始數據:" + str);

        // 複製陣列 不影響原始數據
        List<int> copy = new List<int>(nums); // 複製list
        str = "";
        for (int i = 0; i < copy.Count; i++)
        {
            str += copy[i].ToString() + ",";
        }
        Debug.Log("陣列複製:" + str);

        // 隨機排序陣列
        List<int> rndAry = new List<int>();
        while (copy.Count > 0)
        {
            int index = Random.Range(0, copy.Count);
            rndAry.Add(copy[index]);
            copy.RemoveAt(index);
        }
        str = "";
        for (int i = 0; i < rndAry.Count; i++)
        {
            str += rndAry[i].ToString() + ",";
        }
        Debug.Log("隨機排序:" + str);
    }

    public void onClick()
    {
        this.getRndPuzzle();
    }
}
