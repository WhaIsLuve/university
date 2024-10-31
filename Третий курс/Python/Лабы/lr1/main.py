from math import exp, log2

# (a^2 – 4) / (b + c) – not d
# e^a or b / c – d ∙ 5 or log_2⁡d 

def main():
    a = float(input("Введите а: "))
    b = float(input("Введите b: "))
    c = float(input("Введите c: "))
    d = float(input("Введите d: "))
    print("FIRST EXAMPLE")
    print((a**2 -4) / (b + c) - (~int(d)))
    print("SECOND EXAMPLE")
    print(int(exp(a)) | int(b / c - d * 5) | int(log2(d)))    


if(__name__ == "__main__"):
    main()