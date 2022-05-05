using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentMain : MonoBehaviour
{
    void Start()
    {
        Student s1 = new Student(10201, "小山");
        Student s2 = new Student(10202, "小羊");

        Student s3 = new Student(10202, "小正", 3);
        Debug.Log(s2.say());
        //Math m = new Math();//static 不用再new東西了，可以直接使用
        int a = 10;
        int b = 20;
        int c = Math.max(a, b);
        Debug.Log(" " + c);
        s1.score = 20;
        s2.score = 65;
        Student.passScore =40;
        Debug.Log(Student.passScore);
    }
}
