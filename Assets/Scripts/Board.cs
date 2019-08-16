using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    //1. 2차원 배열로 사용
    //보드란 클래스의 멤버, 종속되어 있는 변수로만들기 위해 m_사용
    //private Tile[,] m_TileArray = new Tile[6, 6];

    //2. 딕셔너리를 사용 Key, value
    //딕셔너리를 사용하면 2차원 배열보다 사용하기 쉽고 가독성이 좋다.
    private Dictionary<string, Tile> m_TileDictionary = new Dictionary<string, Tile>();
    
   
    


    // Start is called before the first frame update
    void Start()
    {
        GameObject tile_0 = Resources.Load("Prefabs/Candy_Purple_Bomb") as GameObject;
        tile_0.transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
