using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "ServantData", menuName = "Servant/ServantData", order = 0)]
public class ServantSO : ScriptableObject
{
    [Header("Servant Info")]
    public string servantName;
    public EServantClass servantClass;
    public int defaultHP;
    public int power;
    public int defense;

    [Header("Servant Object")]
    public GameObject prefabs; 
}
