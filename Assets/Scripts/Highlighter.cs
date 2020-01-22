using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    private MeshRenderer meshrenderer;

    [SerializeField] private Material originalMat;
    [SerializeField] private Material highlightMat;

    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        EnableHighlight(false);
    }

    void Update()
    {
        
    }

    private void EnableHighlight(bool state)
    {
        if(meshrenderer != null && originalMat != null &&
            highlightMat != null)
        {
            meshrenderer.material = state ? highlightMat : originalMat;
        }
    }

    private void OnMouseOver()
    {
        print("mouse over = true");
        EnableHighlight(true);
    }

    private void OnMouseExit()
    {
        print("mouse over = false");
        EnableHighlight(false);
    }
}
