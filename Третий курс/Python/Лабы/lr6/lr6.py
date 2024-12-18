import turtle
import random


def RP(axi, word, index):
    axi = axi[:index] + word + axi[index + 1:]
    return axi, len(word)


def generate_l_system(axiom, iterations):
    for _ in range(iterations):
        lvl = 0
        index = 0
        while index < len(axiom):
            word = ''
            if axiom[index] == "T" and lvl > 1 and random.randint(0, 99) < 10:  
                    word = "R[^RL]"
            elif axiom[index] == "L":
                word = "B[<TL][>TL]"
            elif axiom[index] == "B":
                word = "TB"
            elif axiom[index] == "[":
                lvl += 1
            elif axiom[index] == "]":
                lvl -= 1

            if word:
                axiom, length = RP(axiom, word, index)
                index += length
            else:
                index += 1
    return axiom


def setup_turtle():
    turtle.speed(0)
    turtle.tracer(0)
    turtle.hideturtle()
    turtle.penup()
    turtle.goto(0, -300) 
    turtle.setheading(90) 
    turtle.pendown()
    turtle.pencolor('saddlebrown')

def draw_tree(sequence, length, thickness):
    stack = [] 
    for char in sequence:
        if (char == 'T' or char == 'B' or char == 'R') and random.random() > 0.5:  
                turtle.pensize(thickness)
                turtle.forward(length)

        elif char == 'L':  
            draw_leaf(length)
        elif char == '[':  
            stack.append((turtle.position(), turtle.heading(), thickness))
            thickness *= 0.75  
        elif char == ']':  
            position, heading, thickness = stack.pop()
            turtle.penup()
            turtle.goto(position)
            turtle.setheading(heading)
            turtle.pendown()
        elif char == '<':  
            turtle.left(14 - random.uniform(-14, 14))
        elif char == '>':  
            turtle.right(14 - random.uniform(-14, 14))
        elif char == '^':  
            angle = random.uniform(-30, 30)
            if (angle < 0) : angle-=25
            else: angle +=25
            turtle.left(angle)

def draw_leaf(length):
    leaf_type = random.choices(
        ['mandarin', 'bright', 'slightly_different', 'normal'],
        [5, 15, 20, 60]
    )[0]

    if leaf_type == 'mandarin':
        turtle.fillcolor('orange')
        scale_factor = 2
    elif leaf_type == 'bright':  
        turtle.fillcolor('lime')
        scale_factor = 1
    elif leaf_type == 'slightly_different':
        turtle.fillcolor('darkgreen')
        scale_factor = 1
    else:  
        turtle.fillcolor('green')
        scale_factor = 1

    turtle.pencolor('black')
    turtle.pensize(1)

    turtle.begin_fill()
    turtle.circle((length/3) * scale_factor)
    turtle.end_fill()

    turtle.pensize(1)
    turtle.pencolor('saddlebrown')

axiom = "TTTTL"
iterations = 12  
sequence = generate_l_system(axiom, iterations)
print(sequence)
setup_turtle()  
draw_tree(sequence, 10, 20)  
turtle.done() 