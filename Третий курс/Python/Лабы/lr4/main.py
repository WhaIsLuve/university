from AirTransport import CapacityBiggerThanMaxCapacity, Plane


def main():
    plane = Plane(1, "superjet", 300, 40, 20)
    plane2 = Plane.create(2, "superjet", 400, 30, 10)
    do_smth(plane)
    do_smth(plane2)
    print(f"capacity: {plane.capacity}")
    try:
        plane.set_capacity(int(input("Введите вместимость для самолета ")))
        print(f"capacity after change: {plane.capacity}")
    except CapacityBiggerThanMaxCapacity:
        print("Вместимость не может быть больше маскмиальной вместимости.")
    finally:
        print("Это блок finally. До свидания")
    

def do_smth(air_transport):
    if issubclass(type(air_transport), Plane):    
        print(air_transport)
        print(air_transport.get_type())
    else:
        raise TypeError("air_transport не является производным классом AirTransport")

if(__name__ == "__main__"):
    main()