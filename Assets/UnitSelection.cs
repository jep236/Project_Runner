using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    public GameObject game;
    void OnMouseUp()
    {
        game.GetComponent<Manager>().currentUnit = gameObject;
    }
}
