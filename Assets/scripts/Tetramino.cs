using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetramino
{
    I,  
    J,
    L,
    O,
    S,
    T,
    Z
}
[System.Serializable]
public struct TetraminoData
{
    public Tetramino tetramino;
    public Tile tile;
    public Vector2Int[] cells;
}



