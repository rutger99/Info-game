using UnityEngine;
using System.Collections;

public class zwaartekracht : MonoBehaviour
{
    void zwaartekrachten()
    {
        Physics.gravity = new Vector3(0, 100.0F, 0);
    }
}