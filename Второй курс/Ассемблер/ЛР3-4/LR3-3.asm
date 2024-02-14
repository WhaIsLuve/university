MySegment SEGMENT
    ORG 100h
    ASSUME CS:MySegment
Start:
jmp while


while:
mov al, zero
mov ah, zero
mov al, b
div ten
add al, ah
cmp al, k
jnz condition
inc ch
jmp condition

condition:
mov al, a
mov bl, b
inc b
cmp bl, al
jnz while
jmp final

final:
mov al, ch
int 21h

a db 99
b db 10
ten db 10
k db 12
zero db 0
           
MySegment ENDS
END Start