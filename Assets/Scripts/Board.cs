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
    private Dictionary<string, Tile> m_TilesDictionary = new Dictionary<string, Tile>();

    private GameObject m_TilePrefab;

    private int m_Width = 3;
    private int m_Height = 3;    

    // Start is called before the first frame update
    void Start()
    {
        /*
        //GameObject tilePrefab = Resources.Load("Prefabs/Candy_Purple_Bomb") as GameObject;
        Tile tile_0 = Instantiate<Tile>(tilePrefab.transform.GetComponent<Tile>());
        //타일의 부모를 Board로 설정
        tile_0.transform.SetParent(this.transform);
        */

        m_TilePrefab = Resources.Load("Prefabs/Candy_Purple_Bomb") as GameObject;
        CreateTiles();
        
    }


    //데이터 입력(input or parameter) => 처리(process) => 출력(output, return)
    
    ///<summary>
    ///프리팹을 이용해서 새로운 타일들을 생성한다.
    ///</summary>
    private void CreateTiles()
    {
        for (int y = 0; y < m_Height; ++y)
        { 
            for (int x = 0; x < m_Width; ++x)
            {
                string key = x.ToString() + "," + y.ToString();

                Tile tile = Instantiate<Tile>(m_TilePrefab.transform.GetComponent<Tile>());

                tile.transform.SetParent(this.transform);
                tile.transform.position = new Vector3(x*1.2f, y*1.2f, 0f);                
                m_TilesDictionary.Add(key, tile);
            }
        }
    }

    /// <summary>
    /// Tile을 반환한다.
    /// </summary>
    /// <param name="x">좌표</param>
    /// <param name="y">좌표</param>
    /// <returns>Tile</returns>
    public Tile GetTile(int x, int y)
    {
        string key = x.ToString() +","+ y.ToString();
        return m_TilesDictionary[key];
    }

    /// <summary>
    /// Tile을 반환한다.
    /// </summary>
    /// <param name="xy">좌표</param>
    /// <returns>Tile</returns>
    public Tile GetTile(string xy)
    {
        return m_TilesDictionary[xy];
    }
}
