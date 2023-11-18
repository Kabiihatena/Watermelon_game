using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed*Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0);
        }

        //�ǉ��@���݂̃|�W�V������ێ�����
        Vector3 currentPos = transform.position;

        //�ǉ��@Mathf.Clamp��X,Y�̒l���ꂼ�ꂪ�ŏ��`�ő�͈͓̔��Ɏ��߂�B
        //�͈͂𒴂��Ă�����͈͓��̒l��������
        currentPos.x = Mathf.Clamp(currentPos.x, -1.9f, 3.05f);
        //currentPos.y = Mathf.Clamp(currentPos.y, -yLimit, yLimit);

        //�ǉ��@position��currentPos�ɂ���
        transform.position = currentPos;
    }
}
