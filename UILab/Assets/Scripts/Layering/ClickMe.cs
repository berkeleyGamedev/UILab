using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMe : MonoBehaviour
{
    private int count;

    public void OnClick() {
        count += 1;
        Debug.Log("Clicks: " + count);
    }
}
