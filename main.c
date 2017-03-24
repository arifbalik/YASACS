#include <stdio.h>

#define EXIT(status) return status;

int main(){
  
  printf("Hello World!");
  
  return EXIT(1);
}
