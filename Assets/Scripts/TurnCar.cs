using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCar : MonoBehaviour {
    [SerializeField] Transform target;
    [SerializeField] Direction dir;


    void OnMouseDown()
    {
        Vector3 pos = target.position;
        switch (dir)
        {
            case Direction.Left:
                pos += Vector3.left;
                break;

            case Direction.Right:
                pos += Vector3.right;
                break;
            default:
                pos = Vector3.zero;
                break;
        }
    }

    

    }
    public enum Direction
    {

        Left,
        Right


    }

