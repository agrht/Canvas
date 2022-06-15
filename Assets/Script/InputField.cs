using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputField : MonoBehaviour
{
    public TMP_Text Text;

    public void ToText(string str)
    {
        Text.text = str;
    }
}
