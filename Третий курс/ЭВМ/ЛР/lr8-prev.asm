rd #11 ; keyboard init
out 1
out 11
rd #103
out 1
rd #0 ; counter init
wr 500
rd #35 ; keyboard limit
wr 501
rd #13
wr 100

EI
main:
nop
nop
jmp main

handler:
in 0 ; read keyboard
out 10 ; write on display
rd 500 ; increment counter
add #1
wr 500
jmp isLength35 
afterCheck:
iret

isLength35: ; check length in keyboard buffer
rd 501
sub 500
jz clearKeyboardBuffer
jnz afterCheck

clearKeyboardBuffer: ; clear keyboard buffer and set counter to 0
rd #101
out 1
rd #0
wr 500
jmp afterCheck