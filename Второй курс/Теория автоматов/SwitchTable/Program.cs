using ClosedXML.Excel;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace SwitchTable;
internal class Program
{
	static void Main()
	{
		const string directory = @"C:\Users\Влад\Desktop\Университет\Второй курс\Теория автоматов\курсовая";
		var pathToSwitchState = Path.Combine(directory, "регулярка.xlsx");
		var pathToSwitchTable = Path.Combine(directory, "Таблица-переходов.xlsx");

		using var workBookSwitchState = new XLWorkbook(pathToSwitchState);

		var workSheetSwitchState = workBookSwitchState.Worksheet(1);

		var cells = workSheetSwitchState.Cells("A2:A289").Select(val => val.GetFormattedString()).Where(s => s != "").ToList();

		var allSwitchStates = cells.Select(str => State.CreateState(str)).ToList();

		workBookSwitchState.Save();

		using var workBookSwitchTable = new XLWorkbook(pathToSwitchTable);

		var workSheetSwitchTable = workBookSwitchTable.Worksheet(1);

		char[] Az = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '>', '<', '!', '=', '+', '-', '*', '/', '%', ' '];
		char[] d = ['z', '>', '<', '!', '=', '+', '-', '*', '/', '%', ' '];
		int index = 2;
		foreach (char c in Az)
			workSheetSwitchTable.Row(1).Cell(index++).SetValue(c.ToString());

		for (int i = 1; i <= 218; i++)
			workSheetSwitchTable.Column(1).Cell(i+1).SetValue($"S{i}");

		for(int i = 1; i < Az.Length; i++)
		{
			workSheetSwitchTable.Row(i).Cell(i + 1).SetValue("-");
		}
		foreach (State state in allSwitchStates)
		{
			if (state.CurrentState == "S46" || state.NextState == "S46" || state.CurrentState == "S45" || state.NextState == "S45" || state.CurrentState == "S47" || state.NextState == "S47" || state.CurrentState == "S48" || state.NextState == "S48") continue;
			if(state.CurrentState == "S184")
			{
				
			}
			int indexCol = Az.ToList().FindIndex(0, c => c == state.Symbol[0])+1;
			if (indexCol == -1) continue;
			int indexRow = int.Parse(state.CurrentState[1..]) + 1;
			if (state.Symbol[0] == 'z')
			{
				workSheetSwitchTable.Cell($"AA{indexRow}").Value = state.NextState;
			}
			else if (state.Symbol[0] == '>')
			{
				workSheetSwitchTable.Cell($"AB{indexRow}").Value = state.NextState;
			}
			else if (state.Symbol[0] == '<')
			{
				workSheetSwitchTable.Cell($"AC{indexRow}").Value = state.NextState;
			}
			else if (state.Symbol[0] == '!')
			{
				workSheetSwitchTable.Cell($"AD{indexRow}").Value = state.NextState;
			}
			else if (state.Symbol[0] == '=')
			{
				workSheetSwitchTable.Cell($"AE{indexRow}").Value = state.NextState;
			}
			else if (state.Symbol[0] == '+')
			{
				workSheetSwitchTable.Cell($"AF{indexRow}").Value = state.NextState;
			}
			else if (state.Symbol[0] == '-')
			{
				workSheetSwitchTable.Cell($"AG{indexRow}").Value = state.NextState;
			}
			else if (state.Symbol[0] == '*')
			{
				workSheetSwitchTable.Cell($"AH{indexRow}").Value = state.NextState;
			}
			else if (state.Symbol[0] == '/')
			{
				workSheetSwitchTable.Cell($"AI{indexRow}").Value = state.NextState;
			}
			else if (state.Symbol[0] == '%')
			{
				workSheetSwitchTable.Cell($"AJ{indexRow}").Value = state.NextState;
			}
			else
			{ 
				workSheetSwitchTable.Cell($"{Az[indexCol].ToString().ToUpper()}{indexRow}").Value = state.NextState;
			}
			Console.WriteLine(state.UnformedString);

		}


		workBookSwitchTable.Save();
	}
}

class State
{
	public string CurrentState { get; set; }
	public string Symbol { get; set; }

	public string NextState { get; set; }

	public string UnformedString { get; set; }

	public State(string? currentState, string? symbol, string? nextState, string unformedString)
	{
		CurrentState = currentState;
		Symbol = symbol;
		NextState = nextState;
		UnformedString = unformedString;
	}

	public static State CreateState(string unformedString)
	{
		var st = unformedString.Split(" -> ");
		string? currentState = null;
		string? symbol = null;
		string? nextState = null;
		StringBuilder currentWord = new();
		int index = 1;
		currentWord.Append(unformedString[index++]);
		while(unformedString[index] != '(' && unformedString[index] != ')' && currentWord.ToString() != "->" && unformedString[index] != ';' && unformedString[index] != ' ' && unformedString[index] != ',')
		{
			currentWord.Append(unformedString[index++]);
		}
		currentState = currentWord.ToString();
		currentWord.Append(unformedString[index++]);
		currentWord.Clear();
		currentWord.Append(unformedString[index++]);
		while (unformedString[index] != '(' && unformedString[index] != ')' && currentWord.ToString() != "->" && unformedString[index] != ';' && unformedString[index] != ' ' && unformedString[index] != ',')
		{
			currentWord.Append(unformedString[index++]);
		}
		symbol = currentWord.ToString().Trim();
		currentWord.Clear();
		nextState = st[^1];
		return new State(currentState, symbol, nextState, unformedString);
	}
}