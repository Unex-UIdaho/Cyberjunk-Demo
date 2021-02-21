using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGeneration : MonoBehaviour
{
    //Room Generator
    public GameObject tile;

    public GameObject wallHorizontal;
    public GameObject wallVertical;
    public GameObject wallVerticalUpRight;
    public GameObject wallVerticalUpLeft;
    public GameObject wallVerticalDownRight;
    public GameObject wallVerticalDownLeft;

    GameObject tileParent;
    GameObject wallParent;

    // Start is called before the first frame update
    void Start()
    {
        float room_width = 3;
        float room_height = 3;

        float tileCoeff = 2.61996f;

        float xStart = -(room_width * tileCoeff) / 2;//2.20445f;
        float yStart = (room_height * tileCoeff) / 2;//1.7047f;

        float xTile = 0.65626f;
        float yTile = 0.65626f;

        float wallOffset = 0.65625f;//0.87f;
        int maxPos;

        //maxPos = TileParent.transform.childCount;

        //float point;

        float[] xTileRep;
        float[] yTileRep;
        float[] xTilePos;
        float[] yTilePos;

        tileParent = GameObject.Find("Tiles");
        wallParent = GameObject.Find("Walls");

        /*for(int i = 0; i < maxPos; i++)
        {
            xTilePos[i] = tile[i].transform.position.x;
            yTilePos[i] = tile[i].transform.position.y;
            Debug.Log("Here");
        }*/

        //Room Generator
        float counter = 0;
        int room_amount = 2;

        string roomType = "StartRight";
        /*
         * Vertical
         * Horizontal
         * StartRight
         * StartLeft
         * StartUp
         * StartDown
         * UpRight
         * UpLeft
         * DownRight
         * DownLeft
        */

        maxPos = Mathf.CeilToInt((room_width + 1) * (room_height + 1) * room_amount * 4);

        xTilePos = new float[maxPos];
        yTilePos = new float[maxPos];
        xTileRep = new float[maxPos];
        yTileRep = new float[maxPos];

        int posCounter = 0;
        for (int i = 0; i <= room_amount; i++)
        {
            //choose direction
            for (int y = 0; y <= room_height; y++)
            {
                Debug.Log("Hi");
            }
        }
    }
}
