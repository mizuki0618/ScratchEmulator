using NaughtyAttributes;
using UnityEngine;

public class steps : MonoBehaviour
{
    [SerializeField, Label("�����̐ݒ�")] private int _step = 10;

    [Button("���s")]

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
