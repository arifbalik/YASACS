#include <stdio.h>

#define __EXIT1(cmd) printf(#cmd)
#define __EXIT0(cmd) (strlen(cmd) ? 0 : 1)
#define __EXIT(s) return __EXIT##s("Hello World!");


int main(){
    
  __EXIT(1)
  
}
