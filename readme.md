<!-- @format -->

# 유니티 연습

[골드메탈님의 유튜브를 보고 함.](https://www.youtube.com/watch?v=7plGPXkmnxQ&list=PLO-mt5Iu5TeYI4dbYwWP8JqZMC9iuUIW2&index=2&ab_channel=%EA%B3%A8%EB%93%9C%EB%A9%94%ED%83%88)

---

# 목차

- [Life Cycle](##-Life-Cycle)

---

## Life Cycle

```
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
