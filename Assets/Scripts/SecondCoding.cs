using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    public int age1 = 15;
    public int age2 = 7;
    public bool isMan = true;
    public bool runState;
    public bool walkState;
    public int endCount;
    int sum = 0;
    int count = 0;
    string star = "";

    void Start()
    {
        #region ������ �ۼ� ��
        //  if(���ǽ�)
        //  {������ ���϶� �� ��}
        //  else if(���ǽ�)
        //  {�ι�° ���ǽ��� ���� �� �� ��}
        //  else
        //  {���� ��� ������ �������� ���� �� �ؾ� �� �� }
        #endregion

        #region Example1
        //ctr k + c �ѹ��� �ּ� ó���ϱ� 
        //ctr k + u  �ѹ��� �ּ� �����ϱ�
        //
        //if (age1 > age2)
        //{
        //    print("age1 �� age2 ���� ���̰� �� �����ϴ�");
        //}
        //if (age1 == age2)
        //{
        //    print("age1�� age2�� ���̰� �����ϴ�.");
        //}
        //if (age1 < age2)
        //{
        //    print("age1 �� age2 ���� ���̰� �����ϴ�.");
        //}

        // age1�� ���̸� �������� 10�� ���� 40�� ���� ������� �ش��ϴ����� ����Ѵ�.
        //if (age1 < 20)
        //{
        //    print("age1�� 10�� �Դϴ�.");
        //}
        //else if (age1 < 30)
        //{
        //    print("age1�� 20�� �Դϴ�.");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1�� 30�� �Դϴ�.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1�� 40�� �Դϴ�.");
        //}
        //else
        //{
        //    print("age1�� ���̴� 50�� �̻��Դϴ�.");
        //}

        //if (age1 >= 20)
        //{
        //    print("age1�� ���̴� 20�� �̻��Դϴ� ");
        //}
        //else
        //{
        //    print("age1�� ���̴� 20�� �̸��Դϴ�.");
        //}
        #endregion

        #region Example2
        // 1. And ����
        //����, ������ �����̰�,
        //    ���̰� 20�� �̻��� ���
        //    "���� �����Դϴ�." ��� ����Ѵ�.
        //if(isMan == false && age1 >= 20)
        //{
        //    print("���� ���� �Դϴ�.");
        //} else
        //{
        //    print("�̼����� �̰ų�, �����Դϴ�");
        //}


        //2. Or����
        //����, �����̴� ����� " �̵� ���Դϴ�." ��� ����ϰ�,
        // �׷��� ������, "������ �����Դϴ�." ��� ��� �մϴ�.

        if (runState || walkState )
        {
            print("�̵� ���Դϴ�.");
        }
        else
        {
            print("������ �����Դϴ�.");
        }


        // bool ������ ���ǹ��� ������ (== true, ==false ���� ����) 
        //if (runState == true) �� ���� ǥ�� 
        if (runState)
        {
            
        }

        //if (runState == false) �� ���� ǥ��
        if (!runState)
        {

        }

        #endregion



        #region �ݺ��� �ۼ� ��
        //�ݺ���
        //for (���ۺ��� ���� �� �ʱ�ȭ; �������ǽ�; ������)
        //{
        //    �ݺ��� ����
        //}
        #endregion

        #region Example1 
        //1���� 10���� ����Ѵ�

        //for (int i = 0 ; i < 10; i = i + 1) 
        //{
        //    print(i + 1);
        //}
        #endregion

        #region Example2
        //1 ���� 100���� �� ���� ���� sum�̶�� ������ �����ؼ� ����Ѵ�.

        //for ( int i = 0; i < endCount; i = i + 1)
        //{
        //    sum = sum + i + 1;
        //}
        //print(sum);

        //// ������
        //int num = 0;
        //// num = num + 1;
        //// num += 1
        //num++;
        //num--;
        #endregion

        #region ¦�� ���
        //1���� 20 ���� ¦���� ����Ѵ�.
        //for (int i=0; i < 20; i++)
        //{
        //    int number = i + 1;
        //    if (number % 2 == 0)
        //    {
        //        print(number);
        //    }
        //}
        #endregion

        #region ��ø�ϱ� 

        //0���� endCount ������ ¦���� ����Ѵ�. �׷��� ��µ� ¦���� ���� 10���� �����ϸ� �ݺ��� �����Ѵ�.

        //for (int i = 0; i < endCount; i++)
        //{
        //        if (count < 10)
        //        {
        //             if (i % 2 == 0)
        //             {
        //                print(i + "   : " + (count + 1) +"��° ���" );
        //                count++;
        //              }
        //        }
        //    else
        //    {
        //        break;
        //    }

        //    }

        ////for ���� if ���� ���� ��ø�ؼ� ��� �� �� �ִ�.

        //for(int i = 2; i<10; i++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    {
        //        print($"{i} X {j} = {i * j}");
        //    }
        //}
        #endregion

        #region �� �Ƕ�̵�

        //�������� ǰ
        //for (int i = 0; i < 5; i++)
        //{
        //    star = star + "*";
        //    print(star);
        //}

        //���� ���� ǰ
        //string stringstar = "";
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < i + 1; j++)
        //    {
        //        stringstar += "*";
        //    }
        //    stringstar += "\n";
        //}
        //print(stringstar);
        #endregion


        //print("Hello World!");
        //Debug.Log("Hello World!");
        //Debug.LogWarning("Hello World!");
        //Debug.LogError("Hello World!");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
