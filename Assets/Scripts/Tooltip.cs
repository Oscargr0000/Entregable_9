using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI ToolText;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void SetandShow(string message)
    {
        gameObject.SetActive(true);
        ToolText.text = message;
    }

    public void HideToolTip()
    {
        gameObject.SetActive(false);
        ToolText.text = string.Empty;
    }
}
