# BIG-O 

        # 두 알고리즘 A 와 B를 비교하려면 ?
            1) A가 B보다 "조금", "많이" 빨라요 => 애매모호
            2) 프로그램을 짜서 실행 속도 비교? => 환경에 의존적
            3) 입력이 적은 구간과 많은 구간에서 성능이 확연하게 차이가 날 경우는?

        대안으로 Big-O 표기법을 사용
        
        데이터가 늘어남에 따라 어떤식으로 연산이 증가하느냐
        
        ## BIG-O 표기법의 의의
        - 입력 N의 크기에 따라 성능이 영향을 받는 정도를 나타냄


## BIG-O 표기법 1단계 : 대략적인 계산
### 수행되는 연산(산술, 비교 대입 등)의 개수를 '대략적으로' 판단
```                   
public int Add(int N){
return N + N;
}
 // 1
```
```
public int Add2(int N){
    int sum =0;
    for(int i=0; i<N; i++){
        sum +=1;
    }
    return sum;
}
 // N+1
```
```
public int Add3(int N){
    int sum =0;
    for(int i=0; i<N; i++>){
        for(int j=0 ; j<N; j++){
            sum+=1;
        }
    }
    return sum;
}
 // N²+1
```
## BIG-O 표기법 2단계 : 대장만 남긴다

### 규칙 1) 영향력이 가장 큰 대표 항목만 남기고 삭제
### 규칙 2) 상수 무시 (ex.2N => N)

```
public int Add4(int N){
    int sum = 0;
    for(int i=0; i<N;i++){
        sum +=1;
    }
    for(int i=0; i<N *2; i++){
        for(int j=0; j<N*2; j++){
            sum+=1;
        }
    }
    sum+=1234567;
    return sum;
}
 /* 
    O(1 + N + 4 * N² + 1)
    =O(4 * N²)
    =O( N²)
    * O 는 Order Of 라고 읽어요! *
*/
```
## LOG 함수
        2¹ = 2
        2² = 2 * 2 =4
        2³ = 2 * 2 * 2 =8

                                2? = N
        a? = b                  ? = log₂(N)
        ? = log₀(b)

EX) 숫자 게임 1 ~ 100 반씩 줄여가며 정답 찾기 N/2⁰ =1
    N = 2⁰
    log₂(N) = ?
    
