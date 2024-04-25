#pragma once
#include "IAirTransport.h"

class AirTransport : public IAirTransport
{
	private:
		bool _isFlying;
		bool _isLanding;
	protected:
		int _capacity;
		double _weight;
	public:
		AirTransport();
		/// <summary>�������� ������� AirTransport.</summary>
		/// <param name="capacity">�����������.</param>
		/// <param name="weight">���.</param>
		AirTransport(int capacity, double weight);
		/// <summary>���������� ����������� ����������.</summary>
		/// <returns>����������� ����������.</returns>
		int GetCapacity();

		/// <summary>������ ����������� ����������.</summary>
		/// <param name="capacity">����������� ����������.</param>
		void SetCapacity(int capacity);

		/// <summary>���������� ��� ����������.</summary>
		/// <returns>��� ����������.</returns>
		double GetWeight();

		/// <summary>������ ��� ���������.</summary>
		/// <returns>��� ����������.</returns>
		void SetWeight(double weight);

		/// <summary>���������� � ������� �� ���������.</summary>
		/// <returns>������� �� ���������.</returns>
		bool GetIsFlying();

		/// <summary>���������� ����������� �� ���������.</summary>
		/// <returns>����������� �� ���������.</returns>
		bool GetIsLanding();

		/// <summary>��������� ��������.</summary>
		void Fly();

		/// <summary>������������.</summary>
		void Land();

		bool operator==(const AirTransport& transport);
		bool operator>(const AirTransport& transport);
		bool operator>=(const AirTransport& transport);
		bool operator<(const AirTransport& transport);
		bool operator<=(const AirTransport& transport);
		bool operator!=(AirTransport& transport);
};

