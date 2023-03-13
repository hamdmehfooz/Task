using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private Color color;
    [SerializeField] private Renderer cubeRenderer, ballRenderer;

    private void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.enabled = true;
        ballRenderer = ball.GetComponent<Renderer>();
        ballRenderer.enabled = true;
       
    }
    // Update is called once per frame
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
            cubeRenderer.material.color = color;
            ballRenderer.material.color = color;
        }

        else
        {
            return;
        }
    }
  
}
