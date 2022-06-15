using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject Text;

    public void OnToggleChange(bool state)
    {
        Text.SetActive(state);
    }
}
