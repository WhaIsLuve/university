                MySegment SEGMENT
    ORG 100h
    ASSUME CS:MySegment
Start:
mov ax, a
mov bx, b
cmp ax, bx
jae Fa
jmp anotherComp


Fa:
;f=4*a+b/c-6
mov ax, b
mov bx, c
idiv bx
sub ax, 6
mov time, ax
mov ax, a
mov bx, 4
imul bx
add ax, time
jmp final

anotherComp:
mov ax, b
mov bx, c
cmp ax, bx
jae Fb
jmp Fc



Fb:
;f=6-c*(a+b)
mov ax, a
mov bx, b
mov cx, c
add ax, bx
imul cx
mov bx, ax
mov ax, 6
sub ax, bx
jmp final

Fc:
;f=3/a-(7+b)*5
mov bx, a
mov ax, 3
idiv bx
mov time, ax
mov bx, b
mov ax, 7 
mov cx, 5
add ax, bx
imul cx
mov bx, ax
mov ax, time
sub ax, bx
jmp final

final:
mov f, ax
int 21h

a dw 1
b dw 6
c dw 8
f dw ? 
time dw ?

MySegment ENDS
END Start