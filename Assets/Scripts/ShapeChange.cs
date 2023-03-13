using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChange : MonoBehaviour
{
    [SerializeField] private GameObject defaultShape;
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject ring;
    [SerializeField] private GameObject ball;
    [SerializeField] private Transform cube;
    public float speed = 1.0f;

    private void Update()
    {
        defaultShape.transform.RotateAround(cube.position, Vector3.forward, speed * Time.deltaTime);
        defaultShape.transform.Rotate(0f, speed * Time.deltaTime, 0f, Space.Self);
    }

    public void Ring()
    {
        SetActiveObject(ring);
    }

    public void Coin()
    {
        SetActiveObject(coin);
    }

    public void Ball()
    {
        SetActiveObject(ball);
    }

    private void SetActiveObject(GameObject newActiveObject)
    {
        ring.SetActive(newActiveObject == ring);
        coin.SetActive(newActiveObject == coin);
        ball.SetActive(newActiveObject == ball);
        defaultShape = newActiveObject;
    }
}