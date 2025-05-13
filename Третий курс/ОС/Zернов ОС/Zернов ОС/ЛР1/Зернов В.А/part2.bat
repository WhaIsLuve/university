@echo off
echo off chcp 65001
set fileName=vlad
for /l %%i in (1 1 %~1) do break > %fileName%_%%i.%~2