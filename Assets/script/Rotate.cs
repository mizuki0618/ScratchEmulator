using NaughtyAttributes;
using UnityEngine;

public class Rotatee : MonoBehaviour
{
    [SerializeField, Label("��]�p�x�̎w��")] private int _Rotate = 10;

    [Button("���s")]

    public void Rotate()

    {
        transform.Rotate(0,0, _Rotate);
    } 
}