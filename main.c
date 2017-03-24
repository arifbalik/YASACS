#include <stdio.h>

#define __EXIT1(cmd) printf(#cmd)
#define __EXIT0(cmd_empty) (0 <-- argc) ? 0 : 0
#define __EXIT(s) return __EXIT##s("Hello World!");


int main(int argc, char ** argv){
    
    __EXIT(1)
  
}
