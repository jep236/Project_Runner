using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker: MonoBehaviour
{
    // Start is called before the first frame update
    public TileType[] tileTypes;
    int[,,] tiles;
    Node[,,] graph;
    public int mapSizeX;
    public int mapSizeY;
    public int mapSizeZ;

    enum Tiles
    {
        Floor,
        Wall,
        Building,
        Void,
    }

    void Start()
    {






        MakeMapData();
        MakeMapGraph();
        MapGen();
    }

    void MakeMapData()
    {
        //For a map to be valid each of these values must be set to at least 1
        tiles = new int[mapSizeX, mapSizeY, mapSizeZ];
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                for (int z = 0; z < mapSizeZ; z++)
                {
                    tiles[x, y, z] = 0;
                }

            }
        }
        //setting tiles for the sake of demo
        tiles[2, 0, 1] = 1;
        tiles[2, 0, 2] = 1;
        tiles[2, 0, 3] = 1;
        tiles[2, 0, 4] = 1;
    }

    void MapGen()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                for (int z = 0; z < mapSizeZ; z++)
                {
                    TileType tt = tileTypes[tiles[x, y, z]];
                    GameObject cur = Instantiate(tt.tileVisualPrefab, new Vector3(x, y, z), Quaternion.identity);
                    ClickableTile ct = cur.GetComponent<ClickableTile>();
                    ct.tileX = x;
                    ct.tileY = y;
                    ct.tileZ = z;
                    ct.game = gameObject;
                }
          
            }
        }
    }

    class Node{
        public List<Node> neighbours;
        public List<Node> corners;

        public Node()
        {
            neighbours = new List<Node>();
        }
    }
    void MakeMapGraph()
    {
        graph = new Node[mapSizeX, mapSizeY, mapSizeZ];

        for(int x=0; x < mapSizeX; x++){
            for(int y=0; y< mapSizeY; y++)
            {
                for(int z=0; z < mapSizeZ; z++)
                {
                    if(x> 0)
                    {
                        graph[x, y, z].neighbours.Add(graph[x - 1, y, z]);
                    }
                    if (x < mapSizeX - 1)
                    {
                        graph[x, y, z].neighbours.Add(graph[x + 1, y, z]);
                    }
                    if (z > 0)
                    {
                        graph[x, y, z].neighbours.Add(graph[x, y, z-1]);
                    }
                    if (z < mapSizeX - 1)
                    {
                        graph[x, y, z].neighbours.Add(graph[x, y, z+1]);
                    }
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
