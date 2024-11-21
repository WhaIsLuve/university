from functools import partial
import pickle
from timeit import Timer


li = [i for i in range(10000001)]
di = {i:i for i in range(10000001)}

def list_add():
    l = []
    for i in range(10000000):
        l.append(i)
        
def dict_add():
    d = {}
    for i in range(10000000):
        d[i] = i
        
def list_add_generator():
    l = [i for i in range(10000000)]
    
def dict_add_generator():
    l = {i:i for i in range(10000000)}
    
def list_find():
    li.index(10000000)
    
def dict_find():
    di.get(10000000)
    
def dict_change():
    di[1322] = 1322
    
def list_change():
    li[1322] = 1322
    
def dict_merge():
    di.update({"d": 23, "32": 23})
    
def list_merge():
    li.extend([2,2,2,2,2,3,3,3,3,3,3,33,3,3,3,3,3])
    
def list_pop():
    li.pop(5000000)
    
def dict_pop():
    di.pop(5000000)
    
def test(func):
    timer = Timer(partial(func)).timeit(number=1)
    print(f"{func.__name__}: {'%.6f'%timer} sec")


test(list_add)
test(list_add_generator)
test(dict_add)
test(dict_add_generator)
test(list_find)
test(dict_find)
test(list_change)
test(dict_change)
test(list_merge)
test(dict_merge)
test(list_pop)
test(dict_pop)

print("-------------------------------------------------Работа с файлом-------------------------------------------------")

def save_data_in_file():
    """
    Сохранение данных в файл
    """
    with open("lr3.pkl", "wb") as file:
        pickle.dump((li[:1000], {i:i for i in range(1000)}), file)

def get_collections_from_file():
    """
    Загрузка данных из файла
    """
    with open("lr3.pkl", "rb") as file:
        loaded_a, loaded_b = pickle.load(file)
    return loaded_a, loaded_b

save_data_in_file()
print(get_collections_from_file())