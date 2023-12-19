MySegment SEGMENT
ORG 100h
ASSUME CS:MySegment
Start:
;8. P(i * (j + 1))
mov cx, N
m1:
mov ax, j
add ax, 1
mul i
mul f
mov f, ax
inc i
loop m1
mov bx, f
mov ax, 4100h
int 21h


N dw 4
i dw 1
j dw 5
one dw 1
f dw 1

MySegment ENDS
END Start