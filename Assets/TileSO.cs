using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Tile", menuName = "Tile")]
public class TileSO : ScriptableObject
{
    [SerializeField] string tileName;
    [SerializeField] GameObject tileType;
   


}
