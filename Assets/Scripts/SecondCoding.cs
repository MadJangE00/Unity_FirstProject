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
        #region 조선식 작성 법
        //  if(조건식)
        //  {조건이 참일때 할 일}
        //  else if(조건식)
        //  {두번째 조건식이 참일 때 할 일}
        //  else
        //  {앞의 모든 조건이 성립하지 않을 때 해야 할 일 }
        #endregion

        #region Example1
        //ctr k + c 한번에 주석 처리하기 
        //ctr k + u  한번에 주석 해제하기
        //
        //if (age1 > age2)
        //{
        //    print("age1 이 age2 보다 나이가 더 많습니다");
        //}
        //if (age1 == age2)
        //{
        //    print("age1과 age2의 나이가 같습니다.");
        //}
        //if (age1 < age2)
        //{
        //    print("age1 이 age2 보다 나이가 적습니다.");
        //}

        // age1의 나이를 기준으로 10대 부터 40대 까지 어느곳에 해당하는지를 출력한다.
        //if (age1 < 20)
        //{
        //    print("age1은 10대 입니다.");
        //}
        //else if (age1 < 30)
        //{
        //    print("age1은 20대 입니다.");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1은 30대 입니다.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1은 40대 입니다.");
        //}
        //else
        //{
        //    print("age1의 나이는 50세 이상입니다.");
        //}

        //if (age1 >= 20)
        //{
        //    print("age1의 나이는 20살 이상입니다 ");
        //}
        //else
        //{
        //    print("age1의 나이는 20살 미만입니다.");
        //}
        #endregion

        #region Example2
        // 1. And 조건
        //만일, 성별이 여성이고,
        //    나이가 20살 이상일 경우
        //    "성인 여성입니다." 라고 출력한다.
        //if(isMan == false && age1 >= 20)
        //{
        //    print("성인 여성 입니다.");
        //} else
        //{
        //    print("미성년자 이거나, 남성입니다");
        //}


        //2. Or조건
        //만일, 움직이는 경우라면 " 이동 중입니다." 라고 출력하고,
        // 그렇지 않으면, "정지한 상태입니다." 라고 출력 합니다.

        if (runState || walkState )
        {
            print("이동 중입니다.");
        }
        else
        {
            print("정지한 상태입니다.");
        }


        // bool 변수가 조건문에 들어오면 (== true, ==false 생략 가능) 
        //if (runState == true) 와 같은 표현 
        if (runState)
        {
            
        }

        //if (runState == false) 와 같은 표현
        if (!runState)
        {

        }

        #endregion



        #region 반복문 작성 법
        //반복문
        //for (시작변수 선언 및 초기화; 종료조건식; 증감식)
        //{
        //    반복할 내용
        //}
        #endregion

        #region Example1 
        //1부터 10까지 출력한다

        //for (int i = 0 ; i < 10; i = i + 1) 
        //{
        //    print(i + 1);
        //}
        #endregion

        #region Example2
        //1 부터 100까지 다 더한 값을 sum이라는 변수에 저장해서 출력한다.

        //for ( int i = 0; i < endCount; i = i + 1)
        //{
        //    sum = sum + i + 1;
        //}
        //print(sum);

        //// 누적식
        //int num = 0;
        //// num = num + 1;
        //// num += 1
        //num++;
        //num--;
        #endregion

        #region 짝수 출력
        //1부터 20 까지 짝수만 출력한다.
        //for (int i=0; i < 20; i++)
        //{
        //    int number = i + 1;
        //    if (number % 2 == 0)
        //    {
        //        print(number);
        //    }
        //}
        #endregion

        #region 중첩하기 

        //0부터 endCount 전까지 짝수만 출력한다. 그런데 출력된 짝수의 수가 10개에 도달하면 반복을 종료한다.

        //for (int i = 0; i < endCount; i++)
        //{
        //        if (count < 10)
        //        {
        //             if (i % 2 == 0)
        //             {
        //                print(i + "   : " + (count + 1) +"번째 출력" );
        //                count++;
        //              }
        //        }
        //    else
        //    {
        //        break;
        //    }

        //    }

        ////for 문과 if 문은 서로 중첩해서 상용 할 수 있다.

        //for(int i = 2; i<10; i++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    {
        //        print($"{i} X {j} = {i * j}");
        //    }
        //}
        #endregion

        #region 별 피라미드

        //계행으로 품
        //for (int i = 0; i < 5; i++)
        //{
        //    star = star + "*";
        //    print(star);
        //}

        //계행 없이 품
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
