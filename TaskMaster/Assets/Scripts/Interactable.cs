using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Interactable : MonoBehaviour
{
    public GameObject textPanel;
    public float distance = 3f;

    private void OnMouseUpAsButton()
    {
        if (textPanel.activeSelf)
        {
            textPanel.SetActive(false);
        }
        else if (Physics2D.Raycast(transform.position, Vector2.right, distance, LayerMask.GetMask("Player")) ||
                 Physics2D.Raycast(transform.position, Vector2.left, distance, LayerMask.GetMask("Player")) ||
                 Physics2D.Raycast(transform.position, Vector2.up, distance, LayerMask.GetMask("Player")) ||
                 Physics2D.Raycast(transform.position, Vector2.down, distance, LayerMask.GetMask("Player")))
        {
            textPanel.SetActive(true);
        }
    }
}