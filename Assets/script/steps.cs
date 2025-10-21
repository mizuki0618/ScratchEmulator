using NaughtyAttributes;
using UnityEngine;

public class steps : MonoBehaviour
{
    [SerializeField, Label("ï‡êîÇÃê›íË")] private int _step = 10;

    [Button("é¿çs")]

    public void MoveAddPosition()
    {
        transform.position += transform.right * _step / 100f;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
