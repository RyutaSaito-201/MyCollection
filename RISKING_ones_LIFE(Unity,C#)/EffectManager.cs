using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    private List<GameObject> L_EffectObj = new List<GameObject>();

    // Start is called before the first frame update
    void Awake()
    {
        GameObject effectObj;

        effectObj = Resources.Load<GameObject>("Effect/CFX_Explosion_B_Smoke+Text");
        L_EffectObj.Add(effectObj);
        effectObj = Resources.Load<GameObject>("Effect/CardEff");
        L_EffectObj.Add(effectObj);
        effectObj = Resources.Load<GameObject>("Effect/Spark");
        L_EffectObj.Add(effectObj);
        effectObj = Resources.Load<GameObject>("Effect/Kieru");
        L_EffectObj.Add(effectObj);
        effectObj = Resources.Load<GameObject>("Effect/kemuri");    // ����I�[��
        L_EffectObj.Add(effectObj);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public GameObject SpawnEffect(int SltEffectNo, Transform Pos)
    {
        switch (SltEffectNo)
        {
            case 0:
                //Debug.Log(Pos);
                //Debug.Log(L_EffectObj[SltEffectNo]);
                Instantiate(L_EffectObj[SltEffectNo], Pos.position, Pos.rotation);
                break;
            case 1:
                Vector3 pos = Pos.position;
                pos.y += 0.02f;
                Instantiate(L_EffectObj[SltEffectNo], pos, Pos.rotation);
                break;
            case 2:
                Instantiate(L_EffectObj[SltEffectNo], Pos.position, Pos.rotation);
                break;
            case 3:
                Instantiate(L_EffectObj[SltEffectNo], Pos.position, Pos.rotation);
                break;
            case 4: // ����I�[��
				return Instantiate(L_EffectObj[SltEffectNo], Pos.position, Pos.rotation);
				//break;
        }

        return null;
    }

    // �G�t�F�N�g�폜(�I���G�t�F�N�g���Ɏg�p
    public void DestoryEffect()
    {
        GameObject[] gameObjects2 = GameObject.FindGameObjectsWithTag("SelectEffect");
        //Debug.Log(gameObjects2.Length);
        for (int i = 0; i < gameObjects2.Length; i++)
        {
            Destroy(gameObjects2[i]);
        }
    }
}
