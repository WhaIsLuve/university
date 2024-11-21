from abc import ABC, abstractmethod


class AirTransport(ABC):
    def __init__(self, id, name):
        super().__init__()
        assert id < 0, "Идентификатор не может быть меньше 0"
        self.id = id
        self.name = name
    
    @abstractmethod
    def get_type(self):
        return "Воздушный транспорт"
    
    def __str__(self) -> str:
        return self._to_str()
    
    def _to_str(self):
        return f"{self.id}\n{self.name}\n{self.get_type()}"
    
    
class Plane(AirTransport):
    
    def __init__(self, id, name, power, max_capacity, capacity):
        super().__init__(id, name)
        self.power = power
        self.max_capacity = max_capacity
        self.capacity = capacity
    
    def get_type(self):
        return "Самолет"
    
    @staticmethod
    def create(id, name, power, max_capacity, capacity):
        return Plane(id, name, power, max_capacity, capacity)
    
    def __str__(self) -> str:
        return self.__to_str()
    
    def set_capacity(self, capacity):
        if capacity > self.max_capacity:
            raise CapacityBiggerThanMaxCapacity()
        self.capacity = capacity
    
    def __to_str(self):
        return f"{super()._to_str()}\n{self.power}\n{self.capacity}\n{self.max_capacity}\n"
    

class CapacityBiggerThanMaxCapacity(TypeError):
    pass
    