from turtle import Turtle, numinput


def draw_square(figure: Turtle):
    length = numinput("Введите длину стороны квадрата", "")
    for i in range(4):
        figure.forward(length)
        figure.left(90)
        

def draw_triangle(figure: Turtle):
    length = numinput("Введите длину стороны треугольника", "")
    for i in range(3):
        figure.forward(length)
        figure.left(120)
        
def draw_circle(figure: Turtle):
    radius = numinput("Введите радиус круга", "")
    figure.circle(radius)

def main():
    figure = Turtle()
    prompt = "INFO\n1 - квадрат\n2 - круг\n3 - р/с треугольник\n4 - все сразу"
    while(True):
        figure_number = numinput("Введите номер фигуры", prompt)
        figure.clear()
        if figure_number == 1:
                draw_square(figure)
        elif figure_number == 2:
                draw_circle(figure)
        elif figure_number == 3:
                draw_triangle(figure)
        elif figure_number == 4:
                draw_square(figure)
                draw_triangle(figure)
                draw_circle(figure)
        else:
            break

if(__name__ == "__main__"):
    main()