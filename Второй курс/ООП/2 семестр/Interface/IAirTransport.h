#pragma once
class IAirTransport
{
	public:
		/// <summary>Возвращает вместимость транспорта.</summary>
		/// <returns>Вместимость транспорта.</returns>
		virtual int GetCapacity() = 0;

		/// <summary>Возвращает вес транспорта.</summary>
		/// <returns>Вес транспорта.</returns>
		virtual double GetWeight() = 0;

		/// <summary>Возвращает в воздухе ли транспорт.</summary>
		/// <returns>Воздухе ли транспорт.</returns>
		virtual bool GetIsFlying() = 0;

		/// <summary>Возвращает приземлился ли транспорт.</summary>
		/// <returns>Приземлился ли транспорт.</returns>
		virtual bool GetIsLanding() = 0;
		
		/// <summary>Позволяет взлететь.</summary>
		virtual void Fly() = 0;
		
		/// <summary>Приземлиться.</summary>
		virtual void Land() = 0;
};

