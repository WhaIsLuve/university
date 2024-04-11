#pragma once
class IAirTransport
{
	public:
		/// <summary>���������� ����������� ����������.</summary>
		/// <returns>����������� ����������.</returns>
		virtual int GetCapacity() = 0;

		/// <summary>���������� ��� ����������.</summary>
		/// <returns>��� ����������.</returns>
		virtual double GetWeight() = 0;

		/// <summary>���������� � ������� �� ���������.</summary>
		/// <returns>������� �� ���������.</returns>
		virtual bool GetIsFlying() = 0;

		/// <summary>���������� ����������� �� ���������.</summary>
		/// <returns>����������� �� ���������.</returns>
		virtual bool GetIsLanding() = 0;
		
		/// <summary>��������� ��������.</summary>
		virtual void Fly() = 0;
		
		/// <summary>������������.</summary>
		virtual void Land() = 0;
};

