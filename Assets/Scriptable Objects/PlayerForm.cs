using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Player/Form")]
public class PlayerForm : ScriptableObject
{
    public string formName;
    public float MoveSpeed;
    public GameObject model;
}
