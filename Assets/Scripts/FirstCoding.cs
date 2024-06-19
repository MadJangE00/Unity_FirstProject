using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    // 우리는 이걸 주석이라고 하기로 했어요! comment

    // 정수형 변수 선언하기
    public int numberInt1 = 10;
    public int numberInt2 = 20;
    int numberSum;
    int numberSubtract;
    int numberMulti;
    float numberDivide;
    int numberRemainder;
    //변수의 선언 및 초기화 (기본 값을 넣어 놓는다 요)
    //public 하면 유니티에서 값 변경 가능

    // 실수형 변수 선언하기
    public float number2 = 3.141512f;
    float result;
    // 문자열 변수 선언하기
    public string name1;
    //string job = "개인사업자";

    // 논리형 변수 선언하기
    private bool isMan;

    // *** 퍼블릭으로 유니티에서 수정된 값은 여기에 들어간다 ***


    // Start is called before the first frame update
    void Start()
    {

        //print(number2);
        //변수의 사용 법
        //[변수 이름] = [값]
        //number2 = 10;
        //numberSum = numberInt1 + numberInt2;
        //numberRemainder = numberInt1 / numberInt2;

        /*number2 = 3.141592f;
        */

        //문자열 + 문자열 -> 두 문자열이 연결 된다 
        //string result = name1 + numberInt1.ToString(); ;
        //
        ////사칙 연산자 : + - * / % 덧 뺄 곱 몫 나
        //
        //print(result);


        //numberInt1과 numberInt2 변수의 합계 값을 출력한다.
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

    //함수 선언
    //반환자료형 함수이름 (매개변수1, 매개변수2, ... )
    //{
    //      할 일
    //}

    // 두 정수를 입력 받아서 그 두 수의 합계 값을 정수 형태로 반환하는 함수를 만들고 싶다!
    int Sum(int num1, int num2)
    {
        return num1 + num2; 
    }

    //두 정수를 입력 받아서 그 두 수를 밴 값을 정수 형태로 반환하는 함수
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    //두 정수를 입력 받아서 그 두 수를 곱한 값을 정수 형태로 반환하는 함수
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    //두 정수를 입력 받아서 그 두수의 나눈 몫을 실수 형태로  반환하는 함수
    float Divide(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }




}
