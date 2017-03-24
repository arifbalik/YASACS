#include <stdio.h>

#define __EXIT(status) return ##status;

int main(){
  
  printf("Hello World!");
  
  return __EXIT(1);
}
