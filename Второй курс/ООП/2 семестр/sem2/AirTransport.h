#pragma once
#include "IAirTransport.h"

class AirTransport : public IAirTransport
{
	protected:
		int _capacity;
		double _weight;
		bool _isFlying;
		bool _isLanding;
	public:
		AirTransport();
		/// <summary>Создание объекта AirTransport.</summary>
		/// <param name="capacity">Вместимость.</param>
		/// <param name="weight">Вес.</param>
		AirTransport(int capacity, double weight);
		/// <summary>Возвращает вместимость транспорта.</summary>
		/// <returns>Вместимость транспорта.</returns>
		int GetCapacity();

		/// <summary>Задает вместимость транспорта.</summary>
		/// <param name="capacity">Вместимость транспорта.</param>
		void SetCapacity(int capacity);

		/// <summary>Возвращает вес транспорта.</summary>
		/// <returns>Вес транспорта.</returns>
		double GetWeight();

		/// <summary>Задает вес транпорта.</summary>
		/// <returns>Вес транспорта.</returns>
		void SetWeight(double weight);

		/// <summary>Возвращает в воздухе ли транспорт.</summary>
		/// <returns>Воздухе ли транспорт.</returns>
		bool GetIsFlying();

		/// <summary>Возвращает приземлился ли транспорт.</summary>
		/// <returns>Приземлился ли транспорт.</returns>
		bool GetIsLanding();

		/// <summary>Позволяет взлететь.</summary>
		void Fly();

		/// <summary>Приземлиться.</summary>
		void Land();
};

