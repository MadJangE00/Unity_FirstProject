using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    // �츮�� �̰� �ּ��̶�� �ϱ�� �߾��! comment

    // ������ ���� �����ϱ�
    public int numberInt1 = 10;
    public int numberInt2 = 20;
    int numberSum;
    int numberSubtract;
    int numberMulti;
    float numberDivide;
    int numberRemainder;
    //������ ���� �� �ʱ�ȭ (�⺻ ���� �־� ���´� ��)
    //public �ϸ� ����Ƽ���� �� ���� ����

    // �Ǽ��� ���� �����ϱ�
    public float number2 = 3.141512f;
    float result;
    // ���ڿ� ���� �����ϱ�
    public string name1;
    //string job = "���λ����";

    // ���� ���� �����ϱ�
    private bool isMan;

    // *** �ۺ����� ����Ƽ���� ������ ���� ���⿡ ���� ***


    // Start is called before the first frame update
    void Start()
    {

        //print(number2);
        //������ ��� ��
        //[���� �̸�] = [��]
        //number2 = 10;
        //numberSum = numberInt1 + numberInt2;
        //numberRemainder = numberInt1 / numberInt2;

        /*number2 = 3.141592f;
        */

        //���ڿ� + ���ڿ� -> �� ���ڿ��� ���� �ȴ� 
        //string result = name1 + numberInt1.ToString(); ;
        //
        ////��Ģ ������ : + - * / % �� �� �� �� ��
        //
        //print(result);


        //numberInt1�� numberInt2 ������ �հ� ���� ����Ѵ�.
        numberSum = Sum(numberInt1, numberInt2);
        numberSubtract = Subtract(numberInt1, numberInt2);
        numberMulti = Multiply(numberInt1, numberInt2);
        result = Divide(numberInt1, numberInt2);
        print(numberSum);
        print(numberSubtract);
        print(numberMulti);
        print(result);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�Լ� ����
    //��ȯ�ڷ��� �Լ��̸� (�Ű�����1, �Ű�����2, ... )
    //{
    //      �� ��
    //}

    // �� ������ �Է� �޾Ƽ� �� �� ���� �հ� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�!
    int Sum(int num1, int num2)
    {
        return num1 + num2; 
    }

    //�� ������ �Է� �޾Ƽ� �� �� ���� �� ���� ���� ���·� ��ȯ�ϴ� �Լ�
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    //�� ������ �Է� �޾Ƽ� �� �� ���� ���� ���� ���� ���·� ��ȯ�ϴ� �Լ�
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    //�� ������ �Է� �޾Ƽ� �� �μ��� ���� ���� �Ǽ� ���·�  ��ȯ�ϴ� �Լ�
    float Divide(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }




}
