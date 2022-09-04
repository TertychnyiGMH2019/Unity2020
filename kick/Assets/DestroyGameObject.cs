using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    public GameObject ObjectNew; // ����� ������
    public GameObject ObjectOld; // ������ ������
    public int Health; // �������� �������

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * ���� �������� ������� ������ ��� ����� 0, �� ��������������� ������ ������
         * � ������������ ����� ������
         */
        if (Health <= 0)
        {
            ObjectNew.SetActive(true);
            ObjectOld.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*
         * ���� ������������ �������� � �������� � ����� Destroy, �� �������� ���������� �� �������
         */
        if (collision.collider.tag == "Destroy")
        {
            Health -= 1;
        }
    }
}
