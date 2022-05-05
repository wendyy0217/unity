using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student
{
    //property
    public int studentID;
    public string name;
    public int grade;

    public int score;
    public static int passScore = 60;
    //Method
    //建構子不需要輸出值（string,int...),一個class裡只會有一個建構子，且跟class名稱一樣.

    public Student(int stuID, string name)
    {
        this.studentID = stuID;
        this.name = name;
        this.grade = 1;



    }
    public Student(int stuID, string name, int grade)
    {
        this.studentID = stuID;
        this.name = name;
        this.grade = grade;


    }
    public string say()
    {
        return "我叫" + name + "我是" + grade + "年級的學生";
    }
    public string talk(Student s)
    {
        return this.grade + "年級的" + this.name + "對" + s.grade + "年級的" + s.name + "說～你～好";
    }
    public void upgrade()
    {
        this.grade++;
    }

    public bool isPass()
    {
        if (score>=passScore)
        return true;
        else 
        return false;
    }
}
