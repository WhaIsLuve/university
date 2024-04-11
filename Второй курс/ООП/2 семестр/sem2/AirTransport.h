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
};

