#include <stdio.h>

int main(void) {
    int n;
    
    // 사용자로부터 자연수 입력 받기
    scanf("%d", &n);
    
    // 짝수인지 홀수인지 판단하여 출력
    if (n % 2 == 0) {
        printf("%d is even\n", n);
    } else {
        printf("%d is odd\n", n);
    }

    return 0;
}