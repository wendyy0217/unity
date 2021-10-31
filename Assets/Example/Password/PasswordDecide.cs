using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordDecide : MonoBehaviour
{
    // 密碼輸入框
    public InputField input = null;

    // 驗證結果
    public Text result = null;

    public void btnClick()
    {
        string result = this.password(this.input.text);
        this.result.text = result;
    }

    public void btnClear()
    {
        this.input.text = "";
    }

    private string password(string input)
    {
        // 大寫字母/小寫字母及數字的ASCII碼（數字）值對照：
        // a-z：97-122
        // A-Z：65-90
        // 0-9：48-57
        // 特殊符號 !@#$%^&*?
        bool hasUppercase = false;
        bool hasLowercase = false;
        bool hasDigit = false;
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (
                input.Contains("!") ||
                input.Contains("@") ||
                input.Contains("#") ||
                input.Contains("$") ||
                input.Contains("%") ||
                input.Contains("^") ||
                input.Contains("&") ||
                input.Contains("*")
            )
            {
                this.result.color = Color.red;
                return "不可含有!@#$%^&*? 特殊符號";
            }

            int ascii = (int)(input[i]);

            if (!hasUppercase && 65 <= ascii && ascii <= 90)
            {
                hasUppercase = true;
            }

            if (!hasLowercase && 97 <= ascii && ascii <= 122)
            {
                hasLowercase = true;
            }

            if (!hasDigit && 48 <= ascii && ascii <= 57)
            {
                hasDigit = true;
            }
        }

        if (hasUppercase && hasLowercase && hasDigit)
        {
            output = "驗證通過";

            this.result.color = Color.green;
        }
        else
        {
            if (!hasUppercase)
            {
                output += "至少一個大寫 ";
            }
            if (!hasLowercase)
            {
                output += "至少一個小寫 ";
            }
            if (!hasDigit)
            {
                output += "至少一個數字 ";
            }
        }
        this.result.color = Color.red;
        return output;
    }
}
