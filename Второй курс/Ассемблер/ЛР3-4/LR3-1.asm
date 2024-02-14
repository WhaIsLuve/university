MySegment SEGMENT
    ORG 100h
    ASSUME CS:MySegment
Start:
mov al, a
mov bl, b
mov cl, c
cmp al, bl
jae aMoreb
jmp bMorea


aMoreb:
cmp al, cl
jae aMax
jmp cMax


bMorea:
cmp bl, cl
jae bMax
jmp cMax

cMax:
mov d, cl
jmp final 
 
aMax:
mov d, al
jmp final

bMax:
mov d, bl
jmp final

final:
mov al, d
int 21h



a db 4
b db 3
c db 10
d db ?

MySegment ENDS
END Start