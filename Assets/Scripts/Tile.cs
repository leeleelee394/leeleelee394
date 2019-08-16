using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tile : MonoBehaviour
{
    //Properties
    public int m_ID = 101;    

    /* Methods 함수 */
    // Start is called before the first frame update
    void Start()
    {       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Vector3 strength = new Vector3(0.1f, 0.1f);
        transform.DOPunchScale(strength, 1f);
    }



    //이동()
    //폭발()
    //힌트표시()
}
