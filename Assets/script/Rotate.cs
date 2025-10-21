using NaughtyAttributes;
using UnityEngine;

public class Rotatee : MonoBehaviour
{
    [SerializeField, Label("‰ñ“]Šp“x‚Ìw’è")] private int _Rotate = 10;

    [Button("Às")]

    public void Rotate()

    {
        transform.Rotate(0,0, _Rotate);
    } 
}