using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberScript : MonoBehaviour
{

    public Text result;
    public InputField var1;
    public InputField var2;
    public Button resetbtn;
    public Button addbtn;

    public void SetResult()
    {
        result.text = AddNumbers().ToString();

        var1.interactable = false;
        var2.interactable = false;
        addbtn.interactable = false;
        resetbtn.interactable = true;
    }

    public void Reset()
    {
        var1.text = "0";
        var2.text = "0";
        var1.interactable = true;
        var2.interactable = true;
        addbtn.interactable = true;
        resetbtn.interactable = false;
    }

    private int AddNumbers()
    {
        int tempResult = int.Parse(var1.text) + int.Parse(var2.text);
        return tempResult;
    }
}
