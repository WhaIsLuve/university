MySegment SEGMENT
    ORG 100h
    ASSUME CS:MySegment
Start:
jmp while


while:
mov al, b
div c
add al, ah
cmp al, k
jnz condition
inc ch
jmp conditon2

condition:
inc b
jmp conditon2

conditon2:
mov al, a
mov bl, b
cmp bl, al
jnz while
jmp final

final:
mov al, ch
int 21h

a db 99
b db 10
c db 10
k db 3
           
MySegment ENDS
END Start