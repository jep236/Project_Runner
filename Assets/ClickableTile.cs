using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableTile : MonoBehaviour
{
    public GameObject game;
    public int tileX;
    public int tileY;
    public int tileZ;
    

    //Tile tells the game tells the selected unit to move. 
    void OnMouseUp()
    {
        Debug.Log("click");
        Debug.Log(game.GetComponent<Manager>().currentUnit);
        if (game.GetComponent<Manager>().currentUnit)
        {
            Debug.Log("call");
            game.GetComponent<Manager>().currentUnit.GetComponent<Movement>().moveUnit(tileX, tileY, tileZ, game.GetComponent<Manager>().currentUnit);
        }
    }
}
