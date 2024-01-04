#Ассемблер 
# Шаг 1
Для начала нужно подготовить все для запуска
1.  Создать на диске папку(в моем случае это ass), в которой будут две папки tasm и code.
  ![image](https://github.com/WhaIsLuve/university/assets/114782978/5be98ce4-4948-41a1-961a-55d715e8d799)

2. В папке tasm находится Turbo Assembler(если нет, то скопируй содержимое куда скачивал его)
      ![image](https://github.com/WhaIsLuve/university/assets/114782978/32eadee3-e2b1-4dd8-9e01-b12afda46ccc)

3. В папке code находятся твои файлы с расширением `.asm`
4. Папка для запуска кода в DOSBOX готова
# Шаг 2
Теперь нужно настроить DOSBOX для удобства
1. Через сочетание клавиш `Win + S` открываем поиск и вводим dosbox и открываем options
   ![image](https://github.com/WhaIsLuve/university/assets/114782978/51008842-e098-47a5-b452-e90c241d2410)
2. В конце конфигурационного файла добавляем несколько строк и сохраняем после этого:
	`mount c c:\ass`
	`c:`
3. Запускаем DOSBOX и он должен открыться на диске `C:/`
4. Через команду `dir` проверяем директории на диске и там должны быть папки tasm и code. На картинке результат выполнения команды
   ![image](https://github.com/WhaIsLuve/university/assets/114782978/8e947f21-d9f5-4e71-928a-5e590b35df92)
# Шаг 3
Теперь все готово и можно запускать готовый на DOSBOX
1. Переходим в директорию `code` через команду `cd code`. На картинке результат выполнения команды
   ![image](https://github.com/WhaIsLuve/university/assets/114782978/48037ae5-2ab7-448a-99a8-710a56d661ff)
2. Вводим команду `c:\tasm\bin\tasm.exe curs.asm`. Через данную команду мы вызываем транслятор Turbo Assembler и он генерирует файл .obj, если в файле нет синтаксических ошибок. На картинке результат выполнения команды
   ![image](https://github.com/WhaIsLuve/university/assets/114782978/969a0410-ce9c-41b9-b1c6-53eaab4d6dae)
3. Вводим команду `c:\tasm\bin\tlink.exe curs.obj`.  Данная команда вызывает компоновщик, который компонует `.obj` файл в `.exe`. На картинке результат выполнения команды
   ![image](https://github.com/WhaIsLuve/university/assets/114782978/7c7fca3d-68da-4ca4-aeb2-f4283e267a18)
4. Вводим команду `c:\tasm\bin\td.exe curs.exe`. Данная команда вызывает отладчик в DOSBOX. На картинке результат выполнения команды
   ![image](https://github.com/WhaIsLuve/university/assets/114782978/24672924-bba8-43a0-b781-0d67a29f56db)
   Нажимаем OK и через клавишу f8 выполняется следующий шаг программы
