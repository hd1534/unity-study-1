<!-- @format -->

# 유니티 연습

그냥 유니티가 해보고 싶어서 만든 프로젝트<br><br>
골드메탈님의 유튜브를 보고 함. [YouTube](https://www.youtube.com/watch?v=7plGPXkmnxQ&list=PLO-mt5Iu5TeYI4dbYwWP8JqZMC9iuUIW2&index=2&ab_channel=%EA%B3%A8%EB%93%9C%EB%A9%94%ED%83%88)

<br><br><br>

# 목차

- [Life Cycle](#life-cycle)
- [Input](#input)
- [Transform & Vector3](#transform--vector3)

---

## [Life Cycle](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html)

[코드](./Assets/LifeCycle.cs)

```
Life Cycle(생명주기)는 프로그램의 흐름이다.


Awake() :
    게임 오브젝트 생성할때 한번 실행

Start() :
    업데이트 시작 직전, 한번 실행

FixedUpdate() :
    고정된 실행 주기로 CPU를 많이 사용
    물리 연산을 여기서 실행해야 CPU차이에 따른 문제가 적음

Update() :
    환경에 따라서 실행 주기가 달라질 수 있음
    게임 로직 업데이트를 여기서 해 부하를 적게 주는게 좋다.

LateUpdate() :
    모든 업데이트 끝난 후
    카메라(시점)의 움직임 같은 것을 여기다 둔다

OnDestroy() :
    게임 오브젝트가 삭제될 때 실행

OnEnable() :
    게임 오브젝트가 활성화 되었을 때 실행

OnDisable() :
    게임 오브젝트가 비활성화 되었을 때 실행

```

---

## [Input](https://docs.unity3d.com/ScriptReference/Input.html)

[코드](./Assets/InputTest.cs)

```
유니티는 Input 클래스에서 입력과 관련된 메소드를 제공한다.
3가지의 상태로 구분하며 Down(눌렸을때), Stay(눌리는중), Up(뗐을때) 가 있다.

키보드 :
    KeyCode :
        키보드에 있는 키들을 맵핑해주는 enum 타입
        ex) KeyCode.Return == 엔터키

    Input.anyKeyDown :
        정의 : public static bool anyKeyDown;
        아무거나 한번 눌리면 True
        즉, 눌리고 있는건 카운트 x

    Input.anyKey :
        정의 : public static bool anyKey;
        아무거나 눌려 있는 중이면 True
        즉, 눌리고 있으면 카운트 O


    Input.GetKeyDown( KeyCode.원하는키 ) :
        원하는 키가 눌리면 True 리턴

    Input.GetKey( KeyCode.원하는키 ) :
        원하는 키가 눌려 있는 중이면 True 리턴

    Input.GetKeyUp( KeyCode.원하는키 ) :
        원하는 키가 떼졌을때 True 리턴


마우스 :
    Input.GetMouseButtonDown( 숫자 ) :
        숫자가 0이면 왼클릭 1이면 우클릭 2면 휠클릭
        원하는 키가 눌렸을때 True 리턴

    Input.GetMouseButton( 숫자 ) :
        숫자가 0이면 왼클릭 1이면 우클릭 2면 휠클릭
        원하는 키가 눌려 있는 중이면 True 리턴

    Input.GetMouseButtonUp( 숫자 ) :
        숫자가 0이면 왼클릭 1이면 우클릭 2면 휠클릭
        원하는 키가 떼졌을때 True 리턴


버튼 :
    유니티의 edit -> Project Settings -> Input Manager 에서 설정한 버튼을 이용하는 방식

    Input.GetButtonDown("버튼 이름") :
        해당 버튼이 눌렸을때 True 리턴

    Input.GetButton("버튼 이름") :
        해당 버튼이 눌려 있는 중이면 True 리턴

    Input.GetButtonUp("버튼 이름") :
        해당 버튼이 떼졌을때 True 리턴

    Input.GetAxis("버튼 이름") :
        축입력 값을 가중치를 적용해서 가져오는 함수로서
        Input Manager에 설정된 대로 flaot 값을 리턴한다
        즉, 숫자가 서서히 증가하거나 감소

    Input.GetAxisRaw("버튼 이름") :
        축입력 값을 가중치를 적용하지 않고 가져오는 함수로서
        Input Manager에 설정된 대로 flaot 값을 리턴한다
        즉, 중간값 X

```

---

## [Transform ](https://docs.unity3d.com/ScriptReference/Transform.html)[& Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html)

[코드](./Assets/TransformTest.cs)

```
유니티에서 모든 오브젝트에는 Transform 클래스가 요구되고 transform으로 이미 선언되어 있다.
위치, 회전, 크기를 담당하며 초기값은 유니티 화면에서 설정한 값으로 되어 있다.

Vector3 :
    3차원 백터를 나타내는 Struct이다.
    Constructors : Vector3(x, y, z) // x,y,z 는 숫자

Vector3.MoveTowards( current, target, maxDistanceDelta ) :
    현재위치에서 maxDistanceDelta 만큼 target을 향해서 움직였을시 위치할 백터를 계산함.
    current, target 은 Vector3 타입,
    maxDistanceDelta는 float 타입
    ex) transform.position = Vector3.MoveTowards(a,b,c)

Vector3.SmoothDamp( current, target, currentVelocity, smoothTime, [etc] )
    MoveTowards랑 비슷한데 속도가 부드럽게 올라갔다 내려감
    current, target 은 Vector3 타입,
    currentVelocity는 ref Vector3 타입,
    smoothTime은 float 타입
    ex) transform.position = Vector3.SmoothDamp(a, b, ref c, d)

Vector3.Lerp( start, end, t )
    선형 보간 이동, equals to a + (b - a) * t.
    start, end는 Vector3 타입
    t 는 남은 거리의 몇 퍼센트를 움직일지
    ex) transform.position = Vector3.Lerp(a,b,c)

Vector3.Slerp( start, end, t )
    구면 선형 보간 이동
    선형 보간 이동을 구면 위에서 하는 것 처럼 원을 그리며 움직임
    start, end는 Vector3 타입
    t 는 남은 거리의 몇 퍼센트를 움직일지
    ex) transform.position = Vector3.Slerp(a,b,c)


transform.position :
    public Vector3 position;
    The world space position of the Transform.

transform.Translate( new Vector3(x, y, z) ) // x,y,z 는 숫자
    현재 위치에서 입력 받은 Vecter3만큼 움직임

```
