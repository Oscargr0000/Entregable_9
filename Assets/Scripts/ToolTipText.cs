using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTipText : MonoBehaviour
{
    public string message;
    private Tooltip TTS;

    private void Start()
    {
        TTS = FindObjectOfType<Tooltip>();
    }
    private void OnMouseEnter()
    {
        TTS.SetandShow(message);
    }

    private void OnMouseExit()
    {
        TTS.HideToolTip();
    }
}
